using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class FairService : BaseEntity
    {
        //Görev : Bir fuar için sağlanan hizmetleri temsil eder.

        //Fuar Hizmet Detayları
        public string Name { get; set; } //Hizmet adı (örneğin, "Teknik Destek")
        public decimal Cost { get; set; } //Hizmet maliyeti
        public bool IsMandatory { get; set; } //Hizmet zorunlu mu?

        //Foreign Key
        public int FairId { get; set; } //Hangi fuara ait

        //Relational Properties
        public virtual Fair Fair { get; set; } // 1 Fair N FairService, 1 FairService 1 Fair
        public virtual List<FairServiceProvider> FairServiceProviders { get; set; } // 1 FairService N ServiceProvider, 1 ServiceProvider N FairService (Ara tablo : FairServiceProvider)
    }
}
