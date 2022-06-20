using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class ClaseSerializadoraXml : IArchivos<List<Cliente>>
    {
        string rutaArchivoXml = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"ListaDeClientesActivos.xml";

        public ClaseSerializadoraXml() { }

        /// <summary>
        /// Propiedad de solo lectura encargada de retornar una ruta
        /// </summary>
        public string RutaArchivoXml
        {
            get
            {
                return rutaArchivoXml;
            }
        }

        /// <summary>
        /// Metodo encargado de serializar un archivo xml
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo</param>
        /// <param name="contenido">Lista de clientes que se quiera serializar</param>
        public virtual void Guardar(string ruta, List<Cliente> contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Cliente>));
                    xml.Serialize(sw, contenido);
                }
            }
            catch (Exception)
            {
                throw new FallaDeArchivoException("Upa, excepcion: No se pudo serializar el archivo XML correctamente :(");
            }
        }

        /// <summary>
        /// Metodo encargado de deserializar un archivo XML
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo XML</param>
        /// <returns>La lista de cliente contenida en el archivo o null en caso que el archivo no exista o este vacio, en caso contrario (que surga un error) retorna lanza una excepción</returns>
        public virtual List<Cliente> Leer(string ruta)
        {
            try
            {
                if (File.Exists(ruta) && new FileInfo(ruta).Length > 0)
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(List<Cliente>));
                        List<Cliente> objeto = xml.Deserialize(sr) as List<Cliente>;
                        return objeto;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new FallaDeArchivoException("Upa, excepcion: No se pudo deserializar el archivo XML correctamente");
            }
        }

    }
}
