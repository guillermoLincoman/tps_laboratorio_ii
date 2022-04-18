using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza una operacion matematica segun el signo operador recibido
        /// </summary>
        /// <param Operando="num1"> numero Uno</param>
        /// <param Operando="num2"> numero Dos</param>
        /// <param char="operador"> Operador</param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double numUno = double.Parse(num1.Num);
            double numDos = double.Parse(num2.Num);
            double resultado;
            //1. Realizo la operacion y retorno el resultado 
            switch(ValidarOperador(operador))
            {

                case '-':
                    resultado = numUno - numDos;
                    break;
                case '/':
                    resultado = numUno / numDos;
                    break;
                case '+':
                    resultado = numUno + numDos;
                    break;
                default:
                    resultado = numUno * numDos;
                    break;
            }    
            return resultado;
        }
        /// <summary>
        /// Valida que sea un operador valido
        /// </summary>
        /// <param char="operador"> Operador que recibe para validar</param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            //1. Valido que el operador sea / * - caso contrario retorno +
            if(operador == '/' || operador == '-' || operador == '*')
            {
                return operador;
            }
            return '+';
        }
    }
}
