using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace Entidades
{
    public class EstadisticaServicios : IArchivos<EstadisticaServicios>
    {
        //Informe sobre la atencion al publico
        private string rutaJson = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"InformeEstadistico.json";
        private int cantOperacionesRealizadas;
        private int cantClientesQueDieronBaja;
        private int cantClientesQueModificanAlgunDato;
        private int cantNoActivosQueSeVolvieronADarDeAlta;
        private int cantidadDeGenteEnElSistema;
        private int cantidadDeGenteNoActiva;
        private int cantidadDeAltas;
        private int cantidadDeGenteActiva;

        public EstadisticaServicios()
        {
            this.cantidadDeGenteEnElSistema = 0;
            this.cantidadDeGenteActiva = 0;
            this.cantidadDeGenteNoActiva = 0;
            this.cantidadDeAltas = 0;
            this.cantClientesQueDieronBaja = 0;
            this.cantOperacionesRealizadas = 0;
            this.cantClientesQueModificanAlgunDato = 0;
            this.cantNoActivosQueSeVolvieronADarDeAlta = 0;
        }

        /// <summary>
        /// propiedad get/set de la ruta que señalan la ubicación del archivo Json 
        /// </summary>
        public string RutaSerializarJson
        {
            get
            {
                return rutaJson;
            }
        }

        /// <summary>
        /// propiedad get/set de la cantidad de operaciones (dar alta, dar baja, modificar) realizadas.
        /// </summary>
        public int CantidadOperacionesRealizadas { get { return cantOperacionesRealizadas; } set { cantOperacionesRealizadas = value; } }
       
        /// <summary>
        /// propiedad get/set de la cantidad de clientes que se dieron de baja.
        /// </summary>
        public int CantidadDeClientesQueDieronBaja { get { return cantClientesQueDieronBaja; } set { cantClientesQueDieronBaja = value; } }
        
        /// <summary>
        /// propiedad get/set de la cantidad de gente que estan el en sistema (en la lista de empleados) ya sean activos o no activos.
        /// </summary>
        public int CantidadDeGenteEnElSistema { get { return cantidadDeGenteEnElSistema; } set { cantidadDeGenteEnElSistema = value; } }
        
        /// <summary>
        /// propiedad get/set de la cantidad de clientes que modificaron alguno de sus datos.
        /// </summary>
        public int CantClientesQueModificanAlgunDato { get { return cantClientesQueModificanAlgunDato; } set { cantClientesQueModificanAlgunDato = value; } }
       
        /// <summary>
        /// propiedad get/set de la cantidad de clientes no activos (clientes que algun momento se dieron de baja) y luego se volvieron a dar alta.
        /// </summary>
        public int CantNoActivosQueSeVolvieronADarDeAlta { get { return cantNoActivosQueSeVolvieronADarDeAlta; } set { cantNoActivosQueSeVolvieronADarDeAlta = value; } }

        /// <summary>
        /// propiedad get/set de la cantidad de gente no activa (clientes dados de baja) en el sistema.
        /// </summary>
        public int CantidadDeGenteNoActiva { get => cantidadDeGenteNoActiva; set => cantidadDeGenteNoActiva = value; }

        /// <summary>
        /// propiedad get/set de la cantidad de gente activa en el sistema.
        /// </summary>
        public int CantidadDeGenteActiva { get => cantidadDeGenteActiva; set => cantidadDeGenteActiva = value; }

        /// <summary>
        /// propiedad get/set de la cantidad de altas realizadas.
        /// </summary>
        public int CantidadDeAltas { get => cantidadDeAltas; set => cantidadDeAltas = value; }

        /// <summary>
        /// Metodo encargado de serializar a json
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo json</param>
        /// <param name="contenido">Objeto de tipo EstadisticaServicios que se quiera serializar</param>
        public void Guardar(string ruta, EstadisticaServicios contenido)
        {
            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                string objJson = JsonSerializer.Serialize(contenido, opciones);
                File.WriteAllText(ruta, objJson);
            }
            catch (Exception)
            {
                throw new FallaDeArchivoException("Excepcion: Fallo la serializacion del archivo Json");
            }
        }

        /// <summary>
        /// Metodo encargado de deserializar Json
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo Json</param>
        /// <returns>Objeto de tipo EstadisticaServicios deserializado o null en caso que el archivo no exista o este vacio, en caso contrario (que surga un error) retorna lanza una excepción</returns>
        public EstadisticaServicios Leer(string ruta)
        {
            try
            {
                if (File.Exists(ruta) && new FileInfo(ruta).Length > 0)
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string ContenidoArchivoJson = File.ReadAllText(ruta);
                    return JsonSerializer.Deserialize<EstadisticaServicios>(ContenidoArchivoJson);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new FallaDeArchivoException("Excepcion: Fallo la deserializacion del archivo Json");
            }
        }

        /// <summary>
        /// Metodo que muestra el informe estadistico del programa
        /// </summary>
        /// <returns>string de con la informacion estadistica</returns>
        public string MostrarInforme()
        {
            StringBuilder sb = new StringBuilder();
            calcularCantidadDeOperacionesQueSeRealizaron();
            actualizarCantidadDeGenteActivaYnoActiva();
            sb.AppendLine($"- Cantidad de Altas: {this.cantidadDeAltas}\n");
            sb.AppendLine($"- Cantidad de clientes que modificaron alguno de sus datos: {this.cantClientesQueModificanAlgunDato}\n");
            sb.AppendLine($"- Cantidad de clientes que se dieron de baja: {this.cantClientesQueDieronBaja}\n");
            sb.AppendLine($"- Cantidad de clientes no activos (se dieron de baja) y luego se volvieron a dar de alta: {this.cantNoActivosQueSeVolvieronADarDeAlta}\n");
            sb.AppendLine($"- Cantidad total de operaciones (alta, baja, modificion) que se realizaron: {this.cantOperacionesRealizadas}\n");
            sb.AppendLine($"- Cantidad de personas cargadas en el sistema (Tanto las activas como las no activas): {this.cantidadDeGenteEnElSistema}\n");
            sb.AppendLine($"- Cantidad de Clientes activos: {this.cantidadDeGenteActiva}\n");
            sb.AppendLine($"- Cantidad de Clientes NO activos: {this.cantidadDeGenteNoActiva}\n");

            return sb.ToString();
        }

        /// <summary>
        /// Metodo encargado de calcular la cantidad d eoperaciones realizadas
        /// </summary>
        public void calcularCantidadDeOperacionesQueSeRealizaron()
        {

            this.CantidadOperacionesRealizadas = this.cantidadDeAltas
                                                + this.cantClientesQueDieronBaja
                                                + this.cantClientesQueModificanAlgunDato;

        }

        /// <summary>
        /// Metodo encargado de actualizar la cantidad de clientes que se encuentran activos y la cantidad de gente no activa (dadas de baja)
        /// </summary>
        public void actualizarCantidadDeGenteActivaYnoActiva()
        {
            this.cantidadDeGenteActiva = 0;
            this.cantidadDeGenteNoActiva = 0;
            foreach (Cliente unClienteDelSistema in CentralAdministradora.ListaDeClientes)
            {
                if (unClienteDelSistema.EstaActivo)
                {
                    this.cantidadDeGenteActiva += 1;
                }
                else
                {
                    this.cantidadDeGenteNoActiva += 1;
                }
            }
            this.cantidadDeGenteEnElSistema = cantidadDeGenteActiva + cantidadDeGenteNoActiva;
        }

    }
}
