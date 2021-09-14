using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manafucture { get; set; }
        public virtual double  GetDiscountPrice(User _user)
        {
            if(_user.Spent < 300)
            {
                return Price;
            }
            if(_user.Spent < 1000)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }    
    }
}
