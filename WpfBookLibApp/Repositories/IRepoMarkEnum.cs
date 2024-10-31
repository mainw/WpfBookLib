using ModelsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookLibApp.Repositories
{
    public interface IRepoMarkEnum
    {
        void Add(MarkEnum markEnum);
        IEnumerable<MarkEnum> GetAll();
    }
}
