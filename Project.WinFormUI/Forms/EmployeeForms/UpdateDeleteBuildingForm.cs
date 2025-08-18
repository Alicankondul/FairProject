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
    public partial class UpdateDeleteBuildingForm : Form
    {
        //BuildingRepository ve LocationRepository nesneleri tanımlanıyor
        private BuildingRepository _buildingRepository;
        private LocationRepository _locationRepository;

        private Building _selectedBuilding; //Seçilen bina nesnesi için bir değişken tanımlanıyor.

        public UpdateDeleteBuildingForm() //Formun yapıcı metodu
        {
            InitializeComponent(); //Formun bileşenlerini başlat

            //Repository örneklerini oluştur
            _buildingRepository = new BuildingRepository();
            _locationRepository = new LocationRepository();
            LoadLocationsAndBuildings(); //Lokasyon ve bina verilerini yükle
            ClearFields(); //Form alanlarını temizle
        }

        private void LoadLocationsAndBuildings()
        {
            //Lokasyonları yükleme işlemi
            var locationDisplayData = _locationRepository.GetAll().Select(x => new
            {
                //Lokasyonun görüntülenecek bilgisi ve ID'si için anonim bir tip oluşturuluyor.
                Display = x.ToString(),
                Value = x.Id
            }).ToList();

            //Lokasyon verilerini ComboBox'a bağla
            CmbLocation.DataSource = locationDisplayData; //Veriler ComboBox'ıb veri kaynağına atanıyor
            CmbLocation.DisplayMember = "Display"; //Görüntülenecek olan özellik
            CmbLocation.ValueMember = "Value"; //Seçildiğinde alınacak olan değer

            //Aktif binaları listeleme işlemi
            LstBuildings.DataSource = _buildingRepository.GetActives(); //Sadece aktif binalar alınır ve listeye bağlanır.
            LstBuildings.DisplayMember = "ToString"; //Liste elemanlarının nasıl görüneceği belirtiliyor.
        }

        private void LstBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBuildings.SelectedItem != null) //Eğer listeden bir bina seçilmişse
            {
                _selectedBuilding = (Building)LstBuildings.SelectedItem; //Seçilen öğe, Building tipine dönüştürülür.

                //Seçilen binanın detaylarını ilgili alanlara yansıt
                TxtBuildingName.Text = _selectedBuilding.Name; //Bina adını TextBox'a yaz.
                TxtAddress.Text = _selectedBuilding.Address; //Adresi TextBox'a yaz.
                NudNumberOfFloor.Value = _selectedBuilding.NumberOfFloor; //Kat sayısını NumericUpDown'a yaz.
                NudFloorSize.Value = _selectedBuilding.FloorSize; //Kat metrekare bilgisini NumericUpDown'a yaz.
                NudRoomPerFloor.Value = _selectedBuilding.RoomsPerFloor; //Kat başına oda sayısını NumericUpDown'a yaz.
                CmbLocation.SelectedValue = _selectedBuilding.LocationId; //Lokasyon seçimini ComboBox'ta yap.

                //Seçilen binanın detaylarını bir Label'e yazdır.
                LblSelectedBuilding.Text = $"Bina Adı : {_selectedBuilding.Name}\n" +
                                           $"Adres : {_selectedBuilding.Address}\n " +
                                           $"Kat Sayısı : {_selectedBuilding.NumberOfFloor}\n" +
                                           $"Kat Metrekare : {_selectedBuilding.FloorSize}\n" +
                                           $"Kat Başına Oda : {_selectedBuilding.RoomsPerFloor}\n" +
                                           $"Lokasyon : {_selectedBuilding.Location?.ToString()}"; //Eğer lokasyon varsa yazdır, yoksa boş bırak.
            }
            else
            {
                //Eğer herhangi bir bina seçilmişse, kullanıcıyı bilgilendir.
                LblSelectedBuilding.Text = "Seçilen Bina : Yok";
            }
        }

        private void BtnUpdateBuilding_Click(object sender, EventArgs e)
        {
            //Eğer seçilen bina yoksa, kullanıcıyı bilgilendir
            if (_selectedBuilding == null)
            {
                MessageBox.Show("Lütfen bir bina seçiniz.");
                return; //Fonksiyonu sonlandır.
            }

            //Güncelleme işlemi için geçerlilik kontrolleri yapılıyor
            if (!_buildingRepository.IsFloorCountValid((int)NudNumberOfFloor.Value) || !_buildingRepository.IsFloorSizeValid((int)NudFloorSize.Value) || !_buildingRepository.IsRoomCountValid((int)NudRoomPerFloor.Value))
            {
                //Eğer herhangi bir değer geçersizse, kullanıcıyı bilgilendir
                MessageBox.Show("Girilen değerler uygun değil.");
                return; //Fonksiyonu sonlandır
            }

            try
            {
                //Seçilen binanın özelliklerini formdaki verilere göre güncelle
                _selectedBuilding.Name = TxtBuildingName.Text; //Bina adı
                _selectedBuilding.Address = TxtAddress.Text; //Adres
                _selectedBuilding.NumberOfFloor = (int)NudNumberOfFloor.Value; //Kat sayısı
                _selectedBuilding.FloorSize = (int)NudFloorSize.Value; //Kat büyüklüğü
                _selectedBuilding.RoomsPerFloor = (int)NudRoomPerFloor.Value; //Kat başına oda sayısı
                _selectedBuilding.LocationId = (int)CmbLocation.SelectedValue; //Lokasyon ID

                //Bina bilgilerini repository aracılığıyla güncelle
                _buildingRepository.Update(_selectedBuilding);

                //Güncelleme başarılı olduğunda kullanıcıyı bilgilendir
                MessageBox.Show("Bina başarıyla güncellendi.");
                LoadLocationsAndBuildings(); //Güncellenmiş listeyi yükle
                ClearFields(); //Form alanlarını temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}"); //Hata oluşursa, kullanıcıya hata mesajı göster.
            }
        }

        private void BtnDeleteBuilding_Click(object sender, EventArgs e)
        {
            //Eğer seçilen bina yoksa, kullanıcıya bilgilendir
            if (_selectedBuilding == null)
            {
                MessageBox.Show("Lütfen bir bina seçiniz.");
                return; //Fonksiyonu sonlandır
            }

            try
            {
                //Seçilen bina silinir
                _buildingRepository.Delete(_selectedBuilding);

                //Silme işlemi başarılı ise kullanıcıyı bilgilendir
                MessageBox.Show("Bina başarıyla silindi.");

                //Listeyi güncelle
                LoadLocationsAndBuildings();

                //Form alanlarını temizle
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}"); //Hata oluşursa, kullanıcıya hata mesajı göster.
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapatır
        }

        //Form Metotları
        private void ClearFields()
        {
            //TextBox'ları temizle
            TxtBuildingName.Clear();
            TxtAddress.Clear();

            //NumericUpDown değerlerini sıfırla
            NudNumberOfFloor.Value = 1;
            NudFloorSize.Value = 50;
            NudRoomPerFloor.Value = 1;

            CmbLocation.SelectedIndex = -1; //ComboBox'ı sıfırla

            //Seçilen bina bilgisini sıfırla
            LblSelectedBuilding.Text = "Seçilen Bina : Yok";
            _selectedBuilding = null;
            LstBuildings.SelectedIndex = -1; //Listeyi sıfırla
        }
    }
}
