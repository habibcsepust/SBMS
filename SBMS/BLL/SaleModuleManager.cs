using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;
using System.Data;
using SBMS.ViewModel;

namespace SBMS.BLL
{
    public class SaleModuleManager
    {
        SaleModuleRepository _saleModuleRepository = new SaleModuleRepository();
        
        public List<Customer> LoadCustomer()
        {
            return _saleModuleRepository.LoadCustomer();
        }
        public List<Category> LoadCategory()
        {
            return _saleModuleRepository.LoadCategory();
        }
        public List<SupplierPurchaseDetails> LoadProduct()
        {
            return _saleModuleRepository.LoadProduct();
        }
        public List<SupplierPurchaseDetails> SelectProduct(int catId)
        {
            return _saleModuleRepository.SelectProduct(catId);
        }
        public int CountProduct(string product)
        {
            return _saleModuleRepository.CountProduct(product);
        }
        public bool SaveSale(Sale sale)
        {
            return _saleModuleRepository.SaveSale(sale);
        }
        public int MaxIdOfSale()
        {
            return _saleModuleRepository.MaxIdOfSale();
        }
        public bool SaveDetailsSale(DetailSaleInfo saleDetails, double unitPrice, double profit)
        {
            return _saleModuleRepository.SaveDetailsSale(saleDetails, unitPrice, profit);
        }
        public int CountRecord()
        {
            return _saleModuleRepository.CountRecord();
        }
        public List<Sale> CustomerLoyalityPoint(int customerId)
        {
            return _saleModuleRepository.CustomerLoyalityPoint(customerId);
        }
        public DataTable MRPCalculate(string product)
        {
            return _saleModuleRepository.MRPCalculate(product);
        }
        public bool IsSalesProductName(string productName)
        {
            return _saleModuleRepository.IsSalesProductName(productName);
        }
        public bool UpdateSalesProductQty(DetailSaleInfo saleDetails, double profit)
        {
            return _saleModuleRepository.UpdateSalesProductQty(saleDetails, profit);
        }
        public bool UpdateStockQty(double qty, string product)
        {
            return _saleModuleRepository.UpdateStockQty(qty, product);
        }
        public List<SalesView> DisplaySalesInfo()
        {
            return _saleModuleRepository.DisplaySalesInfo();
        }
        public List<SalesView> SearchSalesRecord(string startDate, string endDate)
        {
            return _saleModuleRepository.SearchSalesRecord(startDate,endDate);
        }
        public DataTable CustomerEndLoyalityPoint(int customerId)
        {
            return _saleModuleRepository.CustomerEndLoyalityPoint(customerId);
        }
        public double LoyalityPoint(int customerId)
        {
            return _saleModuleRepository.LoyalityPoint(customerId);
        }
        public List<TemporaryLoyalityPoint> SelectTempLoyality(int customerId)
        {
            return _saleModuleRepository.SelectTempLoyality(customerId);
        }
        public bool AddLoyalityPoint(TemporaryLoyalityPoint lPoint, double lp)
        {
            return _saleModuleRepository.AddLoyalityPoint(lPoint, lp);
        }
        public bool IsExistCustomer(int customerId)
        {
            return _saleModuleRepository.IsExistCustomer(customerId);
        }
        public bool UpdateCustomerLty(double loyatiPoint, int customerId)
        {
            return _saleModuleRepository.UpdateCustomerLty(loyatiPoint,customerId);
        }
        public bool DeleteLoyalityPoint(int customerId)
        {
            return _saleModuleRepository.DeleteLoyalityPoint(customerId);
        }
        public bool AddSaleStock(DetailSaleInfo saleDetails)
        {
            return _saleModuleRepository.AddSaleStock(saleDetails);
        }
    }
}
