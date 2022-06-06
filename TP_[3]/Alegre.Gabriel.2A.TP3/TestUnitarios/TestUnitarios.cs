using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException(typeof(NoExisteClienteActivoConElDniIngresadoException))]
        public void VerificarSiElClienteExisteYEstaActivoEnElSistema_CuandoElClienteNoExista_DeberiaLanzarNoExisteClienteActivoConElDniIngresadoException()
        {
            // Arrange - instancio un cliente que no esta en mi sistema
            Cliente unCliente = new Cliente("Juan", "Perez", "Av. Mitre 1346", 895485765, new PlanPremium());

            // Act - Lo busco en el sistema, deberia lanzarme la excepcion xq dicho cliente no existe en mi sistema
            bool resultado = CentralAdministradora.VerificarSiElClienteExisteYEstaActivoEnElSistema(895485765);
        }

        [TestMethod]
        public void VerificarSiClienteEstaEnElSistema_CuandoElClienteEsteEnElSistemaYActivo_DeberiaRetornarTrue()
        {
            // Arrange - instancio un cliente que no esta en mi sistema y luego lo agrego
            Cliente unCliente = new Cliente("Juan", "Perez", "Av. Mitre 1346", 44965932, new PlanIntermedio());
            CentralAdministradora.ListaDeClientes.Add(unCliente);

            // Act - Verifico si el cliete esta en el sistema, deberia retornar true xq el si esta
            bool resultado = CentralAdministradora.VerificarSiClienteEstaEnElSistema(44965932);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void BuscarClienteNoActivoEnLaLista_CuandoElClienteEsteActivo_DeberiaRetornarNull()
        {
            // Arrange - instancio un cliente que no esta en mi sistema y luego lo agrego
            Cliente unCliente = new Cliente("Luis", "Miguel Hernandez", "Av. Belgrano 656", 43901903, new PlanIntermedio());
            unCliente.EstaActivo = true;
            CentralAdministradora.ListaDeClientes.Add(unCliente);

            // Act - Deberia retornar null xq el cliente esta activo
            Cliente resultado = CentralAdministradora.BuscarClienteNoActivoEnLaLista(43901903);

            Assert.IsNull(resultado);
        }

    }
}
