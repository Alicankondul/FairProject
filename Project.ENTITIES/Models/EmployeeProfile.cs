using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EmployeeProfile : BaseEntity
    {
        public string FirstName { get; set; } //Çalışanın adı
        public string LastName { get; set; } //Çalışanın soyadı
        public string TC { get; set; } //Çalışanın TC kimlik numarası
        public string PhoneNumber { get; set; } //Çalışanın telefon numarası
        public string Address { get; set; } //Çalışanın tam adresi
        public string City { get; set; } //Çalışanın bulunduğu şehir
        public string District { get; set; } //Çalışanın bulunduğu ilçe

        //Relational Properties
        public virtual Employee Employee { get; set; } // 1 Employee 1 Profile, 1 Profile 1 Employee

        public override string ToString()
        {
            return $"{FirstName} {LastName} / {Employee.Role}";
        }
    }
}
