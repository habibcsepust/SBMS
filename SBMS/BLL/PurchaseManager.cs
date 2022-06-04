using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;
using SBMS.ViewModel;
using System.Data;

namespace SBMS.BLL
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();
        Purchase purchase = new Purchase();

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

        public List<Product> SelectProduct(Purchase purchase)
        {
            return _purchaseRepository.SelectProduct(purchase);
        }

        public int ProductWiseQuantity(string productName)
        {
            return _purchaseRepository.ProductWiseQuantity(productName);
        }

        public int SelectProductCode(string productName)
        {
            return _purchaseRepository.SelectProductCode(productName);
        }

        public bool SavePurchaseItem(Purchase purchase)
        {
            return _purchaseRepository.SavePurchaseItem(purchase);
        }

        public List<PurchaseDetails> DisplayPurchaeItem()
        {
            return _purchaseRepository.DisplayPurchaeItem();
        }

        public bool UpdatePurchaseItem(PurchaseDetails purchaseDetails, int id)
        {
            return _purchaseRepository.UpdatePurchaseItem(purchaseDetails, id);
        }

        public bool AddPurchaseItem(PurchaseDetails purchaseDetails)
        {
            return _purchaseRepository.AddPurchaseItem(purchaseDetails);
        }

        public bool IsStockProductName(string product)
        {
            return _purchaseRepository.IsStockProductName(product);
        }

        public bool AddStock(Stock stock)
        {
            return _purchaseRepository.AddStock(stock);
        }

        public bool UpdateStock(Stock stock)
        {
            return _purchaseRepository.UpdateStock(stock);
        }

        public bool IsExistBillNo(string invoiceNo)
        {
            return _purchaseRepository.IsExistBillNo(invoiceNo);
        }

        public DataTable SelectPreviousMRP(int productId)
        {
            return _purchaseRepository.SelectPreviousMRP(productId);
        }

        public bool DeleteProduct(int productId)
        {
            return _purchaseRepository.DeleteProduct(productId);
        }

        public List<PurchaseDetails> SearchProduct(string criteria)
        {
            return _purchaseRepository.SearchProduct(criteria);
        }

        public int CountRecord()
        {
            return _purchaseRepository.CountRecord();
        }

        public DataTable CodeSelect(string productName)
        {
            return _purchaseRepository.CodeSelect(productName);
        }

        public int MaxIdOfPurchase()
        {
            return _purchaseRepository.MaxIdOfPurchase();
        }
    }
}
