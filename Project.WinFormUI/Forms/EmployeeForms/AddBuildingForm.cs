using Project.BLL.DesignPatterns.GenericRepository.EFConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinFormUI.Forms.EmployeeForms
{
    public partial class AddBuildingForm : Form
    {
        //Bina ve lokasyon işlemleri için repository'ler tanımlanır.
        BuildingRepository _buildingRepository;
        LocationRepository _locationRepository;

        //Yeni bir nesnesini tutar
        Building _newBuilding;

        //Constructor : Formun başlatılması ve gerekli repository'lerin oluşturulması.
        public AddBuildingForm()
        {
            InitializeComponent();

            _buildingRepository = new BuildingRepository(); //Bina repository'si oluşturulur.
            _locationRepository = new LocationRepository(); //Lokasyon repository'si oluşturulur.

            LoadLocationsAndBuildings(); //Lokasyon ve binaları yükler
            ClearFields(); //Formdaki alanları temizler
        }

        //"Bina Ekle"  butonuna tıklandığında çağrılır.
        private void BtnAddBuilding_Click(object sender, EventArgs e)
        {
            //Alanların knotrolü yapılır, eksik bilgi varsa uyarı gösterilir
            if (AlanlariKontrolEt())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }

            //Bina adının benzersiz olup olmadığı kontrol edilir.
            if (!_buildingRepository.IsBuildingUnique(TxtBuildingName.Text))
            {
                MessageBox.Show("Bu bina adı zaten mevcut. Lütfen farklı bir isim giriniz.");
                return;
            }

            //Kat sayısının geçerli aralıkta olup olmadığı kontrol edilir.
            if (!_buildingRepository.IsFloorCountValid((int)NudNumberOfFloor.Value))
            {
                MessageBox.Show("Kat sayısı 1 ile 5 arasında olmalıdır.");
                return;
            }

            //Kat boyutunun geçerli aralıkta olup olmadığı kontrol edilir.
            if (!_buildingRepository.IsFloorSizeValid((int)NudFloorSize.Value))
            {
                MessageBox.Show("Kat boyutu 50 ile 300 metrekare arasında olmalıdır.");
                return;
            }

            //Oda sayısının geçerli aralıkta olup olmadığı kontrol edilir.
            if (!_buildingRepository.IsRoomCountValid((int)NudRoomPerFloor.Value))
            {
                MessageBox.Show("Kat başına oda sayısı 1 ile 6 arasında olmalıdır.");
                return;
            }

            try
            {
                //Yeni bina nesnesi oluşturulur ve formdaki bilgiler atanır.
                _newBuilding = new Building
                {
                    Name = TxtBuildingName.Text,
                    Address = TxtAddress.Text,
                    NumberOfFloor = (int)NudNumberOfFloor.Value, //NumericUpDown değeri int'e çevrilir.
                    FloorSize = (int)NudFloorSize.Value,
                    RoomsPerFloor = (int)NudRoomPerFloor.Value,
                    LocationId = (int)CmbLocation.SelectedValue //Seçilen lokasyonun ID'si
                };

                //Yeni bina repository aracılığıyla veritabanına eklenir.
                _buildingRepository.Add(_newBuilding);

                //Başarı mesajı gösterilir.
                MessageBox.Show("Bina başarıyla eklendi!");
                ClearFields(); //Alanları temizle.
                LoadLocationsAndBuildings(); //Bina ve Lokasyon listesini güncelle.
            }
            catch (Exception ex)
            {
                //Hata mesajı gösterilir.
                MessageBox.Show($"Bir hata oluştu : {ex.Message}");
            }
        }

        //"Kapat" butonuna tıklandığında form kapanır
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapatır
        }

        //Form Metotları
        //Formdaki tüm alanları temizler ve varsayılan değerlere ayarlar
        private void ClearFields()
        {
            TxtBuildingName.Clear();
            TxtAddress.Clear();
            NudNumberOfFloor.Value = 1; //Varsayılan değer olarak 1 atanır.
            NudFloorSize.Value = 50;
            NudRoomPerFloor.Value = 1;
            CmbLocation.SelectedIndex = -1; //ComboBox seçimini kaldır.
        }

        //Lokasyon ve bina bilgilerini yükler
        private void LoadLocationsAndBuildings()
        {
            //Lokasyon verileri formatlanır ve ComboBox'a yüklenir.
            var locationDisplayData = _locationRepository.GetAll().Select(x => new
            {
                Display = x.ToString(), //Lokasyonun formatlanmış hali (örn: İlçe/Şehir)
                Value = x.Id //Lokasyon ID'si
            }).ToList();

            CmbLocation.DataSource = locationDisplayData; //ComboBox'a veri atanır
            CmbLocation.DisplayMember = "Display"; //Görüntülenecek alan
            CmbLocation.ValueMember = "Value"; //Seçilecek alanın değeri (ID)

            //Aktif binalar ListBox'a yüklenir.
            LstBuildings.DataSource = _buildingRepository.GetActives(); //Silinmemiş binaları getirir.
            LstBuildings.DisplayMember = "ToString"; //Bina bilgilerini göstermek için ToString kullanılır.
        }

        //Formdaki tüm alanların dolu olup olmadığını kontrol eder.
        private bool AlanlariKontrolEt()
        {
            return TxtBuildingName.Text == "" ||
                   TxtAddress.Text == "" ||
                   NudNumberOfFloor.Value <= 0 ||
                   NudFloorSize.Value <= 0 ||
                   NudRoomPerFloor.Value <= 0 ||
                   CmbLocation.SelectedIndex == -1;
        }
    }
}
