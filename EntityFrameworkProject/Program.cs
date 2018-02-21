using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();

            Order[] orders = db.Orders.ToArray();
            foreach(Order order in orders)
            {
                string message = $"Id= {order.Id}, Total= {order.Total}, Cust={order.Customer.Name}";
                Console.WriteLine(message);
            }

           
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //Customer[] customers = db.Customers.OrderByDescending(cust => cust.Name).ToArray();
            //foreach (Customer cust in customers)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}, State={cust.State}";
            //    Console.WriteLine(message);
            //}


            
            //Customer[] custArray = db.Customers.Where(cust => cust.City == "Dayton" && cust.Name == "Heywood").ToArray();
            //foreach (Customer cust in custArray)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}, City/St= {cust.City},{cust.State}";
            //    Console.WriteLine(message);
            //}

            Console.ReadKey();
        }
    }
}
