using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanPremium : Plan
    {
        private bool netflixGratisPorPlanPremimun;
        private bool packFutbolGratisPorPlanPremimu;
        private bool amazonPrimeVideoGratisPorPlanPremium;
   
        public PlanPremium(int cantidadDeMegas, double precio) : base(cantidadDeMegas, precio)
        {
            this.packFutbolGratisPorPlanPremimu = true;
            this.netflixGratisPorPlanPremimun = true;
            this.amazonPrimeVideoGratisPorPlanPremium = true;
        }

        public PlanPremium() : this(1000, 6000)
        {
        }


        /// <summary>
        /// propiedad get/set retorna true si el plan incluye netflix
        /// </summary>
        public bool Netflix
        {
            get
            {
                return this.netflixGratisPorPlanPremimun;
            }
            set
            {
                this.netflixGratisPorPlanPremimun = value;
            }

        }

        /// <summary>
        /// propiedad get/set retorna true si el plan incluye pack de futbol
        /// </summary>
        public bool PackFutbol
        {
            get
            {
                return this.packFutbolGratisPorPlanPremimu;
            }
            set
            {
                this.packFutbolGratisPorPlanPremimu = value;
            }
        }

        /// <summary>
        /// propiedad get/set retorna true si el plan incluye amazon prime
        /// </summary>
        public bool AmazonPrime
        {
            get
            {
                return this.amazonPrimeVideoGratisPorPlanPremium;
            }
            set
            {
                this.amazonPrimeVideoGratisPorPlanPremium = value;
            }
        }

        /// <summary>
        /// propiedad get/set siempre retornara true porque el plan premium siempre incluye Fibra optica, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneFibraOptica { get { return true; } set { } }

        /// <summary>
        /// propiedad get/set siempre retornara true porque el plan premium siempre incluye cable, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneCable { get { return true; } set { } }

        /// <summary>
        /// propiedad get/set siempre retornara true porque el plan premium siempre incluye telefonia fija, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneTelefoniaFija { get { return true; } set { } }

        /// <summary>
        /// Metodo encargado de mostrar los datos del plan premium
        /// </summary>
        /// <returns>retorna una string con los datos del plan premium</returns>
        public override string MostarDatosDelPlan()
        {
            StringBuilder sb = new StringBuilder("Detalles del plan premium\n");
            sb.AppendLine(base.MostarDatosDelPlan());
            sb.AppendLine("Beneficios por plan premium: ");
            sb.AppendLine("- Netflix gratis");
            sb.AppendLine("- Amazon prime video gratis");
            sb.AppendLine("- Pack futbol gratis");
            return sb.ToString();
        }
    }
}
