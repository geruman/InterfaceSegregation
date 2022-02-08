using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IWritable
    {
        void Update(int id, string content);
        int Create(string Content);
    }
}
