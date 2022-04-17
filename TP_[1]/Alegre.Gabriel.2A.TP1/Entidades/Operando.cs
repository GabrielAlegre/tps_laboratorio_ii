using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// Constructor que se encarga en inicializar en 0 el unico atributo de la clase.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que se encarga en inicializar el unico atributo de la clase con el valor del parametro recibido.
        /// </summary>
        /// <param name="numero">Variable de tipo double que contendra el valor que luego se le asignara al atributo de la clase.</param>
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que se encarga en inicializar el unico atributo de la clase con el valor del parametro recibido.
        /// </summary>
        /// <param name="numero">Variable de tipo string que contendra el valor que luego se le asignara al atributo de la clase.</param>
        public Operando(string numero)
        {
            this.Numero = numero;

        }
        /// <summary>
        /// Metodo encargado de asignar un valor al atributo número, luego de su previa validación.
        /// </summary>
        private string Numero
        {
            set { numero = ValidarOperando(value); }
        }

        /// <summary>
        /// comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero">Valor a validar.</param>
        /// <returns>En caso de que el numero recibido sea valido retornara su valor, en caso contrario retorna 0.</returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroValidado;

            if (double.TryParse(strNumero.Replace(".", ","), out numeroValidado) == false)
            {
                numeroValidado = 0;
            }

            return numeroValidado;
        }

        /// <summary>
        /// Método que validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario">Cadena de caracteres a validar.</param>
        /// <returns>True: en caso de que la cadena sea binaria. False: en caso de que la cadena sea invalida, es decir, que no sea binaria.</returns>
        private static bool EsBinario(string binario)
        {
            bool esBinario = true;
            foreach (char caracter in binario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }

        /// <summary>
        /// Metodo que validara que el valor recibido sea un binario, en caso de serlo convertirá ese número binario a decimal
        /// </summary>
        /// <param name="strBinario">Cadena de caracteres que se validara y convertira a decimal</param>
        /// <returns>En caso de que afirmativamente el valor recibido sea un binario retornara el valor decimal de dicho numero binario. Caso contrario retornará "Valor inválido".</returns>
        public static string BinarioDecimal(string strBinario)
        {
            int resultadoEntero = 0;
            string resultadoString = "";
            int cantidadCaracteres = strBinario.Length;
            bool esBinario = EsBinario(strBinario);

            if (esBinario)
            {
                foreach (char caracter in strBinario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultadoEntero += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                resultadoString += resultadoEntero;
            }
            else
            {
                resultadoString = "Valor inválido";
            }

            return resultadoString;
        }
        /// <summary>
        /// Metodo que convertira el valor recibido en binario.
        /// </summary>
        /// <param name="numero">Variable de tipo double que representa el valor del numero a convertir en binario.</param>
        /// <returns>En caso de que se trate de un numero valido retornara el valor de dicho numero en binario. Caso contrario retornará "Valor inválido".</returns>
        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            double numeroAbs = Math.Abs(numero);
            int numeroEntero = (int)numeroAbs;

            if (numeroEntero > 0)
            {
                while (numeroEntero != 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        numeroBinario = 0 + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = 1 + numeroBinario;
                    }

                    numeroEntero = numeroEntero / 2;
                }
            }
            else if(numeroEntero==0)
            {
                numeroBinario = "0";
            }
            else
            {
                numeroBinario = "Valor invalido";

            }
            return numeroBinario;
        }

        /// <summary>
        /// Metodo que convertira el valor recibido en binario.
        /// </summary>
        /// <param name="numeroTxt">Variable de tipo string que representa el valor del numero a convertir en binario.</param>
        /// <returns>En caso de que se trate de un numero valido retornara el valor de dicho numero en binario. Caso contrario retornará "Valor inválido".</returns>
        public static string DecimalBinario(string numeroTxt)
        {
            double numeroValidado;
            string numeroBinario = "";

            if (double.TryParse(numeroTxt, out numeroValidado))
            {
                numeroBinario = DecimalBinario(numeroValidado);
            }
            else
            {
                numeroBinario = "Valor invalido";
            }

            return numeroBinario;
        }

        /// <summary>
        ///  Sobrecarga del operador + que realiza dicha operacion a la hora de sumar dos objetos del tipo operando.
        /// </summary>
        /// <param name="n1">Objeto que representa al primer operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <param name="n2">Objeto que representa al segundo operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <returns>Retornara el resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador / que realiza dicha operacion a la hora de dividir dos objetos del tipo operando.
        /// </summary>
        /// <param name="n1">Objeto que representa al primer operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <param name="n2">Objeto que representa al segundo operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <returns>En caso de que el segundo operando sea distinto a 0 retornara el resultado de la division. Si se tratara de una división por 0, retornará double.MinValue. </returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado = double.MinValue;

            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }

        /// <summary>
        /// Sobrecarga del operador - que realiza dicha operacion a la hora de restar dos objetos del tipo operando.
        /// </summary>
        /// <param name="n1">Objeto que representa al primer operando.</param>
        /// <param name="n2">Objeto que representa al segundo operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <returns>Retornara el resultado de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * que realiza dicha operacion a la hora de multiplicar dos objetos del tipo operando.
        /// </summary>
        /// <param name="n1">Objeto que representa al primer operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <param name="n2">Objeto que representa al segundo operando, que luego se utilizara para acceder al atributo numero.</param>
        /// <returns>Retornara el resultado de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double resultadoMulti = n1.numero * n2.numero;

            //Este if es xq si yo hacia -7 * 0 me daba -0. Para evitar eso hice esta mini validacion
            if (resultadoMulti == -0)
            {
                resultadoMulti = 0;
            }

            return resultadoMulti;
        }
    }
}
