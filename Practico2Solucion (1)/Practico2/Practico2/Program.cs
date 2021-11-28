using System;
using Practico2Dominio;

namespace Practico2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            do
            {
                MostrarMenu();
                Console.WriteLine("Ingrese la opción deseada");
                int.TryParse(Console.ReadLine(), out opcion);
                VerificarOpcion(opcion);

            } while (opcion != 0);

            Console.ReadKey();

        }
        static void MostrarMenu()
        {
            Console.WriteLine("1-Ejercicio 1");
            Console.WriteLine("2-Ejercicio 2");
            Console.WriteLine("3-Ejercicio 3");
            Console.WriteLine("4-Ejercicio 4");
            Console.WriteLine("0-Salir");
        }
        static void VerificarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;              
                default:
                    break;
            }
        }
        static void Ejercicio1()
        {
            Console.WriteLine("Ingrese marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese modelo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese S si el auto exonera impuestos, sino ingrese N");
            char exoneraLetra;
            char.TryParse(Console.ReadLine(), out exoneraLetra);
            Console.WriteLine("Ingrese anio");
            int.TryParse(Console.ReadLine(), out int anio);
            Console.WriteLine("Ingrese matricula");
            string matricula = Console.ReadLine();
            bool exoneraImpuestos = false;
            if (exoneraLetra == 'S' || exoneraLetra == 's')
            {
                exoneraImpuestos = true;
            }
            //Llamo al método de clase en Auto que verifica si la matrícula es correcta
            if (Auto.ValidarMatricula(matricula))
            {//si la matrícula es correcta, creo el objeto Auto, muestro sus datos y valor de patente
                Auto miAuto = new Auto(marca, modelo, exoneraImpuestos, anio, matricula);
                Console.WriteLine("Los datos del auto son " + miAuto.Marca + "-" + miAuto.Matricula + "-" + miAuto.Modelo + "-" + miAuto.ExoneraImpuestos);
                Console.WriteLine("El valor de la patente del auto es " + miAuto.CalcularPatente());
            }
            else
            {
                Console.WriteLine("La matrícula no es correcta");
            }
        }
        static void Ejercicio2()
        {
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento - yyyy-MM-dd");
            DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento);
            Console.WriteLine("Ingrese valor de la hora");
            decimal.TryParse(Console.ReadLine(), out decimal valorHora);
            Console.WriteLine("Ingrese antiguedad");
            int.TryParse(Console.ReadLine(), out int antiguedad);
            Console.WriteLine("Ingrese horas trabajadas");
            int.TryParse(Console.ReadLine(), out int horasTrabajadas);
            if (nombre != "" && apellido != "" && fechaNacimiento > DateTime.MinValue
                && valorHora > 0 && antiguedad > 0 && horasTrabajadas > 0)
            {
                Empleado miEmpleado = new Empleado(nombre, apellido, fechaNacimiento, valorHora,
                    antiguedad, horasTrabajadas);
                Console.WriteLine("Los datos del empleado son:" + miEmpleado);

            }
            else
            {
                Console.WriteLine("Los datos no son correctos");
            }
        }
        static void Ejercicio3()
        {
            Console.WriteLine("Ingrese id");
            int.TryParse(Console.ReadLine(), out int id);
            Console.WriteLine("Ingrese fecha, yyyy-MM-dd");
            DateTime.TryParse(Console.ReadLine(), out DateTime fecha);
            Console.WriteLine("Ingrese cedula");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese lugar");
            string lugar = Console.ReadLine();
            Console.WriteLine("Ingrese si es urgente, S para indicar que si, N para indicar que no");
            char.TryParse(Console.ReadLine().ToUpper(), out char urgenteTexto);
            bool urgente = false;
            if (urgenteTexto == 'S')
            {
                urgente = true;
            }
            if (id > 0 && fecha > DateTime.MinValue && cedula != "" && lugar != "")
            {
                CitaMedica miCitaMedica = new CitaMedica(id, fecha, cedula, lugar, urgente);
                Console.WriteLine("Los datos de la cita médica son :"+miCitaMedica);
            }
            else
            {
                Console.WriteLine("Los datos no son correctos");
            }

        }
        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese titular");
            string titular = Console.ReadLine();
            Console.WriteLine("Ingres tipo de cuenta, CC-Cuenta corriente, CA-Caja de Ahorro");
            string tipoCuenta = Console.ReadLine();
            Console.WriteLine("Ingrese moneda, $-pesos, U$S dólares");
            string tipoMoneda = Console.ReadLine();
            Console.WriteLine("Ingrese número de cuenta");
            int.TryParse(Console.ReadLine(), out int numeroCuenta);
            if (titular != "" && tipoCuenta != "" && tipoMoneda != "" && numeroCuenta > 0)
            {
                if (Cuenta.ValidarTipoCuenta(tipoCuenta))
                {
                    if (Cuenta.ValidarTipoMoneda(tipoMoneda))
                    {
                        Cuenta miCuenta = new Cuenta(numeroCuenta, titular, tipoCuenta, tipoMoneda);
                        Console.WriteLine("La cuenta se creó correctamente, seleccione si desea realizar un retiro o un depósito");
                        int opcionCuenta = -1;
                        while (opcionCuenta != 0)
                        {
                            Console.WriteLine("1-Agregar Movimiento");
                            Console.WriteLine("0-Salir de opciones de cuenta");
                            int.TryParse(Console.ReadLine(), out opcionCuenta);


                            if (opcionCuenta == 1)
                            {
                                AgregarMovimiento(miCuenta);
                            }                          
                        }

                    }
                    else
                    {
                        Console.WriteLine("El tipo de moneda no es correcta");
                    }
                }
                else
                {
                    Console.WriteLine("El tipo de cuenta no es correcta");
                }

            }
            else
            {
                Console.WriteLine("Los datos no son correctos");
            }

        }
        static void AgregarMovimiento(Cuenta miCuenta)
        {

            Console.WriteLine("Ingrese importe ");
            double.TryParse(Console.ReadLine(), out double importe);
            Console.WriteLine("Ingrese moneda, $-pesos, U$S dólares");
            string tipoMoneda = Console.ReadLine();
            Console.WriteLine("Ingrese 1 si es un depósito o 2 si es un retiro");
            int.TryParse(Console.ReadLine(), out int tipoMovimiento);
            if (importe > 0)
            {
                if (tipoMovimiento == 1)
                {
                    if (miCuenta.AgregarDeposito(importe, tipoMoneda))
                    {
                        Console.WriteLine("El depósito se realizó correctamente, el saldo actual es " + miCuenta.SaldoCuenta);
                    }
                    else
                    {
                        Console.WriteLine("El  depósito no se realizó");
                    }
                }

                else if (tipoMovimiento == 2)
                {
                    if (miCuenta.AgregarRetiro(importe, tipoMoneda))
                    {
                        Console.WriteLine("El retiro se realizó correctamente, el saldo actual es " + miCuenta.SaldoCuenta);
                    }
                    else
                    {
                        Console.WriteLine("El  retiro no se realizó");
                    }
                }
            }
            else
            {
                Console.WriteLine("El importe no es correcto");
            }
        }

    }
}
