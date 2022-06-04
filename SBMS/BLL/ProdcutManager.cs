using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;
using SBMS.ViewModel;

namespace SBMS.BLL
{
    public class ProdcutManager
    {
        ProductRepository _productRepository = new ProductRepository();
        public List<Product> LoadProducts()
        {
            return _productRepository.LoadProducts();
        }

        public bool AddProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public List<ProductView> DisplayProduct()
        {
            return _productRepository.DisplayProduct();
        }

        public bool IsExistCode(Product product)
        {
            return _productRepository.IsExistCode(product);
        }

        public bool IsExistName(Product product)
        {
            return _productRepository.IsExistName(product);
        }

        public bool IsUpdateCategory(Product product, string value, int id)
        {
            return _productRepository.IsUpdateCategory(product,value,id);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public List<ProductView> SearchProduct(string criteria)
        {
            return _productRepository.SearchProduct(criteria);
        }
    }
}
