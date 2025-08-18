using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class ServiceValueConfiguration : BaseConfiguration<ServiceValue>
    {
        // ServiceValue entity'si için veritabanı yapılandırma ayarlarını tanımlayan sınıftır. BaseConfiguration sınıfından türetilmiştir ve ServiceValue entity'sine özel yapılandırmalarını içerir.

        //Class'a ait ayarlamaları sınıf tetiklendiğinde yapılsın istediğimiz için constructor'a belirli görevler yazılır.
        public ServiceValueConfiguration()
        {

        }
    }
}
