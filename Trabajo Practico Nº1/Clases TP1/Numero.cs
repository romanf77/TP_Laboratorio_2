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

        //Constructor que recibe un numero desde el cuadro de texto, que validara y asignara al atributo "numero" mediante setNumero
        public Numero(string Numero)
        {
            setNumero(Numero);
                                             
        }
        //Se utiliza para devolver el atributo privado "numero" de la clase Numero
        public double getNumero()
        {
            return this.numero;

        }

        //Valida el numero ingresado mediante tryparse
        private static double ValidaNumero(string numeroString)
        {
            double numeroValido;

            if (!double.TryParse(numeroString, out numeroValido))
            {
                return 0;
            }

            return numeroValido;
        
        }

        //Asignara el numero ingresado por el cuadro de texto al atributo "numero"
         private void setNumero(string Numero)
         {
             this.numero = ValidaNumero(Numero);                                                         
         }

        
             
    }
}
 