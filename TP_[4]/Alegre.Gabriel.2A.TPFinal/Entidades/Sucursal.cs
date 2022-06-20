using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int idSucursal;
        private string provincia;
        private string localidad;
        private string direccion;
        private string telefono;

 
        public Sucursal(int idSucursal, string provincia, string localidad, string direccion, string telefono): this(provincia, localidad, direccion ,telefono)
        {
            this.idSucursal = idSucursal;
        }

        public Sucursal(string provincia, string localidad, string direccion, string telefono)
        {
            this.provincia = provincia;
            this.localidad = localidad;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        /// <summary>
        /// Propiedad get/set de la id de la sucursal
        /// </summary>
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }

        /// <summary>
        /// Propiedad get/set de la provincia donde se encontrara la sucursal
        /// </summary>
        public string Provincia { get => provincia; set => provincia = value; }

        /// <summary>
        /// Propiedad get/set de la localidad donde se encontrara la sucursal
        /// </summary>
        public string Localidad { get => localidad; set => localidad = value; }

        /// <summary>
        /// Propiedad get/set de la direccion donde se encontrara la sucursal
        /// </summary>
        public string Direccion { get => direccion; set => direccion = value; }

        /// <summary>
        /// Propiedad get/set del telefono correspondiente a la sucursal
        /// </summary>
        public string Telefono { get => telefono; set => telefono = value; }

        /// <summary>
        /// Metodo encargado de armar una string con todos los datos de la sucursal
        /// </summary>
        /// <returns>retorna una string con todos los datos de la sucursal</returns>
        private string DatosSucursal()
        {
            StringBuilder sb = new StringBuilder("Informacion de la sucursal\n");

            sb.AppendLine($"Provincia donde se encuentra: {this.provincia}");
            sb.AppendLine($"Localidad: {this.localidad}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Telefono de contacto: {this.telefono}");
            sb.AppendLine($"Horario de atencion: Lunes a viernes de 9.00 hs a 17.00 hs ");

            return sb.ToString();
        }

        /// <summary>
        /// Expondra todos los datos de la sucursal
        /// </summary>
        /// <returns>una string con todos los datos de la sucursal</returns>
        public override string ToString()
        {
            return DatosSucursal();
        }


    }
}
