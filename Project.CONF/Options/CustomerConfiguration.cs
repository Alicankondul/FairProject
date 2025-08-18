using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class CustomerConfiguration : BaseConfiguration<Customer>
    {
        // Customer entity'si için veritabanı yapılandırma ayarlarını tanımlayan sınıftır. BaseConfiguration sınıfından türetilmiştir ve customer entity'sine özel yapılandırmalarını içerir.

        //Class'a ait ayarlamaları sınıf tetiklendiğinde yapılsın istediğimiz için constructor'a belirli görevler yazılır.
        public CustomerConfiguration()
        {
            //Customer ile CustomerDetail arasında birebir bir ilişki kurar. CustomerDetail, Customer'a bağlı olarak, isteğe bağlı (optional) olarak tanımlanmıştır.
            HasOptional(x => x.CustomerDetail).WithRequired(x => x.Customer);
        }
    }
}
