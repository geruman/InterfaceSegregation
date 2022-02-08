using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> userItems = new List<Item>
            { 
                new Item(1, "UserItem 1"),
                new Item(2, "UserItem 2"),
                new Item(3, "UserItem 3"),
                new Item(4, "UserItem 4"),
                new Item(5, "UserItem 5")
            };
            List<Item> reportItems = new List<Item>()
            {
                new Item(1, "ReportItem 1"),
                new Item(2, "ReportItem 2"),
                new Item(3, "ReportItem 3"),
                new Item(4, "ReportItem 4"),
                new Item(5, "ReportItem 5")
            };
            UserRepository userRepository = new UserRepository(userItems);
            ReportRepository reportRepository = new ReportRepository(reportItems);

            Console.WriteLine("Operaciones en el userRepository");
            Console.WriteLine("Todos los items");
            WriteItems(userRepository.GetAll());
            Console.WriteLine("Item id 3");
            Console.WriteLine(userRepository.Get(3));
            Console.WriteLine("Remove item 3");
            userRepository.Remove(3);
            Console.WriteLine("Todos los items");
            WriteItems(userRepository.GetAll());
            Console.WriteLine("Update item 4");
            userRepository.Update(4, "Este item se modifico");
            Console.WriteLine(userRepository.Get(4));
            Console.WriteLine("Creando item nuevo");
            userRepository.Create("Este es el nuevo item");
            Console.WriteLine("Todos los items");
            WriteItems(userRepository.GetAll());


            Console.WriteLine("\n\nOperaciones en el report repository");
            Console.WriteLine("buscando item 4");
            Console.WriteLine(reportRepository.Get(4));
            Console.WriteLine("buscando item 2");
            Console.WriteLine(reportRepository.Get(2));
            Console.WriteLine("Todos los items");
            WriteItems(reportRepository.GetAll());
            Console.ReadKey();



                 
        }
        private static void WriteItems(List<Item> items)
        {
            foreach(Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
