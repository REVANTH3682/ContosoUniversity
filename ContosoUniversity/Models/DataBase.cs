using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class DataBase
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Productid =1,
                     Name = "Nokia",
                    Price=(decimal)19999.99

                },
                 new Product
                {
                    Productid =2,
                     Name = "LG",
                    Price=(decimal)18999.99

                },
                  new Product
                {
                    Productid =3,
                     Name = "SAMSUNG",
                    Price=(decimal)19899.99

                },
                   new Product
                {
                    Productid =4,
                     Name = "Redmi",
                    Price=(decimal)10999.99

                },
                    new Product
                {
                    Productid =5,
                     Name = "Product of the Month",
                    Price=(decimal)19999.99

                },

            };
            return products;
        }
        public static Product GetProduct(string slug)
        {
            List<Product> products = DataBase.GetProducts();
            {
                foreach(Product p in products)
                {
                    if(p.Slug==slug)
                    {
                        return p;
                    }
                }
            }
            return null;
        }
    }
}
