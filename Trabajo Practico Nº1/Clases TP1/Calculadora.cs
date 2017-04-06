using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_TP1
{
    public class Calculadora
    {



        //Metodo que operara entre los numeros y el operador ingresados por cuadro de texto mediante un switch
        public static double Operar(Numero Numero1, Numero Numero2, String Operador)
        { 
                 double resultado=0;
               
                 Operador = ValidarOperador(Operador);


                 switch (Operador)
                 {

                            case "+":

                                resultado = Numero1.getNumero() + Numero2.getNumero();
                                break;

                            case "-":

                                resultado = Numero1.getNumero() - Numero2.getNumero();
                                break;

                            case "*":

                                resultado = Numero1.getNumero() * Numero2.getNumero();
                                break;

                            case "/":

                                if (Numero2.getNumero() != 0)
                                {
                                        resultado = Numero1.getNumero() / Numero2.getNumero();
                                }
                                break;
                  }                        
                        
                                                                                  
                 return resultado;                                            
        }

        //Valida el operador ingresado por cuadro de texto
        public static string ValidarOperador (string operador)
        {
            if (operador != null && operador == "+" || operador == "-" || operador == "/" || operador == "*")
                
                return operador;
            
            else
                return "+";
         }
        
        

    }
}
