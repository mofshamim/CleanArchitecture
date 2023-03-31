using CleanArchitecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application
{
    //This interface is use for Bussiness Rule / USE CASE
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
