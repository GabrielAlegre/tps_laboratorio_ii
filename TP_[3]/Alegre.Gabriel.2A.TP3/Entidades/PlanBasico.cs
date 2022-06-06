using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanBasico: Plan
    {
        bool hboGratisPorPlanBasico;

        public PlanBasico(int cantidadDeMegas, double precio) : base(cantidadDeMegas, precio)
        {
            this.hboGratisPorPlanBasico = true;
        }
        public PlanBasico() : this(50, 2000)
        {

        }

        /// <summary>
        /// propiedad get/set siempre retornara false porque el plan basico no incluye fibra optica, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneFibraOptica { get { return false; } set { } }
        
        /// <summary>
        /// propiedad get/set siempre retornara true porque el plan basico siempre incluye cable, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneCable { get { return true; } set { } }
        
        /// <summary>
        /// propiedad get/set siempre retornara false porque el plan basico no incluye telefonia fija, el set es para poder serializar pero no se utiliza.
        /// </summary>
        public override bool TieneTelefoniaFija { get { return false; } set { } }

        /// <summary>
        /// propiedad get/set retorna true si el plan incluye Hbo Gratis
        /// </summary>
        public bool HboGratisPorPlanBasico { get { return hboGratisPorPlanBasico; } set { hboGratisPorPlanBasico = value; } }


        /// <summary>
        /// Metodo encargado de mostrar los datos del plan basico
        /// </summary>
        /// <returns>retorna una string con los datos del plan basico</returns>
        public override string MostarDatosDelPlan()
        {
            StringBuilder sb = new StringBuilder("Detalles del plan basico\n");
            sb.AppendLine(base.MostarDatosDelPlan());
            sb.AppendLine("Beneficios por plan basico: ");
            sb.AppendLine("- pack HBO gratis");
            return sb.ToString();
        }
    }
}
