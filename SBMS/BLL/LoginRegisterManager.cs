using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Model;
using SBMS.Repository;

namespace SBMS.BLL
{
    public class LoginRegisterManager
    {
        LoginRegisterRepository _registerRepository = new LoginRegisterRepository();
        public bool Login(Register register)
        {
            return _registerRepository.Login(register);
        }
    }
}
