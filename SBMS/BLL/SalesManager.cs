using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;
using System.Data;

namespace SBMS.BLL
{
    public class SalesManager
    {
        SalesRepository _salesRepository = new SalesRepository();

        //public bool SaveSalesItem(Sales sales)
        //{
        //    return _salesRepository.SaveSalesItem(sales);
        //}

        public List<Customer> LoadCustomer()
        {
            return _salesRepository.LoadCustomer();
        }

        public List<Category> LoadCategory()
        {
            return _salesRepository.LoadCategory();
        }

        public List<PurchaseDetails> LoadProduct()
        {
            return _salesRepository.LoadProduct();
        }

        public List<PurchaseDetails> SelectProduct(Sales sales)
        {
            return _salesRepository.SelectProduct(sales);
        }

        public int CountProduct(string productName)
        {
            return _salesRepository.CountProduct(productName);
        }

        public bool AddSalesItem(Sales_Details sales_Details, double soldPrice,double profit)
        {
            return _salesRepository.AddSalesItem(sales_Details, soldPrice, profit);
        }

        public bool AddSalesAmount(Sales_Amount sales_Amount)
        {
            return _salesRepository.AddSalesAmount(sales_Amount);
        }

        public bool UpdateStockQty(Sales_Details sales_Details)
        {
            return _salesRepository.UpdateStockQty(sales_Details);
        }

        public int CountRecord()
        {
            return _salesRepository.CountRecord();
        }

        public List<Sales_Details> DisplaySalesItem()
        {
            return _salesRepository.DisplaySalesItem();
        }

        public List<Sales_Details> SearchProduct(string criteria)
        {
            return _salesRepository.SearchProduct(criteria);
        }

        public bool UpdateSalesItem(Sales_Details sales_Details, int id)
        {
            return _salesRepository.UpdateSalesItem(sales_Details,id);
        }

        public bool IsStockProductName(string product)
        {
            return _salesRepository.IsStockProductName(product);
        }

        public bool UpdateSalesQty(string product, double qty)
        {
            return _salesRepository.UpdateSalesQty(product,qty);
        }

        public DataTable DisplaySalesInfo()
        {
            return _salesRepository.DisplaySalesInfo();
        }

    }
}
