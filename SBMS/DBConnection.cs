using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS
{
    public class DBConnection
    {
        public string ConnectionString { get; set; }
        public DBConnection()
        {
            ConnectionString = @"Server = HABIB; Database = SmallBusinessManagementSystem;
                Integrated Security = true";
        }
    }
}
