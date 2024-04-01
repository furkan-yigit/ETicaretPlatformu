using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.VMs.Order
{
    public class GetOrderVm
    {
        #region Order bilgileri
        public int Id { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public DateTime CreateDate { get; set; }
        #endregion
        #region Kullanıcı bilgileri
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserFullName => UserFirstName + " " + UserLastName;
        #endregion
    }
}
