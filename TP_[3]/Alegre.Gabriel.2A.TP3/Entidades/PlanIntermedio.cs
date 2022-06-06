using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanIntermedio : Plan
    {
        private bool paramountPlusGratisPorPlanMedio;
        private bool disneyPlusGratisPorPlanMedio;

        public PlanIntermedio(int cantidadDeMegas, double precio) : base(cantidadDeMegas, precio)
        {
            this.paramountPlusGratisPorPlanMedio = true;
            this.disneyPlusGratisPorPlanMedio = true;
        }

        public PlanIntermedio() : this(100, 3500)
        {

        }

        /// <summary>
        /// propiedad get/set retorna true si el plan incluye Paramount+ Gratis
        /// </summary>
        public bool ParamountPlusGratisPorPlanMedio 
        { 
            get
            { 
                return paramountPlusGratisPorPlanMedio; 
            } 
            set
            { 
                paramountPlusGratisPorPlanMedio = value; 
            }
        }

        /// <summary>
        /// propiedad get/set retorna true si el plan incluye disney+
        /// </summary>
        public bool DisneyPlusGratisPorPlanMedio
        { 
            get 
            { 
                return disneyPlusGratisPorPlanMedio;
            } 
            set
            { 
                disneyPlusGratisPorPlanMedio = value;
            } 
        }

        /// <summary>
        /// propiedad get/set siempre retornara false porque el plan intermedio no incluye fibra optica, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneFibraOptica { get { return false; } set { } }

        /// <summary>
        /// propiedad get/set siempre retornara true porque el plan intermedio siempre incluye cable, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneCable { get { return true; } set { } }

        /// <summary>
        /// propiedad get/set siempre retornara true porque el plan intermdio siempre incluye telefonia fija, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneTelefoniaFija { get { return true; } set { } }


        /// <summary>
        /// Metodo encargado de mostrar los datos del plan intermedio
        /// </summary>
        /// <returns>retorna una string con los datos del plan intermedio</returns>
        public override string MostarDatosDelPlan()
        {
            StringBuilder sb = new StringBuilder("Detalles del plan intermedio\n");
            sb.AppendLine(base.MostarDatosDelPlan());
            sb.AppendLine("Beneficios por plan intermedio: ");
            sb.AppendLine("- Disney+ gratis");
            sb.AppendLine("- Paramount plus gratis");
            return sb.ToString();
        }
    }
}
