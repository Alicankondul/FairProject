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
    public partial class UpdateDeleteLocationForm : Form
    {
        //Lokasyon repository ve seçilen lokasyon değişkenlerini tanımlama
        LocationRepository _locationRepository;
        Location _selectedLocation;

        public UpdateDeleteLocationForm()
        {
            InitializeComponent();
            _locationRepository = new LocationRepository(); //Lokasyon repository örneğini başlat.
            LoadLocations(); //Lokasyonları yükle
        }

        private void LstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstLocations.SelectedItem != null)
            {
                //Seçilen lokasyonu al ve detayları form elemanlarına doldur
                _selectedLocation = (Location)LstLocations.SelectedItem;
                //Seçilen lokasyon bilgilerini metin kutularına yerleştir.
                TxtCity.Text = _selectedLocation.City;
                TxtDistrict.Text = _selectedLocation.District;

                //Seçilen lokasyon bilgisini Label'de göster.
                LblSelectedLocation.Text = $"Seçilen Çalışan : {_selectedLocation.District}, {_selectedLocation.City}";
            }
            else
            {
                ClearFields(); //Eğer bir seçim yapılmazsa, form alanlarını temizle
            }
        }

        private void BtnUpdateLocation_Click(object sender, EventArgs e)
        {
            if (_selectedLocation == null) //Eğer hiçbir lokasyon seçilmemişse, kullanıcıya uyarı ver.
            {
                MessageBox.Show("Lütfen bir lokasyon seçiniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCity.Text) || string.IsNullOrWhiteSpace(TxtDistrict.Text)) //Şehir ve ilçe bilgileri boş olamaz, kontrol et
            {
                MessageBox.Show("Şehir ve ilçe bilgilerini doldurunuz.");
                return;
            }

            try
            {
                //Seçilen lokasyonun bilgilerini güncelle
                _selectedLocation.City = TxtCity.Text;
                _selectedLocation.District = TxtDistrict.Text;

                //Repository ile güncelleme işlemi yap
                _locationRepository.Update(_selectedLocation);

                //Başarılı güncelleme mesajı ver
                MessageBox.Show("Lokasyon başarıyla güncellendi.");

                //Listeyi güncelle
                LoadLocations();

                //Alanları temizle
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}"); //Hata durumunda mesaj göster.
            }
        }

        private void BtnDeleteLocation_Click(object sender, EventArgs e)
        {
            //Eğer hiçbir lokasyon seçilmemişse, kullanıcıya uyarı ver.
            if (_selectedLocation == null)
            {
                MessageBox.Show("Lütfen bir lokasyon seçiniz.");
                return;
            }

            try
            {
                //Seçilen lokasyonu sil
                _locationRepository.Delete(_selectedLocation);

                //Başarılı silme mesajı ver
                MessageBox.Show("Lokasyon başarıyla silindi.");

                //Listeyi güncelle
                LoadLocations();

                //Alanları temizle
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}"); //Hata durumunda mesaj göster.
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapat
        }

        //Form Metotları
        //Formdaki alanları temizleme işlemi
        private void ClearFields()
        {
            //TextBox'ları temizle
            TxtCity.Clear();
            TxtDistrict.Clear();

            //Seçilen lokasyon bilgisini sıfırla
            LblSelectedLocation.Text = "Seçilen Lokasyon : Yok";
            _selectedLocation = null;
        }

        private void LoadLocations()
        {
            //Aktif lokasyonları al ve listeye ekle
            LstLocations.DataSource = _locationRepository.GetActives();
            LstLocations.DisplayMember = "ToString"; //Lokasyonun görsel gösterimini ayarla.
        }
    }
}
