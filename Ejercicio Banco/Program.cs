using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Banco
{
    internal class Program
    {
        private static string apellido;

        /*Ejercicio simular una cuenta de Banco
* 1. Crear la clase CuentaBnaco
* 2. Declarar variables
* nombre, apellido(atributos vacios), 50$ (definido)
* 3. metodos
* depositar, retirar, consultarSaldo*/
        static void Main(string[] args)
        {
            //Se solicita información
            Console.Write("Ingreses su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            // Crear una cuenta bancaria

            CuentaBanco cuenta = new CuentaBanco(nombre, apellido);

            // Mostrar información del titular de la cuenta

            cuenta.Informacion();

            // Consultar saldo inicial
            cuenta.ConsultarSaldo();

            // Depositar dinero
            Console.Write("\nIngrese la cantidad a depositar: $");
            double deposito = double.Parse(Console.ReadLine());
            cuenta.Depositar(deposito);

            // Retirar dinero
            Console.Write("\nIngrese la cantidad a retirar: $");
            double retiro = double.Parse(Console.ReadLine());
            cuenta.Retirar(retiro);

            // Consultar saldo final
            cuenta.ConsultarSaldo();

            Console.ReadKey();
        }
    }
}
