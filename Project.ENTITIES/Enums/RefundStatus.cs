using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Enums
{
    public enum RefundStatus
    {
        //Görev : Ödeme sisteminde iade sürecini yönetmek için kullanılır.

        None = 1, //İade durumu yok
        Requested = 2, //İade talep edildi.
        Processed = 3, //İade işlendi.
        Refunded = 4 //İade tamamlandı.
    }
}
