using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Domain.Entities
{
    public class Cart : IBaseEntity
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }

        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        public List<CartLine> CartLines { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
