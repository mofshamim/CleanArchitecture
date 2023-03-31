using CleanArchitecture.Application;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public static List<Product> lstMembers = new List<Product>()
        {
           new Product{  Id =1 ,Name= "Seven Up" },
           new Product{  Id =2 ,Name= "Coco Cola"  },
           new Product{  Id =3 ,Name= "Mountain Dew"   },
           new Product{  Id =4 ,Name= "Sprite"   },
           new Product{  Id =5 ,Name= "Phanta"   },
        };

        public List<Product> GetProducts()
        {
            return lstMembers;
        }
    }
}
