using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IReadable
    {
        Item Get(int id);
        List<Item> GetAll();
    }
}
