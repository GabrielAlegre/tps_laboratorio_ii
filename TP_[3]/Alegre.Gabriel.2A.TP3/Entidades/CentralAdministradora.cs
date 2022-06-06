using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralAdministradora : IArchivos<string>
    {
        private static List<Cliente> listaDeClientes;
        //private string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"HistorialOperaciones.txt"}";
        private string ruta = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"HistorialOperaciones.txt";
        static CentralAdministradora()
        {
            listaDeClientes = new List<Cliente>();
        }

        /// <summary>
        /// Constructor publico y sin parametros para serializar
        /// </summary>
        public CentralAdministradora()
        {
            listaDeClientes = new List<Cliente>();
        }

        /// <summary>
        /// Propiedad de escritura y lesctura de la lista de clientes
        /// </summary>
        public static List<Cliente> ListaDeClientes
        {
            get
            {
                return listaDeClientes;
            }
            set
            {
                listaDeClientes = value;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura de la ruta del archivo txt donde se guardara el historial de las operaciones realiazadas
        /// </summary>
        public string Ruta { get { return ruta; } }

        /// <summary>
        /// Metodo encargado de mostrar los clientes cargados en la lista
        /// </summary>
        /// <param name="estadoDelCliente">Enumerado que especifica que clientes mostrar, los activos o los no activos</param>
        /// <returns>Retorna una string con los datos de todos los clientes</returns>
        public static string MostrarClientes(EClienteEstado estadoDelCliente)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente unClienteDelSistema in CentralAdministradora.listaDeClientes)
            {
                if (EClienteEstado.Activo == estadoDelCliente && unClienteDelSistema.EstaActivo)
                {
                    sb.AppendLine(unClienteDelSistema.ToString());
                }
                else if (EClienteEstado.NoActivo == estadoDelCliente && !unClienteDelSistema.EstaActivo)
                {
                    sb.AppendLine(unClienteDelSistema.ToString());
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que verifica si el cliente existe en el sistema (en la lista) atraves del Dni
        /// </summary>
        /// <param name="documunto">Dni del cliente a buscar</param>
        /// <returns>True: Si el dni pertenece a una persona cargada en el sistema (activa o no activa). False: Si el dni NO pertenece a una persona cargada en el sistema</returns>
        public static bool VerificarSiClienteEstaEnElSistema(int documunto)
        {
            bool estaEnElSistema = false;
            if (listaDeClientes != null)
            {
                foreach (Cliente unClienteDelSistema in listaDeClientes)
                {
                    if (unClienteDelSistema.Dni == documunto)
                    {
                        estaEnElSistema = true;
                        break;
                    }
                }
            }

            return estaEnElSistema;
        }

        /// <summary>
        /// Metodo encargado de buscar a un cliente NO activo en la lista
        /// </summary>
        /// <param name="documunto">Documento del cliente a buscar</param>
        /// <returns>El cliente dueño del dni pasado por parametro. NULL: si no se encontro un cliente NO activo en la lista que tenga el dni pasado por parametro</returns>
        public static Cliente BuscarClienteNoActivoEnLaLista(int documunto)
        {
            Cliente clienteEncontrado = null;
            if (listaDeClientes != null)
            {
                foreach (Cliente unClienteDelSistema in listaDeClientes)
                {
                    if (unClienteDelSistema.Dni == documunto && !unClienteDelSistema.EstaActivo)
                    {
                        clienteEncontrado = unClienteDelSistema;
                        break;
                    }
                }
            }

            return clienteEncontrado;
        }
        /// <summary>
        /// Metodo encargado de buscar a un cliente activo en la lista a partir del dni pasado por parametro 
        /// </summary>
        /// <param name="documunto">Documento del cliente a buscar</param>
        /// <returns>Un cliente si es que se encuentra a un cliente activo con el dni pasado por parametro. NULL en caso contrario (que no lo encuente)</returns>
        public static Cliente BuscarClienteActivoPorDni(int documunto)
        {
            Cliente clienteEncontrado = null;
            if (listaDeClientes != null)
            {
                foreach (Cliente unClienteDelSistema in listaDeClientes)
                {
                    if (unClienteDelSistema.Dni == documunto && unClienteDelSistema.EstaActivo)
                    {
                        clienteEncontrado = unClienteDelSistema;
                        break;
                    }
                }
            }
            return clienteEncontrado;
        }

        /// <summary>
        /// Metodo encargado de verificar si existe un cliente activo con el dni pasado por parametro
        /// </summary>
        /// <param name="documunto">Documento con el cual se va a hacer la busqueda del cliente</param>
        /// <returns>True: si se encontro un cliente activo con el dni pasado por parametro, sino una excepcion propia si no se encentra un cliente con dicho dni</returns>
        public static bool VerificarSiElClienteExisteYEstaActivoEnElSistema(int documunto)
        {
            bool estaEnElSistemaActivo;

            if (BuscarClienteActivoPorDni(documunto) is not null)
            {
                estaEnElSistemaActivo = true;
            }
            else
            {
                throw new NoExisteClienteActivoConElDniIngresadoException("excepción (propia) CONTROLADA:\n- No existe ningun cliente activo con el dni ingresado, si quiere, lo puede dar de alta");
            }

            return estaEnElSistemaActivo;
        }

        /// <summary>
        /// Metodo encargado de guardar/escribir un archivo txt
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo</param>
        /// <param name="contenido">Contenido/dato que se quiera guardar/escribir</param>
        public void Guardar(string ruta, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(contenido);
                }
            }
            catch (Exception)
            {
                throw new FallaDeArchivoException("Excepcion propia controlada:\n falla querer guardar el archivo txt del historial");
            }
        }

        /// <summary>
        /// Metodo encargado de leer un archivo txt
        /// </summary>
        /// <param name="ruta">Ruta que señalan la ubicación del archivo</param>
        /// <returns>El contenido del archivo en formato string, en caso contrario (que surga un error) lanza una excepción propia</returns>
        public string Leer(string ruta)
        {
            string contenidoDelArchivo = string.Empty;
            try
            {
                if (File.Exists(ruta) && new FileInfo(ruta).Length > 0)
                {
                    using (StreamReader sw = new StreamReader(ruta))
                    {
                        contenidoDelArchivo = sw.ReadToEnd();
                    }
                }
            }
            catch (Exception)
            {
                throw new FallaDeArchivoException("Excepcion propia controlada:\n falla al querer leer el archivo txt del historial");
            }
            return contenidoDelArchivo;
        }

        /// <summary>
        /// Metodo que se engarga de agregar un cliente a la lista
        /// </summary>
        /// <param name="unCliente">Cliente a agregar</param>
        public void agregarCliente(Cliente unCliente)
        {
            listaDeClientes.Add(unCliente);
            try
            {
                Guardar(ruta, $"{DateTime.Now:f}hs - Se realizo el alta de un cliente:\nLlamado: {unCliente.Nombre}\nCon Dni: {unCliente.Dni}\nAdquirio el {unCliente.PlanEligido.GetType().Name}\n");
            }
            catch (Exception)
            {

                throw new FallaDeArchivoException("Excepcion propia controlada:\n falla al querer guardar el archivo txt del historial");
            }
        }

        /// <summary>
        /// Metodo que se encarga de retornar el proximo numero de cliente
        /// </summary>
        /// <returns>El proximo numero de cliente a asignar</returns>
        public static int ProximoNumeroDeCliente()
        {
            return listaDeClientes.Count + 1;
        }
            
          
    }
}
