using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Core;
using Task6.DAL;
using Task6.Core.Declaration;

namespace Task6.BLL
{
    public class UserService : IUserService
    {
        public UserService()
        {
            this.userProvider = new UserProvider();
        }

        private IUserProvider userProvider;

        public void CreateOrUpdate(User user) 
        {
            List<User> list = userProvider.Get();

            if (user.Id == 0)
            {
                int newID = list.Count > 0 ? list.Max(p => p.Id) : 0;
                user.Id = newID + 1;
                list.Add(user);   
            }
            else
            {
                var updated = list.FirstOrDefault(p => p.Id == user.Id);
                updated.Name = user.Name;
                updated.BirthDay = user.BirthDay;
            }

            userProvider.Save(list);
        }

        public List<User> Get()
        {
            return userProvider.Get();
        }

        public User Get(int id)
        {
            return userProvider.Get().FirstOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            var users = Get();
            users.RemoveAll(p => p.Id == id);
            userProvider.Save(users);
        }
    }
}
