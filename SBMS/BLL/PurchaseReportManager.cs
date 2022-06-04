using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.ViewModel;

namespace SBMS.BLL
{
    public class PurchaseReportManager
    {
        PurchaseReportRepository _purchaseReportRepository = new PurchaseReportRepository();

        public DataTable SelectPurchaseInfo(string startDate, string endDate)
        {
            return _purchaseReportRepository.SelectPurchaseInfo(startDate,endDate);
        }

        //public List<PurchaseModuleView> DisplayAllPurchaseInfo()
        //{
        //    return _purchaseReportRepository.DisplayAllPurchaseInfo();
        //}
        public DataTable DisplayAllPurchaseInfo()
        {
            return _purchaseReportRepository.DisplayAllPurchaseInfo();
        }
    }
}
