using Project.BLL.DesignPatterns.GenericRepository.EFConcRep;
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
    public partial class UpdateDeleteEmployeeForm : Form
    {
        //EmployeeProfile ve Employee verilerini yönetmek için repository nesneleri 
        EmployeeProfileRepository _profileRepository;
        EmployeeProfile _selectedProfile;

        EmployeeRepository _employeeRepository;
        Employee _selectedEmployee;

        public UpdateDeleteEmployeeForm()
        {
            //Repository nesnelerini başlat
            _profileRepository = new EmployeeProfileRepository();
            _employeeRepository = new EmployeeRepository();
            InitializeComponent(); //Form bileşenleri yükle
            LoadProfile(); //Profilleri listeye yükle
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Formu kapat
            Close();
        }

        private void LstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listeden bir öğe seçildiyse
            if (LstEmployees.SelectedItem != null)
            {
                _selectedProfile = (EmployeeProfile)LstEmployees.SelectedItem; //Seçilen profili ata

                //Employee nesnesini Profile üzerinden al
                _selectedEmployee = _selectedProfile.Employee;

                //Form alanlarını seçilen profil ve çalışan bilgileriyle doldur
                TxtCity.Text = _selectedProfile.City;
                TxtDistrict.Text = _selectedProfile.District;
                TxtAddress.Text = _selectedProfile.Address;
                TxtEmail.Text = _selectedEmployee?.Email ?? string.Empty; //Null kontrolü yap
                TxtFirstName.Text = _selectedProfile.FirstName;
                TxtLastName.Text = _selectedProfile.LastName;
                TxtPhoneNumber.Text = _selectedProfile.PhoneNumber;
                TxtTC.Text = _selectedProfile.TC;

                //Label'ı seçilen çalışanın adıyla güncelle
                LblSelectedEmployee.Text = $"Seçilen Çalışan: {_selectedProfile.FirstName} {_selectedProfile.LastName}";
            }
            else
            {
                ClearFields(); //Eğer bir seçim yoksa alanları temizle
            }

        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //Eğer bir çalışan seçilmemişse uyarı göster
            if (_selectedProfile == null || _selectedEmployee == null)
            {
                MessageBox.Show("Lütfen bir çalışan seçiniz.");
                return;
            }

            try
            {
                //Seçilen profili sil
                _profileRepository.Delete(_selectedProfile);
                _employeeRepository.Delete(_selectedEmployee);

                //Kullanıcıya başarı mesajı göster
                MessageBox.Show("Çalışan başarıyla silindi.");

                LoadProfile(); //Listeyi yeniden yükle
                ClearFields(); //Formu temizle
            }
            catch (Exception ex)
            {
                //Hata oluşursa kullanıcıya bildir
                MessageBox.Show($"Bir hata oluştu : {ex.Message}");
            }
        }

        private void BtnUpdateEmployee_Click(object sender, EventArgs e)
        {
            //Eğer bir çalışan seçilmemişse uyarı göster
            if (_selectedProfile == null)
            {
                MessageBox.Show("Lütfen bir çalışan seçiniz.");
                return;
            }

            try
            {
                //Seçilen profilin bilgilerini güncelle
                _selectedProfile.City = TxtCity.Text;
                _selectedProfile.District = TxtDistrict.Text;
                _selectedProfile.Address = TxtAddress.Text;
                _selectedProfile.TC = TxtTC.Text;
                _selectedProfile.PhoneNumber = TxtPhoneNumber.Text;
                _selectedEmployee.Email = TxtEmail.Text;
                _selectedProfile.FirstName = TxtFirstName.Text;
                _selectedProfile.LastName = TxtLastName.Text;

                //Güncellenen bilgileri veritabanına kaydet
                _profileRepository.Update(_selectedProfile);
                _employeeRepository.Update(_selectedEmployee);

                //Kullanıcıya başarı mesajı göster
                MessageBox.Show("Çalışan başarıyla güncellendi.");

                LoadProfile(); //Listeyi yeniden yükle
                ClearFields(); //Formu temizle
            }
            catch (Exception ex)
            {
                //Hata oluşursa kullanıcıya bildir
                MessageBox.Show($"Bir hata oluştu : {ex.Message}");
            }
        }

        //Form Metotları
        private void LoadProfile()
        {
            //Aktif profilleri yükle
            LstEmployees.DataSource = _profileRepository.GetActives(); //Aktif profilleri getir
            LstEmployees.DisplayMember = "ToString"; //Listeleme için ToString özelliğini kullan
        }

        private void ClearFields()
        {
            //Formdaki tüm alanları temizle
            TxtCity.Clear();
            TxtDistrict.Clear();
            TxtAddress.Clear();
            TxtEmail.Clear();
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtPhoneNumber.Clear();
            TxtTC.Clear();

            //Label'ı varsayılan değerle güncelle
            LblSelectedEmployee.Text = "Seçilen Çalışan : Yok";

            //Seçilen profil ve çalışan nesnelerini null olarak ayarla
            _selectedProfile = null;
        }
    }
}
