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

namespace Project.WinFormUI.Forms.CustomerForms
{
    public partial class CustomerDashboard : Form
    {
        //Repository sınıfları
        BuildingRepository _buildingRepository; //Bina verilerini yöneten repository
        LocationRepository _locationRepository; //Konum verilerini yöneten repository
        FairRepository _fairRepository; //Fuar verilerini yöneten repository
        PaymentRepository _paymentRepository; //Ödeme verilerini yöneten repository
        public Customer LoggedInCustomer { get; set; } //Giriş yapan müşteri bilgisi
        public string FairName { get; set; } //Fuarın adı

        public CustomerDashboard()
        {
            InitializeComponent();

            //Repository nesneleri oluşturuluyor
            _buildingRepository = new BuildingRepository();
            _paymentRepository = new PaymentRepository();
            _fairRepository = new FairRepository();
            _locationRepository = new LocationRepository();

            //Şehirleri yükleme ve alanları temizleme işlemleri
            LoadCities();
            ClearFields();
        }

        //Fuar Oluştur Sekmesi
        private void BtnSearchBuildings_Click(object sender, EventArgs e)
        {
            //Eğer şehir, ilçe veya fuar ismi seçilmemişse, kullanıcıyı bilgilendiren bir mesaj göster
            if (CmbCity.SelectedIndex == -1 || CmbDistrict.SelectedIndex == -1 || TxtFairName.Text == "")
            {
                ShowInfo("Lütfen fuar ismini, şehiri ve ilçeyi seçiniz.");
                return;
            }

            //Eğer seçilen tarih aralığı geçerli değilse, hata mesajını göster ve işlemi durdur
            if (!_buildingRepository.IsValidDateRange(DtpStartDate.Value, DtpEndDate.Value, out string errorMessage))
            {
                ShowError(errorMessage);
                return;
            }

            //Seçilen şehir, ilçe ve tarih aralığına göre uygun binaları arama işlemi
            List<Building> availableBuildings = _buildingRepository.SearchBuildings(
                CmbCity.SelectedItem.ToString(),
                CmbDistrict.SelectedItem.ToString(),
                DtpStartDate.Value,
                DtpEndDate.Value
            );

            //Eğer uygun binalar bulunduysa, bunları listele
            if (availableBuildings.Any())
            {
                LstBuildings.DataSource = availableBuildings;
                LstBuildings.DisplayMember = "ToString";
                LstBuildings.SelectedIndex = -1;
            }
            else
            {
                //Eğer uygun bina bulunmazsa, kullanıcıyı bilgilendir
                ShowError("Seçilen tarihlerde uygun bina bulunamadı. İsterseniz talep oluşturabilirsiniz.");
            }
        }

        private void BtnConfirmFair_Click(object sender, EventArgs e)
        {
            //Liste kutusundan bir bina seçilip seçilmediğini kontrol et.
            if (LstBuildings.SelectedItem == null)
            {
                ShowInfo("Lütfen bir bina seçiniz."); //Kullanıcıya bina seçilmediğini bildir.
                return; //Metottan erken çıkış yap.
            }

            //Seçili öğeyi Building(Bina) nesnesine dönüştür.
            Building selectedBuilding = LstBuildings.SelectedItem as Building;

            try
            {
                //Seçilen bina ve tarih aralığına göre fuar maliyetini hesapla.
                decimal buildingCost = _buildingRepository.CalculateFairCost(selectedBuilding, DtpStartDate.Value, DtpEndDate.Value);

                //FairServicesForm'u başlat ve gerekli verileri ayarla.
                FairServicesForm servicesForm = new FairServicesForm
                {
                    LoggedInCustomer = LoggedInCustomer, //Giriş yapmış müşteri bilgilerini ata.
                    SelectedBuilding = selectedBuilding, //Seçilen binayı ayarla.
                    BuildingCost = buildingCost, //Hesaplanan maliyeti ata.
                    StartDate = DtpStartDate.Value, //Talep edilen başlangıç tarihini ayarla.
                    EndDate = DtpEndDate.Value, //Kullanıcı tarafından belirtilen bitiş tarihini ayarla.
                    FairName = TxtFairName.Text, //Fuar adını ata.
                };

                servicesForm.ShowDialog(); //FairServicesForm'u bir diyalog olarak aç.
            }
            catch (Exception ex)
            {
                //İşlem sırasında bir hata oluşursa kullanıcıya hata mesajı göster.
                ShowError($"Bir hata oluştu : {ex.Message}");
            }
        }

        private void BtnRequestBuilding_Click(object sender, EventArgs e)
        {
            //Tarih aralığının geçerli olup olmadığını kontrol et.
            if (!_buildingRepository.IsValidDateRange(DtpStartDate.Value, DtpEndDate.Value, out string errorMessage))
            {
                ShowError(errorMessage);
                return;
            }

            //Fuar adının girilip girilmediğini kontrol et.
            if (TxtFairName.Text == "")
            {
                ShowInfo("Lütfen fuar ismini giriniz."); //Kullanıcıya uyarı göster.
                return; //Metottan erken çıkış yap.
            }

            //Kullanıcının bina talebi için özel bir form oluştur ve başlat.
            CustomBuildingRequestForm requestForm = new CustomBuildingRequestForm(TxtFairName.Text, DtpStartDate.Value, DtpEndDate.Value, LoggedInCustomer);
            requestForm.ShowDialog(); //Formu diyalog olarak aç.
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Şehir seçilmişse işlemleri başlat.
            if (CmbCity.SelectedItem != null)
            {
                //Seçilen şehre ait ilçeleri repository'den al.
                List<string> districts = _locationRepository.GetDistrictsByCity(CmbCity.SelectedItem.ToString());

                //Eğer ilçeler mevcutsa ComboBox'a bağla.
                if (districts.Any())
                {
                    CmbDistrict.DataSource = districts;
                }
                else
                {
                    //Eğer ilçeler yoksa ComboBox'ı temizle ve kullanıcıya bilgi ver.
                    CmbDistrict.DataSource = null;
                    ShowInfo("Seçilen şehir için ilçe bulunamadı.");
                }
            }
        }

        private void LstBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen öğe bir bina mı kontrol et.
            if (LstBuildings.SelectedItem is Building selectedBuilding)
            {
                //Seçilen binanın detaylarını etiket üzerinde göster.
                LblBuildingDetails.Text = $"Bina Adı : {selectedBuilding.Name}\nAdred : {selectedBuilding.Address}\nKat Sayısı : {selectedBuilding.NumberOfFloor}\nKat Metrekare : {selectedBuilding.FloorSize}\nKat Başına Oda : {selectedBuilding.RoomsPerFloor}\nGün Sayısı : {(DtpEndDate.Value - DtpStartDate.Value).Days + 1}";

            }
            else
            {
                //Eğer bina seçilmediyse bir uyarı mesajı göster.
                LblBuildingDetails.Text = "Bina seçilmedi.";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Formu kapatır
            Close();
        }

        //Fuarlarım Sekmesi
        //TabControl üzerinde sekme değiştirildiğinde çalışacak olay yöntemi.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eğer seçili sekme fuarlar sekmesi (tabPage2) ise fuarları yükle.
            if (tabControl1.SelectedTab == tabPage2)
            {
                LoadFairs(); //Fuarları yükleme işlemi. 
            }
        }

        private void BtnCancelFair_Click(object sender, EventArgs e)
        {
            //Eğer DataGridView'de seçili satır yoksa kullanıcıyı uyar.
            if (DgvFairs.SelectedRows.Count == 0)
            {
                ShowInfo("Lütfen iptal etmek istediğiniz fuarı seçiniz.");
                return; //Metottan erken çıkış yap.
            }

            //Seçili satırdan fuar ID'sini al.
            int selectedFairId = (int)DgvFairs.SelectedRows[0].Cells["Id"].Value;
            Fair fair = _fairRepository.GetById(selectedFairId); //ID'ye göre fuarı getir.

            //Eğer fuar bulunamazsa hata mesajı göster.
            if (fair == null)
            {
                ShowError("Seçilen fuar bulunamadı.");
                return;
            }

            //Eğer fuar zaten iptal edilmişse kullanıcıya bilgi ver.
            if (fair.Status == ENTITIES.Enums.DataStatus.Deleted)
            {
                ShowInfo("Bu fuar zaten iptal edilmiş.");
                return;
            }

            //Ödeme işlemleri kontrolü.
            Payment payment = _paymentRepository.FirstOrDefault(p => p.FairId == fair.Id);
            if (payment != null)
            {
                payment.RefundStatus = ENTITIES.Enums.RefundStatus.Refunded; //İade durumu tamamlandı olarak güncelle.
                _paymentRepository.Update(payment); //Ödemeyi güncelle.
            }

            //Fuarın durumunu iptal edilmiş olarak güncelle.
            _fairRepository.Delete(fair); //Fuarı silme işlemi.

            //Güncellenen fuarı tekrar getir ve kullanıcıya bilgi göster.
            Fair updatedFair = _fairRepository.GetById(selectedFairId);
            ShowInfo($"Fuar adı : {updatedFair.Name}, Durumu : {updatedFair.Status}");

            //İptal işleminin başarılı olduğunu ve ödemenin iade edildiğini bildir.
            ShowInfo("Fuar başarıyla iptal edildi ve ödeme iadesi gerçekleştirildi.");

            //DataGridView'i güncellemek için fuarları yeniden yükle.
            LoadFairs();
        }

        private void BtnViewFairDetails_Click(object sender, EventArgs e)
        {
            //Eğer DataGridView'de seçili satır yoksa kullanıcıyı uyar.
            if (DgvFairs.SelectedRows.Count == 0)
            {
                ShowInfo("Lütfen görüntülemek istediğiniz fuarı seçiniz.");
                return; //Metottan erken çıkış yap.
            }

            //Seçili fuarın ID'sini al.
            int selectedFairId = (int)DgvFairs.SelectedRows[0].Cells["Id"].Value;
            Fair fair = _fairRepository.GetById(selectedFairId); //ID'ye göre fuarı getir.

            //Eğer fuar bulunamazsa hata mesajı göster.
            if (fair == null)
            {
                ShowError("Seçilen fuar bulunamadı.");
                return; //Metottan erken çıkış yap.
            }

            //Fuar detaylarını etiket üzerinde göster.
            LblBuildingDetails.Text = $"Fuar Adı : {fair.Name}\nBaşlangıç Tarihi : {fair.CalculatedStartDate:dd/MM/yyyy}\nBitiş Tarihi : {fair.EndDate:dd/MM/yyyy}\nToplam Maliyet : {fair.TotalCost:C2}\nDurum : {(fair.Status == ENTITIES.Enums.DataStatus.Deleted ? "İptal Edildi" : "Aktif")}";
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapatır.
        }


        //Form Metotları

        //Kullanıcıya bir hata mesajı göstermek için kullanılan yardımcı metot.
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Kullanıcıya bilgilendirme mesajı göstermek için kullanılan yardımcı metot.
        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadCities()
        {
            //Repository'den tüm şehirleri al.
            List<string> cities = _locationRepository.GetAllCities();

            //Eğer şehirler mevcutsa ComboBox'a bağla.
            if (cities.Any())
            {
                CmbCity.DataSource = cities;
            }
            else
            {
                //Eğer şehirler yoksa ComboBox'ı temizle ve hata mesajı göster.
                CmbCity.DataSource = null;
                ShowError("Şehir verileri yüklenemedi.");
            }
        }

        //Formdaki giriş alanlarını temizler.
        private void ClearFields()
        {
            //Fuar adını temizle.
            TxtFairName.Clear();
            //Şehir seçimini sıfırla.
            CmbCity.SelectedIndex = -1;
            //İlçe ComboBox'ını temizle.
            CmbDistrict.DataSource = null;
            //Tarih seçimlerini bugüne ayarla.
            DtpEndDate.Value = DateTime.Now;
            DtpStartDate.Value = DateTime.Now;
            //Bina listesini temizle.
            LstBuildings.DataSource = null;
        }

        //Müşteriye ait fuarları yükleyip listeleyen yöntem.
        private void LoadFairs()
        {
            try
            {
                //DataGridView içeriğini temizle.
                DgvFairs.DataSource = null;

                //Giriş yapan müşteriye ait fuarları getir ve seçili özelliklerle bir liste oluştur.
                var customerFairs = _fairRepository
                    .GetFairsByCustomer(LoggedInCustomer.Id) //Tüm fuarları al
                    .Select(f => new
                    {
                        f.Id, //Fuar kimliği
                        FuarAdı = f.Name, //Fuar adı
                        BaşlangıçTarihi = f.CalculatedStartDate.ToShortDateString(), //Başlangıç tarihi
                        BitişTarihi = f.EndDate.ToShortDateString(), //Bitiş tarihi
                        ToplamMaliyet = f.TotalCost.ToString("C"), //Toplam maliyet
                        Durum = f.Status == ENTITIES.Enums.DataStatus.Deleted ? "İptal Edildi" : "Aktif" //Fuar durumu
                    })
                    .ToList();

                //Veriyi DataGridView'e bağla ve görünümü yenile.
                DgvFairs.DataSource = customerFairs;
                DgvFairs.Refresh();
            }
            catch (Exception ex)
            {

                //Fuarlar yüklenirken bir hata oluşursa kullanıcıya mesaj göster.
                ShowError($"Fuarlar yüklenirken bir hata oluştu : {ex.Message}");
            }
        }
    }
}
