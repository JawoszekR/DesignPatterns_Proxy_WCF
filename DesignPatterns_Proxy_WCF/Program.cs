using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Proxy_WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceClient = new ServiceReference1.ServiceClient();
            var person = new ServiceReference1.PersonDto();
            person = serviceClient.GetPersonById(person, 1);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Surname);
            Console.ReadKey();
        }
    }
}
