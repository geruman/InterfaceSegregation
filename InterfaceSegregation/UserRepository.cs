using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class UserRepository : IReadable, IWritable, IRemovable
    {
        private List<Item> items;
        public UserRepository(List<Item> items)
        {
            this.items = items;
        }
        public int Create(string content)
        {
            items.Add(new Item(items.Last<Item>().Id+1, content));
            return items.Last<Item>().Id;
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

        public void Remove(int id)
        {
            Item removable = null;
            foreach (Item item in items)
            {
                if (item.Id == id)
                {
                    removable = item;
                }
            }
            if (removable != null)
            {
                items.Remove(removable);
            }
        }

        public void Update(int id, string content)
        {
            foreach(Item item in items)
            {
                if(item.Id == id)
                {
                    item.Content = content;
                }
            }
        }
    }
}
