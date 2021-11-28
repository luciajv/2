using System;
using ObligatorioDominio;

namespace Obligatorio
{
    class Program
    {
    
        private static DNC miDNC = new DNC();
        static void Main(string[] args)
        {
            int opcion = -1;
            while (opcion != 0)
            {
                MostrarMenu();
                Console.WriteLine("Ingrese opción");
                int.TryParse(Console.ReadLine(), out opcion);
                VerificarOpcion(opcion);
            }

            Console.ReadKey();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1-Listar Actividades");
            Console.WriteLine("2-Cambiar Valor Aforo");
            Console.WriteLine("3-Cambiar Valor Precio Butaca");
            Console.WriteLine("4-Listar Actividades de una Categoría entre fechas ingresadas");
            Console.WriteLine("5-Listar Espectaculos para todo público");
            Console.WriteLine("0-Salir");
        }
        static void VerificarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    ListarActividades();
                    break;
                case 2:
                    ModificarAforo();
                    break;
                case 3:
                    ModificarPrecioButaca();
                    break;
                case 4:
                    ListarActividadesPorCategoriaPorFecha();
                    break;
                case 5:
                    ListarEspectaculosTodoPublico();
                    break;
                default:
                    Console.Clear();
                    break;

            }

        }
        static void ListarActividades()
        {
            Console.WriteLine(miDNC.ListarActividades());
        }



        static void ModificarAforo()
        { //Recibir el nuevo valor de aforo y aplicarlo al lugar donde se dictaría un espectáculo
          //Devolver un mensaje con el nuevo valor de aforo
            Console.WriteLine("Ingrese el nuevo aforo para este lugar");
            int.TryParse(Console.ReadLine(), out int nuevoValorAforo);
            if (nuevoValorAforo > 0 && nuevoValorAforo<=100)
            {
                Console.WriteLine(miDNC.ModificarAforo(nuevoValorAforo));
            }
            else
            {
                Console.WriteLine("El valor ingresado no es correcto, por favor verifique");
            }
        }

        static void ModificarPrecioButaca()
        {
            Console.WriteLine("Ingrese el nuevo precio butaca para este lugar");
            int.TryParse(Console.ReadLine(), out int nuevoValorPrecioButaca);
            if (nuevoValorPrecioButaca > 0)
            {
                Console.WriteLine(miDNC.ModificarPrecioButaca(nuevoValorPrecioButaca));
            }
            else
            {
                Console.WriteLine("El valor ingresado no es correcto, por favor verifique");
            }
        }

        static void ListarActividadesPorCategoriaPorFecha()
        {
            string categoriaSeleccionada = "";
            Console.WriteLine(miDNC.ListarCategorias());
            Console.WriteLine("Salir");

            Console.WriteLine("Ingrese la categoria deseada o escriba S para volver a menu");
            categoriaSeleccionada = Console.ReadLine().ToUpper();
            if(categoriaSeleccionada == "") {
                Console.WriteLine("No puede quedar vacio");
                ListarActividadesPorCategoriaPorFecha();
            }

            if (categoriaSeleccionada == "S")
            {
                Console.Clear();
            
            }
            else{
                Console.WriteLine("Ingrese fecha desde");
                DateTime.TryParse(Console.ReadLine(), out DateTime fechaDesde);
                Console.WriteLine("Ingrese fecha hasta");
                DateTime.TryParse(Console.ReadLine(), out DateTime fechaHasta);
                Console.WriteLine(miDNC.ListarActividadesPorCategoriaYFecha(categoriaSeleccionada, fechaDesde, fechaHasta));
            }
            
        }



        static void ListarEspectaculosTodoPublico()
        {
            Console.WriteLine(miDNC.ListarActividadesParaTodoPublico());
        }
    }
        
 }

