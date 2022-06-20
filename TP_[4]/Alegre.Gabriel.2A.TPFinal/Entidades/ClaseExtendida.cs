using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClaseExtendida
    {
        /// <summary>
        /// Metodo de extension que verifica que la instancia que invoca al metodo y los otros dos paramatros que recibe no sean null ni esten vacios
        /// </summary>
        /// <param name="primeraString">Primera string a chequear que no sea null ni este vacia</param>
        /// <param name="segundaString">Primera string a chequear que no sea null ni este vacia</param>
        /// <param name="terceraString">Primera string a chequear que no sea null ni este vacia</param>
        /// <returns>True si algunos de los 3 string que recibe como parametro no sean null ni esten vacios. False si ninguna string es nula ni esta vacia</returns>
        public static bool IsNullOrEmptyMultiple(this string primeraString, string segundaString, string terceraString)
        {
            bool retorno = false;
            if (String.IsNullOrEmpty(primeraString) || String.IsNullOrEmpty(segundaString) || String.IsNullOrEmpty(terceraString))
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Metodo de extension que verifica que la instancia que invoca al metodo sea un dni, le permito que sean 7 numeros porque hay personas con dni 9.000.000 millones por ejemplo.
        /// </summary>
        /// <param name="dni">dni a validar</param>
        /// <returns>True si la cantidad de numeros se corresponde a la de una dni, false en caso contrario</returns>
        public static bool EsDni(this string dni)
        {
            return dni.Length == 7 || dni.Length == 8;
        }

        /// <summary>
        /// Metodo de extension que verifica a traves del enumerado que pasan por parametro cual es el plan seleccionado y retorna los datos del mismo
        /// </summary>
        /// <param name="datos">string donde almacenaran los datos del plan</param>
        /// <param name="planElegido">Enumerado que representa al plan elegido</param>
        /// <returns>Los datos del plan elegido</returns>
        public static string MostrarPlan(this string datos, EPlanElegido planElegido)
        {
            switch (planElegido)
            {
                case EPlanElegido.PlanBasico:
                    datos = new PlanBasico().MostarDatosDelPlan();
                    break;
                case EPlanElegido.PlanIntermedio:
                    datos = new PlanIntermedio().MostarDatosDelPlan();
                    break;
                case EPlanElegido.PlanPremium:
                    datos = new PlanPremium().MostarDatosDelPlan();
                    break;
            }
            return datos;
        }
    }
}
