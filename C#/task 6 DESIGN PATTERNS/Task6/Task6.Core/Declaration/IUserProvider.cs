using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Core.Declaration
{
    public interface IUserProvider
    {
        List<User> Get();
        void Save(List<User> users);
    }
}
