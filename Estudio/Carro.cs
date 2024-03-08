using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    public class Carro
    {
        private string color;

        public Carro(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }
    }

   
}
