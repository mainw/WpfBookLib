using ModelsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBookLibApp.Repositories
{
    public interface IRepoNote
    {
        void Add(Note note);
        void Edit(Note note);
        void Delete(Note note);
        Note Get(int noteId);
        IEnumerable<Note> GetAll();
    }
}
