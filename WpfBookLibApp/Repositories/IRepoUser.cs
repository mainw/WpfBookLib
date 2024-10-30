using ModelsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookLibApp.Repositories
{
    public interface IRepoUser
    {
        void Add(User user);
        void Edit(User user);
        void Delete(User user);
        User Get(int userId);
        IEnumerable<User> GetAll();
    }
}
