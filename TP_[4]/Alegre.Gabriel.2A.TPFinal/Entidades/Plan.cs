using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(PlanBasico))]
    [XmlInclude(typeof(PlanIntermedio))]
    [XmlInclude(typeof(PlanPremium))]
    public abstract class Plan
    {
        protected int cantidadDeMegasInternet;
        protected double precioDelPlan;

        protected Plan(int cantidadDeMegasInternet, double precioDelPlan)
        {
            this.cantidadDeMegasInternet = cantidadDeMegasInternet;
            this.precioDelPlan = precioDelPlan;
        }

        /// <summary>
        /// propiedad get/set que debera ser implementada en las clases derivadas. retorna True si el plan incluye fibra optica o false en caso contrario.
        /// </summary>
        public abstract bool TieneFibraOptica { get; set; }

        /// <summary>
        /// propiedad get/set que debera ser implementada en las clases derivadas. retorna True si el plan incluye cable o false en caso contrario.
        /// </summary>
        public abstract bool TieneCable { get; set; }

        /// <summary>
        /// propiedad get/set que debera ser implementada en las clases derivadas. retorna True si el plan incluye telefonia fija o false en caso contrario.
        /// </summary>
        public abstract bool TieneTelefoniaFija { get; set; }

        /// <summary>
        /// propiedad get/set del precio del plan
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precioDelPlan;
            }
            set
            {
                if (value > 0)
                {
                    this.precioDelPlan = value;
                }
            }
        }

        /// <summary>
        /// propiedad get/set de la cantidad de megas de internet del plan
        /// </summary>
        public int CantidadDeMegasInternet
        {
            get
            {
                return this.cantidadDeMegasInternet;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadDeMegasInternet = value;
                }
            }
        }

        /// <summary>
        /// Motodo virtual encargado de mostrar los datos que comparten todos los planes, luego va a ser sobre escrito en las clases derivadas
        /// </summary>
        /// <returns>Una string con los datos del plan</returns>
        public virtual string MostarDatosDelPlan()
        {
            string tieneFibraOptica = this.TieneFibraOptica ? "Si" : "No";
            string tieneCable = this.TieneCable ? "Si" : "No";
            string tieneTelefoniFija = this.TieneTelefoniaFija ? "Si" : "No";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de megas de internet: {this.cantidadDeMegasInternet}");
            sb.AppendLine($"Incluye Cable: {tieneCable}");
            sb.AppendLine($"Incluye Telefonia fija: {tieneTelefoniFija}");
            sb.AppendLine($"Incluye Fibra optica: {tieneFibraOptica}");
            sb.AppendLine($"Precio final del plan: {this.precioDelPlan}");

            return sb.ToString();
        }
    }
}
