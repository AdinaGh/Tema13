using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti calea catre fisierul pe care doriti sa-l cititi: ");
            string fileP = Console.ReadLine();
            try
            {
                string fileC = File.ReadAllText(fileP);
                Console.WriteLine("Continutul fisierului este: ");
                Console.WriteLine(fileC);
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine($"Fisierul {0} nu a fost gasit ", fileP);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Nici o cale catre un fisier introdusa ");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Calea catre fisier nu este corecta ");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("Fisierul ales nu este suportat ");
            }
            catch(PathTooLongException)
            {

                Console.WriteLine("Calea catre fisier este prea lunga ");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directorul nu este corect ");
            }
        }
    }
}
