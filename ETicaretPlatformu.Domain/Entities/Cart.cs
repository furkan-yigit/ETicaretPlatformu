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
        private static Dictionary<int, Cart> _carts = new Dictionary<int, Cart>();

        private Cart() 
        {
            Products = new List<Product>();
        }

        public static Cart Instance(int userId)
        {
            if (!_carts.ContainsKey(userId))
                _carts[userId] = new Cart();

            return _carts[userId];
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<Product> Products { get; set; }


        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }
    }
}
