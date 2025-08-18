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
    public partial class UpdateDeleteServiceForm : Form
    {
        //Repository'ler ve seçilen hizmet bilgilerini tutacak değişkenler
        ServiceDescriptorRepository _serviceDescriptorRepository;
        ServiceValueRepository _serviceValueRepository;
        ServiceProviderRepository _serviceProviderRepository;
        ServiceProviderServiceValueRepository _providerServiceValueRepository;

        //Seçilen sağlayıcı ve hizmet değeri nesneleri
        //Bu nesneler, kullanıcının seçim yaptığı sağlayıcı ve hizmet değerini tutar
        ServiceProvider _selectedProvider; //Seçilen hizmet sağlayıcısı
        ServiceValue _selectedServiceValue; //Seçilen hizmet değeri


        public UpdateDeleteServiceForm()
        {
            InitializeComponent();
            //Repository örneklerini başlat
            _serviceDescriptorRepository = new ServiceDescriptorRepository();
            _serviceValueRepository = new ServiceValueRepository();
            _serviceProviderRepository = new ServiceProviderRepository();
            _providerServiceValueRepository = new ServiceProviderServiceValueRepository();
            //Hizmetler listesine yükleme işlemini başlat
            InitializeListBox();

            //Mevcut hizmetleri yükle
            LoadExistingServices();
        }

        private void LstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstServices.SelectedIndex != -1) //Eğer listeden bir öğe seçilmişse
            {
                string selectedItem = LstServices.SelectedItem.ToString();

                //Öğe formatı : "Sağlayıcı Adı - Hizmet Adı - Maliyet"
                string[] parts = selectedItem.Split('-');
                if (parts.Length == 3)
                {
                    string providerName = parts[0].Trim();
                    string serviceName = parts[1].Trim();

                    //Sağlayıcı ve hizmeti veritabanından al
                    _selectedProvider = _serviceProviderRepository.GetByName(providerName);
                    _selectedServiceValue = _serviceValueRepository.GetByName(serviceName);

                    if (_selectedProvider != null && _selectedServiceValue != null) //Sağlayıcı ve hizmet verileri bulunduysa, detayları alanlara doldur.
                    {
                        //Sağlayıcı bilgilerini doldur
                        TxtProviderName.Text = _selectedProvider.ProviderName; //Sağlayıcı adını doldurur.
                        TxtProviderAddress.Text = _selectedProvider.Address; //Sağlayıcı adresini doldurur.
                        TxtProviderCity.Text = _selectedProvider.City; //Sağlayıcı şehir bilgisini doldurur.
                        TxtProviderDistrict.Text = _selectedProvider.District; //Sağlayıcı ilçe bilgisini doldurur
                        TxtProviderPhoneNumber.Text = _selectedProvider.PhoneNumber; //Sağlayıcı telefon numarasını doldurur
                        TxtProviderEmail.Text = _selectedProvider.Email; //Sağlayıcı e-posta bilgisini doldurur

                        //Hizmet bilgilerini doldur
                        TxtDescriptorName.Text = _selectedServiceValue.ServiceDescriptor?.Name ?? string.Empty; //Hizmet açıklamasının detaylarını doldurur (varsa)

                        TxtValueName.Text = _selectedServiceValue.Name; //Hizmet adını doldurur
                        NudCost.Value = _selectedServiceValue.Cost; //Hizmet maliyetini doldurur
                        NudPreparationTime.Value = _selectedServiceValue.PreparationTime; //Hazırlık süresini doldurur
                        NudBufferTime.Value = _selectedServiceValue.BufferTime; //Tampon süresini doldurur
                    }
                }
            }
            else
            {
                ClearFields(); //Seçim yapılmamışsa alanları temizle
            }
        }

        private void BtnUpdateService_Click(object sender, EventArgs e)
        {
            if (_selectedProvider == null || _selectedServiceValue == null) //Eğer herhangi bir hizmet seçilmemişse, kullanıcıya uyarı ver
            {
                MessageBox.Show("Lütfen bir hizmet seçin.");
                return;
            }

            try
            {
                //Seçilen hizmet değerini güncelle
                _selectedServiceValue.Name = TxtValueName.Text; //Hizmet adını günceller
                _selectedServiceValue.Cost = NudCost.Value; //Hizmet maliyetini günceller
                _selectedServiceValue.PreparationTime = (int)NudPreparationTime.Value; //Hazırlık süresini günceller
                _selectedServiceValue.BufferTime = (int)NudBufferTime.Value; //Tampon süresini günceller

                _serviceValueRepository.Update(_selectedServiceValue); //Güncellenen hizmet değerini veritabanına kaydeder

                //Seçilen sağlayıcıyı güncelle
                _selectedProvider.ProviderName = TxtProviderName.Text; //Sağlayıcı adını günceller
                _selectedProvider.Address = TxtProviderAddress.Text; //Sağlayıcı şehir bilgisini günceller
                _selectedProvider.City = TxtProviderCity.Text; //Sağlayıcı şehir bilgisini günceller
                _selectedProvider.District = TxtProviderDistrict.Text; //Sağlayıcı ilçe bilgisini günceller
                _selectedProvider.PhoneNumber = TxtProviderPhoneNumber.Text; //Sağlayıcı telefon numarasını günceller
                _selectedProvider.Email = TxtProviderEmail.Text; //Sağlayıcı e-posta bilgisini günceller
                
                _serviceProviderRepository.Update(_selectedProvider); //Güncellenen sağlayıcı bilgisini veritabanına kaydeder

                MessageBox.Show("Hizmet ve sağlayıcı bilgileri başarıyla güncellendi."); //Başarılı güncelleme mesajı

                //Listeyi yeniden yükle
                LoadExistingServices();

                //Alanları temizle
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu : {ex.Message}"); //Hata durumunda mesaj göster
            }
        }

        private void BtnDeleteService_Click(object sender, EventArgs e)
        {
            if (_selectedProvider == null || _selectedServiceValue == null) //Hizmet veya sağlayıcı seçilmediyse kullanıcıyı uyar
            {
                MessageBox.Show("Lütfen bir hizmet seçin.");
                return;
            }

            try
            {
                //Sağlayıcı ve hizmet değeri arasındaki ilişkiyi bul ve sil
                ServiceProviderServiceValue link = _providerServiceValueRepository.FirstOrDefault(psv => psv.ServiceProviderId == _selectedProvider.Id && psv.ServiceValueId == _selectedServiceValue.Id);

                //Eğer ilişki mevcutsa, bu ilişkili kaydı sil
                if (link != null)
                {
                    _providerServiceValueRepository.Delete(link); //İlgili link kaydını sil
                }

                //Hizmet değerini sil
                _serviceValueRepository.Delete(_selectedServiceValue);

                //Başarılı silme mesajı
                MessageBox.Show("Hizmet başarıyla silindi.");

                //Listeyi güncelle
                LoadExistingServices();

                //Alanları temizle
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme sırasında bir hata oluştu : {ex.Message}"); //Silme sırasında hata oluşursa mesaj göster
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapat
        }

        //Form Metotları
        //ListBox'ı başlatan metot
        private void InitializeListBox()
        {
            //ListBox öğelerini temizle
            LstServices.Items.Clear();
        }

        //Mevcut hizmetleri yükleyen metot
        private void LoadExistingServices()
        {
            try
            {
                //Sağlayıcı ve hizmet bilgilerini birleştirerek listeyi oluştur
                var providerServiceValues = _providerServiceValueRepository.GetAll()
                    .Select(psv => new
                    {
                        ProviderName = psv.ServiceProvider.ProviderName,
                        ServiceName = psv.ServiceValue.Name,
                        Cost = psv.ServiceValue.Cost
                    })
                    .ToList();

                //ListBox'ı temizle
                LstServices.Items.Clear();

                //ListBox'a her bir hizmeti ekle
                foreach (var service in providerServiceValues)
                {
                    //Hizmeti uygun formatta ekle (Sağlayıcı adı - Hizmet adı - Maliyet)
                    LstServices.Items.Add($"{service.ProviderName} - {service.ServiceName} - {service.Cost:C2}");
                }
                    
            }
            catch (Exception ex)
            {
                //Hata oluşursa, hata mesajını göster
                MessageBox.Show($"Hizmetler yüklenirken bir hata oluştu : {ex.Message}");
            }
        }

        //Alanları temizleyen metot
        private void ClearFields()
        {
            //Sağlayıcı bilgilerini içeren alanları temizle
            TxtProviderName.Clear(); //Sağlayıcı adını temizler
            TxtProviderAddress.Clear(); //Sağlayıcı adresini temizler
            TxtProviderCity.Clear(); //Sağlayıcı şehir bilgisini temizler
            TxtProviderDistrict.Clear(); //Sağlayıcı ilçe bilgisini temizler
            TxtProviderPhoneNumber.Clear(); //Sağlayıcı telefon numarasını temizler
            TxtProviderEmail.Clear(); //Sağlayıcı e-posta bilgisini temizler

            //Hizmet bilgilerini içeren alanları temizle
            TxtDescriptorName.Clear(); //Hizmet açıklama adını temizler
            TxtDescriptorDescription.Clear(); //Hizmet açıklamasını temizler
            TxtValueName.Clear(); //Hizmet değer adını temizler
            NudCost.Value = 0; //Maliyet sıfırlanır
            NudPreparationTime.Value = 0; //Hazırlık süresi sıfırlanır
            NudBufferTime.Value = 0; //Yedek süre sıfırlanır

            //Alanları düzenlenebilir hale getir
            TxtProviderName.ReadOnly = false; //Sağlayıcı adı alanını düzenlenebilir yapar
            TxtProviderAddress.ReadOnly = false; //Sağlayıcı adresi alanını düzenlenebilir yapar
            TxtProviderCity.ReadOnly = false; //Sağlayıcı şehir alanını düzenlenebilir yapar
            TxtProviderDistrict.ReadOnly = false; //Sağlayıcı ilçe alanını düzenlenebilir yapar
            TxtProviderPhoneNumber.ReadOnly = false; //Sağlayıcı telefon numarası alanını düzenlenebilir yapar
            TxtProviderEmail.ReadOnly = false; //Sağlayıcı e-posta alanını düzenlenebilir yapar
        }
    }
}
