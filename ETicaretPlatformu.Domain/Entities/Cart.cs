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
        //private static readonly Dictionary<string, Cart> _carts = new Dictionary<string, Cart>();
        //private static Cart _carts;

        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines { get { return _cartLines; } }


        public Cart() 
        {

        }

        //public static Cart Instance(string userId)
        //{
        //    //if (!_carts.ContainsKey(userId))
        //    //    _carts[userId] = new Cart();

        //    //return _carts[userId];

        //    if (_carts.UserId != userId)
        //        _carts = new Cart();

        //    return _carts;

        //}

        public string Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<Product>? Products { get; set; }


        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
