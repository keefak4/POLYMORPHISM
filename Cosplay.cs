using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class Cosplay:Product
    {
        public string Size { get; private set; }
        public Cosplay(string name,int price,string manafucture,string size)
        {
            Name = name;
            Price = price;
            Manafucture = manafucture;
            Size = size;
        }
        public override double GetDiscountPrice(User _user)
        {
            return Price/2;
        }
    }
}
