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
    public partial class AddAdditionalServiceForm : Form
    {
        //Repository'ler (Veritabanı işlemleri için kullanılan sınıflar)
        ServiceDescriptorRepository _serviceDescriptorRepository;
        ServiceValueRepository _serviceValueRepository;
        ServiceProviderRepository _serviceProviderRepository;
        ServiceProviderServiceValueRepository _providerServiceValueRepository;

        //Formun yapıcı metodu
        public AddAdditionalServiceForm()
        {
            InitializeComponent(); //Formun bileşenlerini başlatır.

            //Repository örneklerini oluşturur (Veritabanı işlemleri için sınıfların örnekleri)
            _serviceDescriptorRepository = new ServiceDescriptorRepository();
            _serviceValueRepository = new ServiceValueRepository();
            _serviceProviderRepository = new ServiceProviderRepository();
            _providerServiceValueRepository = new ServiceProviderServiceValueRepository();

            InitializeListView(); //ListView kontrolünü başlatır ve yapılandırır.
            LoadExistingProviders(); //Mevcut sağlayıcıları yükler ve kullanıcıya seçim için sunar.
            LoadExistingServices(); //Mevcut hizmetleri yükler ve listeye ekler.
            SetInitialControlState(); //Kontrollerin başlangıç durumunu ayarlar (örneğin, hangi alanların aktif/pasif olduğu).
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            //Alan doğrulaması yapar; eğer alanlar geçerli değilse işlemi sonlandırır.
            if (!ValidateFields()) return;

            try
            {
                //Girilen hizmet tanımlayıcı adına göre var olan bir tanımlayıcıyı veritabanından getirir.
                ServiceDescriptor descriptor = _serviceDescriptorRepository.GetByName(TxtDescriptorName.Text);
                if (descriptor == null) //Eğer böyle bir tanımlayıcı yoksa, yeni bir tanımlayıcı oluşturup veritabanına ekler.
                {
                    descriptor = new ServiceDescriptor
                    {
                        Name = TxtDescriptorName.Text, //Kullanıcının girdiği tanımlayıcı adı
                        Description = TxtDescriptorDescription.Text //Kullanıcının girdiği açıklama
                    };
                    _serviceDescriptorRepository.Add(descriptor); //Yeni tanımlayıcıyı veritabanına ekler.
                }
                //Yeni bir hizmet değeri nesnesi oluşturur ve ilgili alanları doldurur.
                ServiceValue value = new ServiceValue
                {
                    Name = TxtValueName.Text, //Kullanıcının girdiği hizmet değeri adı
                    Cost = NudCost.Value, //Hizmet maliyeti
                    PreparationTime = (int)NudPreparationTime.Value, //Hazırlık süresi
                    BufferTime = (int)NudBufferTime.Value, //Ek süre (tampon süre)
                    ServiceDescriptorId = descriptor.Id, //Tanımlayıcı kimliği ile ilişkilendirir
                };
                //Yeni hizmet değerini veritabanına ekler.
                _serviceValueRepository.Add(value);

                //Eğer "Yeni Sağlayıcı" seçeneği işaretlenmemişse ve mevcut sağlayıcılar listesinden bir seçim yapılmışsa işlemi gerçekleşir.
                if (!ChkNewProvider.Checked && CmbExistingProviders.SelectedIndex != -1)
                {
                    //Seçilen sağlayıcının kimliğini alır.
                    int selectedProviderId = (int)CmbExistingProviders.SelectedValue;

                    //Seçilen sağlayıcıyı veritabanından getirir.
                    ServiceProvider provider = _serviceProviderRepository.GetById(selectedProviderId);

                    //Eğer sağlayıcı veritabanında mevcutsa işleme devam eder.
                    if (provider != null)
                    {
                        //Hizmet ile sağlayıcı arasında bir ilişki olup olmadığını kontrol eder.
                        if (!_providerServiceValueRepository.IsServiceValueLinkedToProvider(provider.Id, value.Id))
                        {
                            //Eğer ilişki yoksa, yeni bir sağlayıcı-hizmet ilişkisi oluşturur ve veritabanına ekler.
                            ServiceProviderServiceValue providerServiceValue = new ServiceProviderServiceValue
                            {
                                ServiceProviderId = provider.Id, //Sağlayıcı kimliği
                                ServiceValueId = value.Id, //Hizmet değeri kimliği
                            };
                            _providerServiceValueRepository.Add(providerServiceValue); //İlişkiyi veritabanına ekler.
                        }
                        else
                        {
                            //Eğer ilişki zaten mevcutsa kullanıcıya bilgi verir.
                            MessageBox.Show("Bu hizmet zaten bu sağlayıcıya atanmış.");
                        }
                    }
                }
                else
                {
                    //Yeni bir hizmet sağlayıcı nesnesi oluşturur ve kullanıcıdan alınan bilgileri doldurur.
                    ServiceProvider provider = new ServiceProvider
                    {
                        ProviderName = TxtProviderName.Text, //Sağlayıcı adı
                        Address = TxtProviderAddress.Text, //Adres bilgisi
                        City = TxtProviderCity.Text, //Şehir
                        District = TxtProviderDistrict.Text, //İlçe
                        PhoneNumber = TxtProviderPhoneNumber.Text, //Telefon numarası
                        Email = TxtProviderEmail.Text //E-posta adresi
                    };

                    _serviceProviderRepository.Add(provider); //Yeni sağlayıcıyı veritabanına ekler.

                    //Sağlayıcı ile hizmet değeri arasında bir ilişki oluşturur.
                    ServiceProviderServiceValue providerServiceValue = new ServiceProviderServiceValue
                    {
                        ServiceProviderId = provider.Id, //Sağlayıcı kimliği
                        ServiceValueId = value.Id //Hizmet değeri kimliği
                    };

                    _providerServiceValueRepository.Add(providerServiceValue); //İlişkiyi veritabanına ekler.
                    LoadExistingProviders(); //Mevcut sağlayıcılar listesini yeniler.
                }

                MessageBox.Show("Hizmet başarıyla eklendi!"); //Kullanıcıya başarılı bir işlem mesajı gösterir.
                LoadExistingServices(); //Mevcut hizmetler listesini yeniler.
                ClearFields(); //Tüm alanları temizleyerek formu varsayılan duruma getirir.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}"); //Bir hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void ChkNewProvider_CheckedChanged(object sender, EventArgs e)
        {
            //Eğer "Yeni Sağlayıcı" seçeneği işaretlenmişse
            if (ChkNewProvider.Checked)
            {
                ClearFields(); //Tüm alanları temizler.
                SetControlsEnabled(true); //Kontrolleri kullanıcı girişine açar.
                CmbExistingProviders.Enabled = false; //Mevcut sağlayıcılar listesini devre dışı bırakır.
                CmbExistingProviders.SelectedIndex = -1; //Mevcut sağlayıcılar listesindeki seçimi kaldırır.
            }
            else
            {
                ClearFields(); //Tüm alanları temizler.
                SetControlsEnabled(false); //Kontrolleri kullanıcı girişine kapatır.
                CmbExistingProviders.Enabled =true; //Mevcut sağlayıcılar listesini etkinleştirir.
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close(); //Formu kapat
        }

        private void AddAdditionalServiceForm_Load(object sender, EventArgs e)
        {
            LoadExistingProviders(); //Mevcut sağlayıcıları yükler.
            LoadExistingServices(); //Mevcut hizmetleri yükler.
        }

        private void CmbExistingProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eğer "Yeni Sağlayıcı" seçeneği işaretlenmişse
            if (ChkNewProvider.Checked)
            {
                ClearFields(); //Tüm alanları temizler.
                SetControlsEnabled(true); //Kontrolleri kullanıcı girişine açar.

                //Mevcut sağlayıcılar listesini devre dışı bırakır ve seçim yapmayı engeller.
                CmbExistingProviders.Enabled = false;
                CmbExistingProviders.SelectedIndex = -1;
            }
            else
            {
                //Mevcut sağlayıcılar listesini etkinleştirir.
                CmbExistingProviders.Enabled = true;

                //Mevcut sağlayıcılar listesinden geçerli bir seçim yapılıp yapılmadığını kontrol eder.
                if (CmbExistingProviders.SelectedValue != null && int.TryParse(CmbExistingProviders.SelectedValue.ToString(), out int selectedProviderId))
                {
                    //Seçilen sağlayıcıyı veritabanından getirir.
                    ServiceProvider provider = _serviceProviderRepository.GetById(selectedProviderId);

                    if (provider != null)
                    {
                        //Sağlayıcı bilgilerini ilgili alanlara doldurur.
                        TxtProviderName.Text = provider.ProviderName; 
                        TxtProviderAddress.Text = provider.Address;
                        TxtProviderCity.Text = provider.City;
                        TxtProviderDistrict.Text = provider.District;
                        TxtProviderPhoneNumber.Text = provider.PhoneNumber;
                        TxtProviderEmail.Text = provider.Email;

                        //Sağlayıcı bilgilerini düzenlenemez hale getirir.
                        TxtProviderName.ReadOnly = true;
                        TxtProviderAddress.ReadOnly = true;
                        TxtProviderCity.ReadOnly = true;
                        TxtProviderDistrict.ReadOnly = true;
                        TxtProviderPhoneNumber.ReadOnly = true;
                        TxtProviderEmail.ReadOnly = true;

                        //Sağlayıcıyla ilişkili ilk hizmet tanımını alır.
                        ServiceDescriptor firstServiceDescriptor = _serviceDescriptorRepository.GetAll().FirstOrDefault(d => d.ServiceValues.Any(v => v.ProviderServiceValues.Any(psv => psv.ServiceProviderId == provider.Id)));

                        if (firstServiceDescriptor != null)
                        {
                            //Hizmet tanım bilgilerini doldurur.
                            TxtDescriptorName.Text = firstServiceDescriptor.Name;
                            TxtDescriptorDescription.Text = firstServiceDescriptor.Description;

                            //Hizmet adı ve açıklamasını düzenlenemez hale getirir.
                            TxtDescriptorName.ReadOnly = true;
                            TxtDescriptorDescription.ReadOnly = true;
                        }
                        else
                        {
                            //Eğer ilişkili hizmet tanımı yoksa alanları temizler.
                            TxtDescriptorName.Clear();
                            TxtDescriptorDescription.Clear();
                        }

                        //Hizmet değer bilgilerini boş bırakır.
                        TxtValueName.Clear();
                        NudCost.Value = 0;
                        NudPreparationTime.Value = 0;
                        NudBufferTime.Value = 0;

                        //Hizmet değer giriş alanlarını düzenlenebilir hale getirir.
                        TxtValueName.ReadOnly = false;
                        NudCost.Enabled = true;
                        NudPreparationTime.Enabled = true;
                        NudBufferTime.Enabled = true;

                        //Kontrolleri kullanıcı girişine açar.
                        SetControlsEnabled(true);
                    }
                }
                else
                {
                    //Eğer geçerli bir seçim yapılmadıysa tüm alanları temizler ve girişleri devre dışı bırakır.
                    ClearFields();
                    SetControlsEnabled(false);
                }
            }
        }

        //Form Metotları
        private void SetInitialControlState()
        {
            //Başlangıçta CheckBox seçili, yeni sağlayıcı ekleme modunda olacak.
            ChkNewProvider.Checked = true;
            SetControlsEnabled(true);
            CmbExistingProviders.Enabled = false; //Mevcut sağlayıcı seçeneği pasif
        }

        private void InitializeListView()
        {
            //ListView'in görüntüleme modunu 'Detaylar' olarak ayarla
            LstServices.View = View.Details;

            //ListView'e "Sağlayıcı Firma" başlıklı bir sütun ekle ve genişliğini 150 piksel olarak ayarla
            LstServices.Columns.Add("Sağlayıcı Firma", 150);

            //ListView'e "Hizmet İsmi" başklıklı bir sütun ekle ve genişliğini 150 piksel olarak ayarla
            LstServices.Columns.Add("Hizmet İsmi", 150);

            //ListView'e "Maliyet(₺)" başlıklı bir sütun ekle ve genişliğini 100 piksel olarak ayarla
            LstServices.Columns.Add("Maliyet(₺)", 100);
        }

        private void LoadExistingProviders()
        {
            try
            {
                //Aktif sağlayıcıları veritabanından getirir ve gerekli alanları seçerek bir liste oluşturur.
                var providers = _serviceProviderRepository.GetActives()
                    .Select(p => new
                    {
                        //Sağlayıcı adı, şehir ve ilçeyi birlikte görüntülenecek metin olarak ayarlar.
                        Display = $"{p.ProviderName} ({p.City}/{p.District})",
                        Value = p.Id //Sağlayıcı kimliğini bir değer olarak belirler.
                    }).ToList();

                //Mevcut sağlayıcılar listesinin veri kaynağını oluşturulan liste olarak ayarlar.
                CmbExistingProviders.DataSource = providers;

                //Görüntülenecek metin için DisplayMember özelliğini ayarlar.
                CmbExistingProviders.DisplayMember = "Display";

                //Sağlayıcı kimliğini bir değer olarak kullanmak için ValueMember özelliğini ayarlar.
                CmbExistingProviders.ValueMember = "Value";

                //Varsayılan olarak hiçbir öğenin seçili olmamasını sağlar.
                CmbExistingProviders.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu : {ex.Message}"); //Bir hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void LoadExistingServices()
        {
            try
            {
                //Sağlayıcı-Hizmet ilişkilerini getirir ve gerekli bilgileri seçerek bir liste oluşturur.
                var providerServiceValues = _providerServiceValueRepository.GetAll()
                    .Select(psv => new
                    {
                        ProviderName = psv.ServiceProvider.ProviderName, //Hizmet sağlayıcının adı
                        ServiceName = psv.ServiceValue.Name, //Hizmetin adı
                        Cost = psv.ServiceValue.Cost //Hizmetin maliyeti
                    })
                    .ToList();

                //ListView kontrolünü temizler, eski verileri kaldırır.
                LstServices.Items.Clear();

                foreach (var service in providerServiceValues)
                {
                    //Yeni bir ListViewItem oluşturur ve sağlayıcı adını ekler.
                    ListViewItem item = new ListViewItem(service.ProviderName);

                    //Hizmet adını alt öğe olarak ekler.
                    item.SubItems.Add(service.ServiceName);

                    //Maliyet bilgisini para birimi formatında (₺) alt öğe olarak ekler.
                    item.SubItems.Add(service.Cost.ToString("C2"));

                    //ListView'e oluşturulan öğeyi ekler.
                    LstServices.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hizmetler yüklenirken bir hata oluştu : {ex.Message}"); //Bir hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(TxtDescriptorName.Text) || //Hizmet adı boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtDescriptorDescription.Text) || //Hizmet açıklaması boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtValueName.Text) || //Değer adı boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtProviderName.Text) || //Sağlayıcı adı boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtProviderAddress.Text) || //Sağlayıcı adresi boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtProviderCity.Text) || //Sağlayıcı şehir boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtProviderDistrict.Text) || //Sağlayıcı ilçe boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtProviderPhoneNumber.Text) || //Sağlayıcı telefon numarası boş mu kontrolü
                string.IsNullOrWhiteSpace(TxtProviderEmail.Text) || //Sağlayıcı e-posta boş mu kontrolü
                NudCost.Value <= 0 || //Maliyet sıfır veya negatif mi kontrolü
                NudPreparationTime.Value < 0 || //Hazırlık süresi negatif mi kontrolü
                NudBufferTime.Value < 0) //Yedek süre negatif mi kontrolü
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve geçerli değerler girin."); //Kullanıcıya mesaj göster.
                return false; //Geçerli olmayan değerler durumunda işlemi durdur.
            }
            return true; //Tüm kontroller geçerliyse true döndür.
        }

        private void ClearFields()
        {
            //Formdaki tüm alanları temizler.
            TxtDescriptorName.Clear(); //Hizmet adı alanını temizler.
            TxtDescriptorDescription.Clear(); //Hizmet açıklaması alanını temizler.
            TxtValueName.Clear(); //Değer adı alanını temizler.
            NudCost.Value = 0; //Maliyet alanını sıfırlar.
            NudPreparationTime.Value = 0; //Hazırlık süresi alanını sıfırlar.
            NudBufferTime.Value = 0; //Yedek süre alanını sıfırlar.
            TxtProviderName.Clear(); //Sağlayıcı adı alanını temizler.
            TxtProviderAddress.Clear(); //Sağlayıcı adresini temizler.
            TxtProviderCity.Clear(); //Sağlayıcı şehir bilgisini temizler.
            TxtProviderDistrict.Clear(); //Sağlayıcı ilçe bilgisini temizler.
            TxtProviderPhoneNumber.Clear(); //Sağlayıcı telefon numarasını temizler.
            TxtProviderEmail.Clear(); //Sağlayıcı e-posta bilgisini temizler.
        }

        private void SetControlsEnabled(bool isEnabled)
        {
            //Tüm kontrolleri etkinleştirir veya pasifleştirir
            TxtDescriptorName.Enabled = isEnabled; //Hizmet adı alanını etkinleştirir veya pasifleştirir
            TxtDescriptorDescription.Enabled = isEnabled; //Hizmet açıklaması alanını etkinleştirir veya pasifleştirir
            TxtValueName.Enabled = isEnabled; //Değer adı alanını etkinleştirir veya pasifleştirir
            NudCost.Enabled = isEnabled; //Maliyet alanını etkinleştirir veya pasifleştirir
            NudPreparationTime.Enabled = isEnabled; //Hazırlık süresi alanını etkinleştirir veya pasifleştirir
            NudBufferTime.Enabled = isEnabled; //Yedek süre alanını etkinleştirir veya pasifleştirir
            TxtProviderName.Enabled = isEnabled; //Sağlayıcı adı alanını etkinleştirir veya pasifleştirir
            TxtProviderAddress.Enabled = isEnabled; //Sağlayıcı adresini etkinleştirir veya pasifleştirir
            TxtProviderCity.Enabled = isEnabled; //Sağlayıcı şehir bilgisini etkinleştirir veya pasifleştirir
            TxtProviderDistrict.Enabled = isEnabled; //Sağlayıcı ilçe bilgisini etkinleştirir veya pasifleştirir
            TxtProviderPhoneNumber.Enabled = isEnabled; //Sağlayıcı telefon numarasını etkinleştirir veya pasifleştirir
            TxtProviderEmail.Enabled = isEnabled; //Sağlayıcı e-posta bilgisini etkinleştirir veya pasifleştirir
            BtnAddService.Enabled = isEnabled; //Hizmet ekleme butonunu etkinleştirir veya pasifleştirir
        }
    }
}
