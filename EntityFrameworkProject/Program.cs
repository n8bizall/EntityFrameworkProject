using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();
            Customer[] customers = db.Customers.ToArray();
            //foreach(Customer cust in customers)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}";
            //    Console.WriteLine(message);
            //}
            Customer[] custArray = db.Customers.Where(cust => cust.City == "Dayton" && cust.Name == "Heywood").ToArray();
            foreach (Customer cust in custArray)
            {
                string message = $"Id={cust.Id}, Name={cust.Name}, City/St= {cust.City},{cust.State}";
                Console.WriteLine(message);
            }
         
            Console.ReadKey();
        }
    }
}
