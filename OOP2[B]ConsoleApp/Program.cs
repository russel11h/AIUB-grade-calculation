using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_B_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int id = 110;
            string name = "Rasel";

            Console.WriteLine("Name : Md. Rasel Hossain");
            Console.WriteLine("ID: 23-55576-3");
            Console.WriteLine("CGPA:0.00");

            Console.WriteLine("my name and id is:" +name+id);
            Console.WriteLine("my name is :{0} and id is:{1}",name,id);
            */
            Console.Write("Enter Your marks:");
            int v =Convert.ToInt32(Console.ReadLine());
            

            if (v <= 100 && v >= 0)
            {
                if (v <= 100 && v >= 90)
                {
                    Console.WriteLine("You got A+");
                }
                else if (v <= 89 && v >= 85)
                {
                    Console.WriteLine("You got A");
                }
                else if (v <= 84 && v >= 80)
                {
                    Console.WriteLine("You got B+");
                }
                else if (v <= 79 && v >= 75)
                {
                    Console.WriteLine("You got B");
                }
                else if (v <= 74 && v >= 70)
                {
                    Console.WriteLine("You got c+");
                }
                else if (v <= 69 && v >= 65)
                {
                    Console.WriteLine("You got C");
                }
                else if (v <= 64 && v >= 60)
                {
                    Console.WriteLine("You got D+");
                }
                else if (v <= 59 && v >= 55)
                {
                    Console.WriteLine("You got D");
                }
                else if (v <= 54 && v >= 50)
                {
                    Console.WriteLine("You got E");
                }

                else
                {
                    Console.WriteLine("You got F");
                }
            }
            else
            {
                Console.WriteLine("Input valid marks!");
            }
        }
    }
}
