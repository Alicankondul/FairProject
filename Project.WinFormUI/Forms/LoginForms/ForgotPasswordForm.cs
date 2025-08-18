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
    public partial class ForgotPasswordForm : Form
    {
        //Repositories : Veri tabanı işlemleri için gerekli olan repository nesneleri.
        CustomerDetailRepository _customerDetailRepository;
        CustomerRepository _customerRepository;

        //Müşteri bilgilerini tutacak nesne
        Customer _customer;

        public ForgotPasswordForm()
        {
            InitializeComponent();

            //Başlangıçta şifre ile ilgili kontrolleri gizler
            KontrolleriGizle(false);

            //Repositories örneklerini oluştur
            _customerDetailRepository = new CustomerDetailRepository();
            _customerRepository = new CustomerRepository();
        }

        //İptal butonuna basıldığında formu kapatır
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Submit butonuna basıldığında müşterinin bilgilerini kontrol eder
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Eğer zorunlu alanlardan biri boşsa hata mesajı göster
            if (TxtFirstName.Text == "" || TxtLastName.Text == "" || TxtCompanyName.Text == "" || TxtContactEMail.Text == "")
            {
                ShowError("Lütfen tüm alanları doldurunuz.");
                return;
            }

            //Girilen bilgilerin doğruluğunu kontrol et
            if (!_customerDetailRepository.ValidateCustomerDetails(TxtFirstName.Text, TxtLastName.Text, TxtCompanyName.Text, TxtContactEMail.Text))
            {
                ShowError("Girdiğiniz bilgiler doğru değil. Lütfen kontrol ediniz.");
                return;
            }
            else KontrolleriGizle(true); //Kontroller doğruysa şifre giriş alanlarını görünür hale getir
        }

        //Şifreyi kaydet butonuna basıldığında işlemleri gerçekleştirir
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Eğer şifre alanlarından biri boşsa hata mesajı göster
            if (TxtPassword.Text == "" || TxtConfirmPassword.Text == "")
            {
                ShowError("Lütfen tüm alanları doldurunuz.");
                return;
            }

            //Şifrelerin birbirine eşit olup olmadığını kontrol eder
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                ShowError("Şifreler birbiri ile uyuşmamaktadır. Lütfen kontrol ediniz.");
                TxtConfirmPassword.Text = ""; //Uyum olmadığında şifreyi temizler
                return;
            }

            //Şifre formatını kontrol eder (örneğin en az 8 karakter)
            if (!_customerRepository.IsValidPassword(TxtPassword.Text))
            {
                ShowError("Geçersiz şifre formatı. Lütfen en az 8 karakterli şifre belirleyiniz.");
                return;
            }

            //E-posta adresine göre müşteri bilgilerini getirir
            _customer = _customerRepository.GetByEmail(TxtContactEMail.Text);

            //Eğer müşteri bulunamazsa hata mesajı göster
            if (_customer == null)
            {
                ShowError("Müşteri bulunamadı. Lütfen tekrar deneyiniz.");
                return;
            }

            //Yeni şifreyi şifreleyerek kaydeder.
            _customer.Password = PasswordEncryptor.Encode(TxtPassword.Text);

            //Kullanıcının şifresini günceller ve işlem sonucunda bilgilendirme mesajı gösterir.
            try
            {
                _customerRepository.UpdatePassword(TxtContactEMail.Text, TxtPassword.Text);
                ShowInfo("Şifre başarılı bir şekilde güncellenmiştir.");
                Close();
            }
            //Şifre güncelleme sırasında bir hata oluşursa, hata mesajını kullanıcıya bildirir.
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        //Şifre giriş alanlarını görünür veya gizli hale getirir
        private void KontrolleriGizle(bool visiable)
        {
            label1.Visible = visiable;
            label3.Visible = visiable;
            label4.Visible = visiable;
            TxtPassword.Visible = visiable;
            TxtConfirmPassword.Visible = visiable;
            BtnSave.Visible = visiable;
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
