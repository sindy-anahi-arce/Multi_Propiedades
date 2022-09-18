using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Propiedades
{
    class clmulti
    {
        //Atributos
        private int num1;
        private int num2;

        //Propiedades
        public int Nume1
        {
            get => num1; set => num1 = value;
        }
        public int Nume2
        {
            get => num2; set => num2 = value;
        }

        //Método
        public int multip()
        {
            return (num1 * num2);
        }
    }
}
