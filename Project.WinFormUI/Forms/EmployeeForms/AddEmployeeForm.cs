using Project.BLL.DesignPatterns.GenericRepository.EFConcRep;
using Project.BLL.Encryptor;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinFormUI.Forms.EmployeeForms
{
    public partial class AddEmployeeForm : Form
    {
        //Repository sınıfları aracılığıyla veritabanı işlemleri yapmak için gerekli örnekler oluşturuluyor.
        EmployeeRepository _employeeRepository; //Çalışan verilerini işlemek için kullanılan repository
        EmployeeProfileRepository _employeeProfileRepository; //Çalışan profillerini işlemek için kullanılan repository

        Employee _employee;  //Yeni eklenen çalışan nesnesi
        EmployeeProfile _employeeProfile; //Çalışan profil bilgileri

        public AddEmployeeForm()
        {
            InitializeComponent();
            //Repository örneklerini başlatıyoruz
            _employeeRepository = new EmployeeRepository(); //Çalışan verilerini almak ve güncellemek için kullanılır.
            _employeeProfileRepository = new EmployeeProfileRepository(); //Çalışan profillerini almak ve güncellemek için kullanılır.

            _employee = new Employee(); //Yeni bir çalışan nesnesi oluşturuluyor.

            LoadRoles(); //Rol listesini yükler
            LoadManagers(); //Yönetici listesini yükler
            LoadEmployeeList(); //Mevcut çalışanları listeye yükler
            ClearFields(); //Formu temizler

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapat
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            //Alanların boş olup olmadığını kontrol et.
            if (AreFieldsEmpty())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz."); //Eğer alanlar boşsa uyarı mesajı göster.
                return; //Fonksiyonu sonlandır.
            }

            //TC kimlik Numarası doğrulaması
            if (TxtTC.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli ve yalnızca rakamlardan oluşmalıdır."); //TC kimlik numarasının uzunluğu kontrol edilir.
                return; //Fonksiyonu sonlandır.
            }

            //Telefon numarası doğrulaması
            if (!_employeeProfileRepository.IsValidPhoneNumber(TxtPhoneNumber.Text))
            {
                MessageBox.Show("Telefon numarası en az 10 haneli ve yalnızca rakamlardan oluşmalıdır."); //Telefon numarasının geçerliliği kontrol edilir.
                return; //Fonksiyonu sonlandır.
            }

            //Şifre kontrolü
            if (!_employeeRepository.IsValidPassword(TxtPassword.Text))
            {
                MessageBox.Show("Şifre en az 8 karakterden oluşmalıdır."); //Şifrenin geçerliliği kontrol edilir.
                return; //Fonksiyonu sonlandır.
            }

            //Şifre doğrulama - Şifrelerin eşleşip eşleşmediği kontrol edilir.
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor. Lütfen tekrar kontrol ediniz."); //Şifreler eşleşmiyorsa uyarı gösterilir.
                TxtConfirmPassword.Clear(); //Şifre onay alanı temizlenir
                return; //Fonksiyonu sonlandır.
            }

            //E-posta doğrulaması
            if (!_employeeRepository.IsValidEmailFormat(TxtEmail.Text))
            {
                MessageBox.Show("Geçersiz e-posta formatı."); //E-posta formatının geçerliliği kontrol edilir.
                return; //Fonksiyonu sonlandır.
            }

            try
            {
                //Yeni Employee oluşturuluyor
                _employee = new Employee
                {
                    Email = TxtEmail.Text, //E-posta alınıyor
                    Role = (EmployeeRole)CmbRole.SelectedItem, //Rol seçimi yapılır
                    ManagerId = CmbManager.SelectedValue != null ? (int?)CmbManager.SelectedValue : null, //Yönetici seçimi yapılır (eğer varsa)
                    Password = PasswordEncryptor.Encode(TxtPassword.Text) //Şifre encode edilir (şifre şifrelenir)
                };
                //Employee nesnesi veritabanına ekleniyor.
                _employeeRepository.Add(_employee);

                //Yeni EmployeeProfile oluşturuluyor
                _employeeProfile = new EmployeeProfile
                {
                    FirstName = TxtFirstName.Text, //Çalışanın adı
                    LastName = TxtLastName.Text, //Çalışanın soyadı
                    TC = TxtTC.Text, //Çalışanın TC kimlik numarası
                    PhoneNumber = TxtPhoneNumber.Text, //Telefon numarası
                    Address = TxtAddress.Text, //Adres bilgisi
                    City = TxtCity.Text, //Şehir bilgisi
                    District = TxtDistrict.Text, //İlçe bilgisi
                    Employee = _employee //Employee nesnesi ile ilişkilendirme yapılır
                };

                //EmployeeProfile veritabanına ekleniyor
                _employeeProfileRepository.Add(_employeeProfile);

                //Başarı mesajı gösterilir
                MessageBox.Show("Çalışan başarıyla eklendi.");

                //Alanlar temizlenir
                ClearFields();

                //Çalışan listesi güncellenir
                LoadEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}"); //Hata oluşursa mesaj gösterilir.
            }
        }

        //Form Metotları
        private void LoadRoles()
        {
            List<EmployeeRole> roles = new List<EmployeeRole> //Çalışan rolleri listesini oluşturuyoruz.
            {
                EmployeeRole.Admin, //Admin rolü
                EmployeeRole.Organizer, //Organizer rolü
                EmployeeRole.Support, //Support rolü
                EmployeeRole.Sales, //Sales rolü
                EmployeeRole.Finance //Finance rolü
            };

            //Rolleri ComboBox'a bağlıyoruz
            CmbRole.DataSource = roles;
            CmbRole.SelectedIndex = -1; //Başlangıçta hiçbir seçim yapılmaz.
        }

        private void LoadManagers()
        {
            if (_employee.Role == EmployeeRole.Admin) //Eğer çalışan Admin rolüne sahipse, sadece Admin olanları yükle
            {
                //Admin rolüne sahip olanları filtreliyoruz
                var managerDisplayData = _employeeRepository
                    .GetAll() //Tüm çalışanları al
                    .Where(x => x.Role == EmployeeRole.Admin) //Admin rolüne sahip olanları filtrele
                    .Select(x => new
                    {
                        Display = x.ToString(), //Çalışanın ismini veya formatlanmış bilgisini almak
                        Value = x.Id //Çalışanın ID'sini almak
                    })
                    .ToList();

                //Filtrelenmiş verileri ComboBox'a bağlıyoruz
                CmbManager.DataSource = managerDisplayData;
                CmbManager.DisplayMember = "Display"; //Görüntülenecek alan: Adı vs.
                CmbManager.ValueMember = "Value"; //Seçilecek alan : ID
            }
        }

        private void LoadEmployeeList()
        {
            //Aktif çalışanları listeye yüklüyoruz
            LstCurrentEmployees.DataSource = _employeeProfileRepository.GetActives();
            LstCurrentEmployees.DisplayMember = "ToString"; //Görüntülenecek alan : Çalışan bilgisi
        }

        private void ClearFields()
        {
            //Tüm alanları temizler
            TxtFirstName.Clear(); //Ad alanını temizler
            TxtLastName.Clear(); //Soyad alanını temizler
            TxtPhoneNumber.Clear(); //Telefon numarası alanını temizler
            TxtEmail.Clear(); //E-posta alanını temizler
            TxtDistrict.Clear(); //İlçe alanını temizler
            TxtTC.Clear(); //TC Kimlik Numarası alanını temizler
            TxtConfirmPassword.Clear(); //Şifre onay alanını temizler
            TxtPassword.Clear(); //Şifre alanını temizler
            TxtAddress.Clear(); //Adres alanını temizler
            TxtCity.Clear(); //Şehir alanını temizler

            //ComboBox seçimlerini sıfırlar
            CmbManager.SelectedIndex = -1; //Yöneticiyi seçili yapmaz
            CmbRole.SelectedIndex = -1; //Rolü seçili yapmaz
        }

        private bool AreFieldsEmpty()
        {
            //Alanlardan herhangi biri boşsa true döner
            return TxtFirstName.Text == "" || //Ad alanı boş mu?
                   TxtLastName.Text == "" || //Soyad alanı boş mu?
                   TxtPhoneNumber.Text == "" || //Telefon numarası boş mu?
                   TxtEmail.Text == "" || //E-posta alanı boş mu?
                   TxtDistrict.Text == "" || //İlçe alanı boş mu?
                   TxtTC.Text == "" || //TC Kimlik Numarası boş mu?
                   TxtConfirmPassword.Text == "" || //Şifre onay boş mu?
                   TxtPassword.Text == "" || //Şifre boş mu?
                   TxtAddress.Text == "" || //Adres alanı boş mu?
                   TxtCity.Text == ""; //Şehir alanı boş mu?
        }
    }
}
