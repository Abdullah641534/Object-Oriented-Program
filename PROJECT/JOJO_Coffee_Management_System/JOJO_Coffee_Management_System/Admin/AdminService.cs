using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.Admin
{
    class AdminService
    {
        private AdminRepo _repo;

        public AdminService(AdminRepo repo)
        {
            _repo = repo;
        }

        public bool CheckLogin(string user, int pass)
        {
            AdminModel admin = _repo.GetAdmin();
            if (admin.Username == user && admin.Password == pass)
            {
                return true;
            }
            return false;
        }
    }
}
