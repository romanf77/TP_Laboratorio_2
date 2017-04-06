using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_TP1
{
    public class Numero
    {
        private double numero;
 
        
        public Numero()
        {
            this.numero = 0;        
        }

       
        public Numero(double Numero)
        {
            this.numero = Numero;             
        }


        public Numero(string Numero)
        {
            double.TryParse(Numero, out this.numero);                                              
        }

        public double getNumero()
        {
            return this.numero;

        }

        
        private static double ValidaNumero(string numeroString)
        {
            double numeroValido;

            if (!double.TryParse(numeroString, out numeroValido))
            {
                return 0;
            }

            return numeroValido;
        
        }
         private void setNumero(string Numero)
         {
             this.numero = ValidaNumero(Numero);                                                         
         }

        
             
    }
}
 