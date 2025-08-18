using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class FairEmployeeConfiguration : BaseConfiguration<FairEmployee>
    {
        // FairEmployee entity'si için veritabanı yapılandırma ayarlarını tanımlayan sınıftır. BaseConfiguration sınıfından türetilmiştir ve FairEmployee entity'sine özel yapılandırmalarını içerir.

        //Class'a ait ayarlamaları sınıf tetiklendiğinde yapılsın istediğimiz için constructor'a belirli görevler yazılır.
        public FairEmployeeConfiguration()
        {
            //Id özelliği veritabanında bir sütun olarak oluşturulmaz.
            Ignore(x => x.Id);

            //FairId ve EmployeeId alanlarından oluşan bir bileşik anahtar (composite key) tanımlanır. Bu, tablodaki her kaydın FairId ve EmployeeId kombinasyonuyla benzersiz olmasını sağlar.
            HasKey(x => new
            {
                x.EmployeeId,
                x.FairId
            });
        }
    }
}
