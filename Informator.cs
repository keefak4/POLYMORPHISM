using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class Informator
    {
        public void Buy(User user,Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} buy is {product.Name}.THE ORDER WAS SENT TO THE WAREHOUSE ");
           
        }
    }
}
