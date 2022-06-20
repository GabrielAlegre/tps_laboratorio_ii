using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string direccionDelDomicilio;
        private int dni;
        private int numeroDeCliente;
        Plan planEligido;
        private bool estaActivo;

        public Cliente()
        {
            this.numeroDeCliente = CentralAdministradora.ProximoNumeroDeCliente();
        }

        public Cliente(string nombre, string apellido, string direccionDelDomicilio, int dni, Plan planEligido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccionDelDomicilio = direccionDelDomicilio;
            this.dni = dni;
            this.planEligido = planEligido;
            this.estaActivo = true;
        }

        /// <summary>
        /// propiedad get/set el nombre del cliente
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// propiedad get/set el apellido del cliente
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
            }
        }

        /// <summary>
        /// propiedad get/set de la direccion del domicilio del cliente
        /// </summary>
        public string DireccionDelDomicilio
        {
            get
            {
                return this.direccionDelDomicilio;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.direccionDelDomicilio = value;
                }
            }
        }

        /// <summary>
        /// propiedad get/set del dni del cliente
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value >= 0)
                {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        /// propiedad get/set del estado del cliente. va a retornar true si el cliente esta activo, false si el cliente fue dado de baja.
        /// </summary>
        public bool EstaActivo
        {
            get
            {
                return estaActivo;
            }
            set
            {
                estaActivo = value;
            }
        }

        /// <summary>
        /// propiedad get/set del numero de cliente. 
        /// </summary>
        public int NumeroDeCliente
        {
            get
            {
                return numeroDeCliente;
            }
            set
            {
                numeroDeCliente = value;
            }
        }

        /// <summary>
        /// propiedad get/set del plan elegido/adquirido por el cliente
        /// </summary>
        public Plan PlanEligido
        {
            get
            {
                return planEligido;
            }
            set
            {
                this.planEligido = value;
            }
        }
        /// <summary>
        /// Sobrecarga del ToString que mostrara los datos del cliente.
        /// </summary>
        /// <returns>Una string con los datos del cliente.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Domicilio: {this.direccionDelDomicilio}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Numero de cliente: {this.numeroDeCliente}");
            sb.AppendLine($"Plan adquirido:\n{this.planEligido.MostarDatosDelPlan()}");

            return sb.ToString();
        }
    }
}

