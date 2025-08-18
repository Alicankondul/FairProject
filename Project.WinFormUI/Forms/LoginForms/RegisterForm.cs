using Project.BLL.DesignPatterns.GenericRepository.EFConcRep;
using Project.BLL.Encryptor;
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

namespace Project.WinFormUI.Forms.LoginForms
{
    public partial class RegisterForm : Form
    {
        //Repository sınıfları aracılığıyla veritabanı işlemlerini gerçekleştirmek için örnekler oluşturulur.
        CustomerRepository _customerRepository;
        CustomerDetailRepository _customerDetailRepository;

        //Müşteri ve müşteri detaylarını temsil edecek nesneler tanımlanır.
        Customer _customer;
        CustomerDetail _customerDetail;

        public RegisterForm()
        {
            InitializeComponent();

            _customerRepository = new CustomerRepository();
            _customerDetailRepository = new CustomerDetailRepository();
        }

        //İptal butonuna basıldığında formu kapatır.
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Kaydet butonuna basıldığında çalışacak olan metot
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Tüm alanların doldurulup doldurulmadığını kontrol eder.
            if (IsAllFieldsFilled()) //Eğer herhangi bir textboximiz boş ise bu bloga girer
            {
                ShowError("Lütfen tüm alanları doldurunuz.");
                return;
            }

            //Girilen e-posta formatını doğrular.
            if (!_customerRepository.IsValidEmailFormat(TxtContactEMail.Text))
            {
                ShowError("Geçersiz e-posta formatı. Lütfen doğru bir e-posta adresi giriniz.");
                return;
            }

            //Girilen telefon numarasının formatını doğrular.
            if (!_customerDetailRepository.IsValidPhoneNumber(TxtContactPhoneNumber.Text))
            {
                ShowError("Geçersiz telefon numarası formatı. Lütfen doğru bir telefon numarası giriniz.");
                return;
            }

            //Şifrenin geçerli bir formatta olup olmadığını kontrol eder.
            if (!_customerRepository.IsValidPassword(TxtPassword.Text))
            {
                ShowError("Geçersiz şifre formatı. Lütfen en az 8 karakterli şifre belirleyiniz.");
                return;
            }

            //Girilen e-postanın zaten kayıtlı olup olmadığını kontrol eder
            if (_customerRepository.IsEmailRegistered(TxtContactEMail.Text))
            {
                ShowError("Bu email sistemde kayıtlıdır. Lütfen geçerli bir email giriniz.");
                TxtContactEMail.Text = "";
                return;
            }

            //Girilen şifrelerin birbirine eşit olup olmadığını kontrol eder
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                ShowError("Şifreler birbiri ile uyuşmamaktadır. Lütfen kontrol ediniz.");
                TxtConfirmPassword.Text = "";
                return;
            }

            //Yeni müşteri nesnesi oluşturulur
            _customer = new Customer
            {
                ContactEmail = TxtContactEMail.Text,
                Password = PasswordEncryptor.Encode(TxtPassword.Text)
            };

            //Yeni müşteri detayı nesnesi oluşturulur
            _customerDetail = new CustomerDetail
            {
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                CompanyName = TxtCompanyName.Text,
                ContactPhoneNumber = TxtContactPhoneNumber.Text,
            };

            try
            {
                //Müşteri ve müşteri detayı birlikte kayıt edilir
                _customerRepository.Add(_customer);
                _customerDetail.Id = _customer.Id;
                _customerDetailRepository.Add(_customerDetail);

                ShowInfo("Kayıt başarılı bir şekilde tamamlanmıştır.");
                Close(); //İşlem tamamlandıktan sonra formu kapatır.
            }
            catch (Exception ex)
            {
                ShowError(ex.Message); //Hata mesajını kullanıcıya gösterir
            }
        }

        //Tüm alanların doldurulup doldurulmadığını kontrol eden yardımcı metot
        private bool IsAllFieldsFilled()
        {
            return TxtFirstName.Text == "" || TxtLastName.Text == "" || TxtCompanyName.Text == "" || TxtContactPhoneNumber.Text == "" || TxtContactEMail.Text == "" || TxtPassword.Text == "" || TxtConfirmPassword.Text == "";
        }

        //Kullanıcıya bir hata mesajı göstermek için kullanılan yardımcı metot
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Kullanıcıya bilgilendirme mesajı göstermek için kullanılan yardımcı metot
        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
