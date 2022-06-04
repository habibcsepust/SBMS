using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Repository;
using SBMS.Model;

namespace SBMS.BLL
{
    public class SupplierManager
    {
        Supplier supplier = new Supplier();
        SupplierRepository _supplierRepository = new SupplierRepository();

        public bool AddSupplier(Supplier supplier)
        {
            return _supplierRepository.AddSupplier(supplier);
        }

        public bool IsExistCode(Supplier supplier)
        {
            return _supplierRepository.IsExistCode(supplier);
        }

        public bool IsExistEmail(Supplier supplier)
        {
            return _supplierRepository.IsExistEmail(supplier);
        }

        public bool IsExistContact(Supplier supplier)
        {
            return _supplierRepository.IsExistContact(supplier);
        }

        public List<Supplier> DisplaySupplier()
        {
            return _supplierRepository.DisplaySupplier();
        }

        public bool UpdateSupplier(Supplier supplier, int id)
        {
            return _supplierRepository.UpdateSupplier(supplier,id);
        }

        public bool DeleteSupplier(int id)
        {
            return _supplierRepository.DeleteSupplier(id);
        }

        public bool IsExistContactPerson(Supplier supplier)
        {
            return _supplierRepository.IsExistContactPerson(supplier);
        }

        public List<Supplier> SearchSupplier(string criteria)
        {
            return _supplierRepository.SearchSupplier(criteria);
        }
    }
}
