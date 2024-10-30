using ModelsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookLibApp.Repositories
{
    public interface IRepoBookFeedbacks
    {
        void Add(BookFeedbacks bookFeedbacks);
        void Edit(BookFeedbacks bookFeedbacks);
        void Delete(BookFeedbacks bookFeedbacks);
        BookFeedbacks Get(int bookFeedbacksId);
        IEnumerable<BookFeedbacks> GetAll();
    }
}
