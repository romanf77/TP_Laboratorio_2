using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_TP1
{
    public class Calculadora
    {

        


        public static double Operar(Numero Numero1, Numero Numero2, String Operador)
        { 
                 double resultado=0;

                 if (Numero1 != null && Numero2 != null)
                 {
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
                        
                 }                                                                 
                 return resultado;                                            
        }


        public static string ValidarOperador (string operador)
        {
            if (operador != null && operador == "+" || operador == "-" || operador == "/" || operador == "*")
                
                return operador;
            
            else
                return "+";
         }
        
        

    }
}
