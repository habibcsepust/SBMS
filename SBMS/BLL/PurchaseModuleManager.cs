using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.Repository;

namespace SBMS.BLL
{
    public class PurchaseModuleManager
    {
        PurchaseModuleRepository _purchaseRepository = new PurchaseModuleRepository();
        public List<Supplier> LoadSupplier()
        {
            return _purchaseRepository.LoadSupplier();
        }
        public List<Category> LoadCategory()
        {
            return _purchaseRepository.LoadCategory();
        }
        public List<Product> LoadProduct()
        {
            return _purchaseRepository.LoadProduct();
        }
        public List<Product> SelectProduct(int categoryId)
        {
            return _purchaseRepository.SelectProduct(categoryId);
        }
        public int ProductWiseQuantity(int productId)
        {
            return _purchaseRepository.ProductWiseQuantity(productId);
        }
        public int SelectProductCode(int productId)
        {
            return _purchaseRepository.SelectProductCode(productId);
        }
        public DataTable SelectPreviousMRP(int productId)
        {
            return _purchaseRepository.SelectPreviousMRP(productId);
        }
        public bool SaveSupplierPurchase(SupplierPurchase supplierPurchase)
        {
            return _purchaseRepository.SaveSupplierPurchase(supplierPurchase);
        }
        public int MaxIdOfPurchase()
        {
            return _purchaseRepository.MaxIdOfPurchase();
        }
        public int CountRecord()
        {
            return _purchaseRepository.CountRecord();
        }
        public bool AddPurchaseItem(SupplierPurchaseDetails purchaseDetails)
        {
            return _purchaseRepository.AddPurchaseItem(purchaseDetails);
        }
        public bool IsPurchaseProductName(int productId)
        {
            return _purchaseRepository.IsPurchaseProductName(productId);
        }
        public bool UpdatePurchaseProductQty(SupplierPurchaseDetails purchaseDetails)
        {
            return _purchaseRepository.UpdatePurchaseProductQty(purchaseDetails);
        }
        public bool AddStock(SupplierPurchaseDetails purchaseDetails)
        {
            return _purchaseRepository.AddStock(purchaseDetails);
        }
    }
}
