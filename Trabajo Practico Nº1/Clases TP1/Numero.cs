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
 
        //Constructor Por defecto, Inicializa el atributo numero en 0
        public Numero()
        {
            this.numero = 0;        
        }

       //Constructor recibe double y lo asigna al atributo numero
        public Numero(double Numero)
        {
            this.numero = Numero;             
        }

        //Constructor que recibe un string desde el cuadro de texto, lo valida utilizando tryparse y lo carga en numero
        public Numero(string Numero)
        {
            setNumero(Numero);
                                             
        }
        //Se utiliza para devolver el atributo privado "numero" de la clase Numero
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
 