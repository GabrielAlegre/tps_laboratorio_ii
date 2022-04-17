using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Metodo encargado de validar que el operador recibido sea +, -, / o *.
        /// </summary>
        /// <param name="operador">Operandor a validar.</param>
        /// <returns>En caso de que el operador sea valido retorna el valor del mismo, caso contrario, es decir, si es invalido retornará +.</returns>
        private static char ValidarOperador(char operador)
        {
            char operadorValidado = ' ';
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                operadorValidado = '+';
            }
            else
            {
                operadorValidado = operador;
            }

            return operadorValidado;
        }

        /// <summary>
        /// Metodo que validará y realizará la operación pedida entre ambos números.
        /// </summary>
        /// <param name="num1">Objeto que representa al primer operando.</param>
        /// <param name="num2">Objeto que representa al segundo operando.</param>
        /// <param name="operador">Char que representa la operacion matematica a realizar.</param>
        /// <returns>El resultado de la operacion matematica.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                default:
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
