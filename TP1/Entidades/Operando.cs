using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Operando
    {
        private double num;

        public string Num
        {
            get
            {
                return this.num.ToString();
            }
            set
            {
                if(ValidarOperando(value) > 0)
                {
                    this.num = double.Parse(value);
                }
            }
        }

        public string BinarioDecimal(string binario)
        {
            int resultado = 0;
            char[] auxBinario = binario.ToCharArray();
            Array.Reverse(auxBinario);
            //1.Valido que sea binario
            if (EsBinario(binario))
            {
                for (int i = 0; i < auxBinario.Length; i++)
                {
                    if(auxBinario[i] == '1')
                    {
                        resultado += (int)Math.Pow(2, i);
                    }
                }
            }
            else
            {
                //2.Si no es binario retorno
                return "Valor invalido";
            }
            return resultado.ToString();
        }
        /// <summary>
        /// Recibe un numero y lo convierte a binario retornandolo como string
        /// </summary>
        /// <param double="numero"> Numero a convertir</param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            int entero = (int)numero;
            string binario = "";

            if (entero != 0)
            {
                while (entero > 0)
                {
                    binario = (int)entero % 2 + binario;
                    entero = (int)entero / 2;
                }
            }
            else
            {
                binario = "0";
            }
            return binario;

        }
        /// <summary>
        /// Recibe un string y utilizando la anterior funcion convierte el numero a binario retornandolo como string
        /// </summary>
        /// <param string="numero"> Numero a convertir</param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string binario;
            this.Num = numero;
            binario = DecimalBinario(numero);
            if (binario == "0")
            {
                return "Valor invalido";
            }
            return binario;
        }
        /// <summary>
        /// Valida que un numero sea binario
        /// </summary>
        /// <param string="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                //1.Valido que la funcion retorne 1 o 0
                if (binario[i] > 1 && binario[i] < 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Constructores
        public Operando()
        {
            this.num = 0;
        }
        public Operando(double numero)
        {
            this.num = numero;
        }
        public Operando(string strNumero)
        {
            this.Num = strNumero;
        }

        //Operadores
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.num - n2.num;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.num * n2.num;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            //Si se trata de una division por 0 retornada double.MinValue
            if(n2.num == 0)
            {
                return double.MinValue;
            }
            return n1.num / n2.num;
        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.num + n2.num;
        }
        /// <summary>
        /// Valida que sea un numero y lo retorna como tal
        /// </summary>
        /// <param string="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            //1.Comprueba que el valor recibido sea numerico
            if (double.TryParse(strNumero, out double numero))
            {
                //2.Retorno en forma de double
                return numero;
            }
            //3. Caso contrario retorno 0
            return 0;
        }

    }
}
