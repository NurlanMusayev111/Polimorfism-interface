using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BlogService : IBlogService
    {
        public Blog[] GetAll()
        {
            return Blogs();
        }

        public Blog GetById(int id)
        {
            Blog existblog = Blogs().FirstOrDefault(m => m.Id == id);
            return existblog;
        }









        private Blog[] Blogs()
        {
            return new Blog[]
            {
                new Blog{Id = 1,Title = "Trabzonspor" , Description = "forth big" },
                new Blog{Id = 2,Title = "Besiktas" , Description = "third big" },
                new Blog{Id = 1,Title = "Fenerbahce" , Description = "second big" },
                new Blog{Id = 1,Title = "Galatasaray" , Description = "first big" }
            };
        }
    }
}
