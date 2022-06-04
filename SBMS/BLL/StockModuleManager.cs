using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;

namespace SBMS.BLL
{
    public class StockModuleManager
    {
        StockModuleRepository _stockModuleRepository = new StockModuleRepository();
        public DataTable DisplayStockInfo()
        {
            return _stockModuleRepository.DisplayStockInfo();
        }
        public DataTable DisplayStockByDate(string categoryName,string productName, string startDate, string endDate)
        {
            return _stockModuleRepository.DisplayStockByDate(categoryName, productName,startDate, endDate);
        }
    }
}
