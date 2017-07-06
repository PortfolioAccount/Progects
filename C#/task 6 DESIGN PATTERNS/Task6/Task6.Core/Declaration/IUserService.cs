using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Core.Declaration
{
    public interface IUserService
    {
        void CreateOrUpdate(User user);

        void Remove(int id);

        List<User> Get();
        User Get(int id);
    }
}
