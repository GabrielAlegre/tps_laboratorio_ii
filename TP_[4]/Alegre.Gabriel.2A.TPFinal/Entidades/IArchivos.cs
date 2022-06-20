using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T>
    {
        /// <summary>
        /// Guarda un objeto T en un archivo en una ruta específica, este metodo sera implemenado en las clases que impleneten esta interfaz.
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo</param>
        /// <param name="contenido">T Objeto a guardar dentro del archivo.</param>
        void Guardar(string ruta, T contenido);

        /// <summary>
        /// Lee el archivo contenido en la ruta y devuelve un tipo de objeto T, este metodo sera implemenado en las clases que impleneten esta interfaz..
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo</param>
        /// <returns>Un objeto de tipo T</returns>
        T Leer(string ruta);
    }
}
