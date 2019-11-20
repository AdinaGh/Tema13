using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ex3
{
    class Program
    {
        static void ReadNumber(int start, int end)
        {
            int count = 1, number;

            do
            {
                Console.Write("Number{0}: ", count);
                number = Int32.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    throw new System.ArgumentOutOfRangeException();
                    break;
                }
                else
                    start = number;

                count++;
            } while (count < 11);
        }
        static void Main(string[] args)
        {
            Console.Write("Start: ");
            var st = Console.ReadLine();
            Console.Write("End: ");
            var en = Console.ReadLine();

            try
            {
                int start = Int32.Parse(st);
                int end = Int32.Parse(en);
                ReadNumber(start, end);

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Nu ati introdus un numar intreg");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Overflow ");
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Null nu este un numar intreg");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Numarul nu este in ordinea dorita "); 
            }
        }
    }
}
