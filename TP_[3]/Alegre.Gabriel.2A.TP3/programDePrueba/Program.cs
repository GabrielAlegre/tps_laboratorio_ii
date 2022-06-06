using System;
using Entidades;
namespace programDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente("Juan", "Perez", "Av. Mitre 1346", 44965932, new PlanIntermedio());
            CentralAdministradora.ListaDeClientes.Add(unCliente);
            

            // Act - Lo busco en el sistema, deberia retornar true xq el cliente si mi sistema
            bool resultado = CentralAdministradora.VerificarSiClienteEstaEnElSistma(44965932);

            Console.WriteLine(resultado);
        }
    }
}
