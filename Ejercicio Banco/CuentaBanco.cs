using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Banco
{
    internal class CuentaBanco
    {
        //atributos
        public string nombre;
        public string apellido;
        public double saldo;

        //constructor
        public CuentaBanco (string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.saldo = 50.0;
        }
        //para ver información
        public void Informacion()
        {
            Console.WriteLine($"Hola {nombre} {apellido}. ¡¡¡Bienvenido!!!");
        }

        //para depositar
        public void Depositar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine($"\nSe ha depositado ${cantidad}.\nSaldo actual:${saldo}");
            }
            else
            {
                Console.WriteLine("La cantidad para depositar debe ser mayor a $0 (cero).");
            }
        }

        //para retirar
        public void Retirar(double cantidad)
        {
            if (cantidad > 0)
            {
                if (cantidad <= saldo)
                {
                    saldo -= cantidad;
                    Console.WriteLine($"\nSe ha retirado ${cantidad}.\nSaldo actual: ${saldo}");
                }
                else
                {
                    Console.WriteLine("\nFondos Insuficientes...");
                }
            }
            else
            {
                Console.WriteLine("\nLa cantidad para retirar debe ser mayor a $0 (cero).");
            }
        }
        //para consultar saldo
        public void ConsultarSaldo()
        {
            Console.WriteLine($"\nSaldo final: ${saldo}");
        }
    }
}
