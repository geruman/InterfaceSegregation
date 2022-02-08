using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ReportRepository : IReadable
    {
        private List<Item> items;
        public ReportRepository(List<Item> items)
        {
            this.items = items;
        }
        public Item Get(int id)
        {
            foreach(Item item in items)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Item> GetAll()
        {
            return items;
        }
    }
}
