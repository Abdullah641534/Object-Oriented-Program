using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOJO_Coffee_Management_System.User
{
    internal class UserService
    {
        private UserRepo _repo;

        public UserService(UserRepo repo)
        {
            _repo = repo;
        }

        public UserModel GetCurrentUser()
        {
            return _repo.GetUser();
        }
    }
}
