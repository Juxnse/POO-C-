using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudio;

namespace Estudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Loro = new Animal(20);
                Console.WriteLine(Loro.GetEdad());
            

            Carro Ferrari = new Carro("Rojo");
            Console.WriteLine(Ferrari.GetColor());
            Ferrari.SetColor("Azul");
            Console.WriteLine(Ferrari.GetColor());

            Perro Bulldog = new Perro(11);
            Console.WriteLine(Bulldog.GetEdad());

            List<string> miLista = new List<string>();
            miLista.Add("Manzana");
            miLista.Add("Plátano");
            miLista.Add("Naranja");
            foreach (var x in miLista)
            {
                //Console.WriteLine($"Hello {x.ToUpper()}!");

                if(x == "Plátano")
                {
                    Console.WriteLine("Es un platano");
                }
            }

            Console.ReadLine();
        }
    }
}
