using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.rep
{
    public interface IRepository
    {
        List<Product> Search(string name);
    }
}
