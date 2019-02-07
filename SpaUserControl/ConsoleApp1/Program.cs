using SpaUserControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("André", "andrebaltieri@hotmail.com");
            

            try
            {
                user.SetPassword("andreBaltiori", "andreBaltiori");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
