using System;
using System.Runtime.Serialization;

namespace Entidades
{
    public class NoExisteClienteActivoConElDniIngresadoException : Exception
    {
        /// <summary>
        /// </summary>
        /// <param name="message">Mensaje que describe el porque se produjo la excepcion</param>
        public NoExisteClienteActivoConElDniIngresadoException(string message) : this(message, null)
        {
        }

        /// <summary> 
        /// </summary>
        /// <param name="message">Mensaje que describe el porque se produjo la excepcion</param>
        /// <param name="innerException">Inner exception de la excepcion</param>
        public NoExisteClienteActivoConElDniIngresadoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}