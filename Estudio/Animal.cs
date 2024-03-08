using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    public class Animal
    {
        private int edad;

        public Animal(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return this.edad;
        }
    }
}
