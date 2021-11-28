using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
    public class DNC
    {
        private List<Lugar> lugares= new List<Lugar>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Compra> compras = new List<Compra>();
        private List<Categoria> categorias = new List<Categoria>();
        private List<Actividad> actividades = new List<Actividad>();

        public DNC()
        {
        CargarDatosUsuario();
        CargarDatosLugares();
        CargarDatosCategorias();
        CargarDatosActividades();
           
        }

    private void CargarDatosUsuario()
    {
        this.AltaUsuario("Luis", "Suarez", "luissuarez@gmail.com", new DateTime(2021, 10, 02));
        this.AltaUsuario("Rick", "Sanchez", "ricksanchezc137@gmail.com", new DateTime(2019, 12, 13));
        }

    private void CargarDatosLugares()
    {
            this.AltaLugarAbierto(1, "Parque Rodo", 3000);
            this.AltaLugarAbierto(2, "Plaza Matriz", 1000);
            this.AltaLugarAbierto(3, "Parque Central", 4000);
            this.AltaLugarAbierto(4, "Estadio Centenario", 5000);
            this.AltaLugarAbierto(5, "Velodromo Municipal", 5000);
            this.AltaLugarCerrado(6, "Shopping Montevideo", 700, false, 10000);
            this.AltaLugarCerrado(7, "Teatro El Galpon", 350, true, 500);
            this.AltaLugarCerrado(8, "Antel Arena", 800, true, 15000);
            this.AltaLugarCerrado(9, "Auditorio Nacional", 500, true, 5000);
            this.AltaLugarCerrado(10, "Teatro Metro", 400, true, 3000);

        }
    private void CargarDatosActividades()
    {
            this.AltaActividad("Titanic", new DateTime(2021, 10, 15, 18, 00, 00), 6, "Cine", "C16", 50);
           this.AltaActividad("Ironman", new DateTime(2021, 10, 20, 20, 30, 00), 6, "Cine", "P", 250);
            this.AltaActividad("Collar de perro", new DateTime(2021, 10, 31, 20, 0, 00), 5, "Teatro", "P", 150);
            this.AltaActividad("Feria de comida oriental", new DateTime(2021, 10, 20, 13, 00, 00), 2, "Feria Gastronomica", "P", 32);
            this.AltaActividad("Historias Galponeras", new DateTime(2021, 10, 06, 19, 00, 00), 7, "Teatro", "C18", 130);
            this.AltaActividad("Concierto La vela Puerca", new DateTime(2021, 10, 03, 20, 30, 00), 5, "Concierto", "C16", 236);
            this.AltaActividad("Show de ballet", new DateTime(2021, 11, 09, 18, 00, 00), 9, "Teatro", "C18", 1602);
            this.AltaActividad("Show de magia", new DateTime(2021, 10, 28, 18, 00, 00), 7, "Teatro", "P", 421);
            this.AltaActividad("Exposicion fotografica", new DateTime(2021, 11, 21, 14, 00, 00), 2, "Exposicion", "P", 123);
            this.AltaActividad("Feria de comida mexicana", new DateTime(2021, 10, 13, 12, 00, 00), 1, "Feria Gastronomica", "P", 689);
            this.AltaActividad("Festival de musica Latina", new DateTime(2021, 10, 12, 17, 00, 00), 8, "Concierto", "C16", 1100);
            this.AltaActividad("Vicentico", new DateTime(2021, 11, 4, 18, 00, 00), 8, "Concierto", "C13", 1100);
            this.AltaActividad("Luciano Pereyra", new DateTime(2021, 10, 27, 18, 00, 00), 8, "Concierto", "C13", 100);
            this.AltaActividad("Cuarteto de Nos", new DateTime(2021, 10, 30, 20, 00, 00), 8, "Concierto", "C13", 1100);
            this.AltaActividad("Arlequino", new DateTime(2021, 10, 22, 15, 00, 00), 7, "Teatro", "P", 68);
        }
    private void CargarDatosCategorias()
    {
        this.AltaCategoria("Cine", "Proyeccion de peliculas");
        this.AltaCategoria("Teatro", "Representacion de obras");
        this.AltaCategoria("Feria Gastronomica", "Degustacion de distintos platos");
        this.AltaCategoria("Concierto", "Espectaculo con bandas y cantantes");
        this.AltaCategoria("Exposicion", "Exhibicion artistica");

    }

        private Usuario ExisteUsuario(string nombre)
        {
            Usuario usuarioBuscado = null;
            int i = 0;
            while (i < usuarios.Count && usuarioBuscado == null)
            {
                if (usuarios[i].Nombre.ToUpper() == nombre.ToUpper())
                {
                    usuarioBuscado = usuarios[i];
                }
                i++;
            }
            return usuarioBuscado;
        }

        private Actividad ExisteActividad(string nombre)
        {
            Actividad actividadBuscada = null;
            int i = 0;
            while (i < actividades.Count && actividadBuscada == null)
            {
                if (actividades[i].Nombre.ToUpper() == nombre.ToUpper())
                {
                    actividadBuscada = actividades[i];
                }
                i++;
            }
            return actividadBuscada;

        }

        private Categoria ExisteCategoria(string nombre)
        {
            Categoria categoriaBuscada = null;

            int i = 0;

            while (i<categorias.Count && categoriaBuscada == null)
            {
                if(categorias[i].Nombre.ToUpper() == nombre.ToUpper())
                {
                    categoriaBuscada = categorias[i];
                }
                i++;
            }
            return categoriaBuscada;
        }

        private Lugar ExisteLugar(int id)
        {
            Lugar lugarBuscado = null;

            int i = 0;

            while (i < lugares.Count && lugarBuscado == null)
            {
                if (lugares[i].Id == id)
                {
                    lugarBuscado = lugares[i];
                }
                i++;
            }
            return lugarBuscado;
        }

      
        private void AltaUsuario(string nombre, string apellido, string email, DateTime fechaDeNacimiento)
        {
            //Verificar parametros ingresados
            if (nombre != "" && apellido != "" && email != "")
            {
                //verificamos existencia 
                if (ExisteUsuario(nombre) == null)
                {
                    Usuario miUsuario = new Usuario(nombre, apellido, email, fechaDeNacimiento);
                    //agregamos a la lista
                    usuarios.Add(miUsuario);
                }
            }
        }
        private void AltaLugarAbierto(int id, string nombre, double dimensiones) {

            if (nombre!="" && dimensiones!=0)
            {

                if (ExisteLugar(id)== null)
                {
                    Abierto miLugarAbierto = new Abierto(id, nombre, dimensiones);
                    lugares.Add(miLugarAbierto);
                }
            }
            
        }

        private void AltaLugarCerrado(int id, string nombre, double dimensiones, bool accesible, int valorMantenimiento)
        {

            if (nombre != "" && dimensiones > 0 && valorMantenimiento>0)
            {

                if (ExisteLugar(id) == null)
                {
                    Cerrado miLugarCerrado = new Cerrado(id, nombre, dimensiones,accesible,valorMantenimiento);
                    lugares.Add(miLugarCerrado);
                }
            }

        }
        private void AltaCategoria(string nombre, string descripcion)
        {
            if (nombre != "" && descripcion != "")
            {
                if (ExisteCategoria(nombre) == null)
                {
                    Categoria miCategoria = new Categoria(nombre, descripcion);

                    categorias.Add(miCategoria);
                }


            }


        }

        private void AltaActividad(string nombre, DateTime fecha, int IdLugar, string nombreCategoria, string edadMinima, int likes)
        {
            if ( nombre != "" && likes >=0) 
            {
                if (ExisteActividad(nombre) == null)
                {
                    Lugar miLugar = ExisteLugar(IdLugar);
                    if (miLugar != null)
                    {
                        Categoria miCategoria = ExisteCategoria(nombreCategoria);
                        if (miCategoria != null)
                        {
                        //creamos la instancia
                        Actividad miActividad = new Actividad(nombre, fecha, miLugar, miCategoria, edadMinima, likes);
                        //guardamos en la lista
                        actividades.Add(miActividad);
                        }
                    }
                }
            }
        }
        public string ListarActividades()
        {
            //Listar la totalidad de actividades disponibles para comprar por parte de un usuario
            string misActividades = "";
            for (int i = 0; i < actividades.Count; i++)
            {
                misActividades += actividades[i] + "\n";
            }

            if (misActividades == "")
            {
                misActividades = "No hay actividades para listar.";
            }

            return misActividades;
        }

        public string ModificarAforo(int nuevoAforo) // Este metodo es para modificar el aforo de lugares cerrado
        {
            string nuevoAforoBase = "";
            if (nuevoAforo > 0 && nuevoAforo<=100 && Cerrado.Aforo != nuevoAforo)
            {
                Cerrado.Aforo = nuevoAforo;
                nuevoAforoBase = "El nuevo aforo es " + Cerrado.Aforo + "% de la capacidad total. ";
                }
                else
                    {
                nuevoAforoBase = "El valor ingresado para el aforo no es un valor valido.";
                    }
            return nuevoAforoBase;
        }
        public string ModificarPrecioButaca(int nuevoPrecioButaca) // Este metodo es para modificar el precio de las butacas de lugares abierto
        {
            string nuevoPrecioButacaBase = "";
            if (nuevoPrecioButaca > 0 && Abierto.PrecioButaca != nuevoPrecioButaca)
            {
                Abierto.PrecioButaca = nuevoPrecioButaca;
                nuevoPrecioButacaBase = "El nuevo precio de butaca es: " + Abierto.PrecioButaca + ".";
            }
            else
                  {
                nuevoPrecioButacaBase = "El precio ingresado no es valor valido.";
                    }
            return nuevoPrecioButacaBase;
        }

      


        public string ListarActividadesParaTodoPublico()
        {
            //Listar la totalidad de actividades disponibles para todo publico
            string misActividadesParaTodoPublico = "";
            for (int i = 0; i < actividades.Count; i++)
            {
                if (actividades[i].EdadMinima=="P")
                {
                    misActividadesParaTodoPublico += actividades[i] + "\n";
                }
            }

            if (misActividadesParaTodoPublico == "")
            {
                misActividadesParaTodoPublico = "No hay actividades para listar.";
            }

            return misActividadesParaTodoPublico;
        }

        public string ListarCategorias()
        {
            string misCategorias = "";
            for (int i = 0; i < categorias.Count; i++)
            {
                if (categorias[i].Nombre != "")
                {
                    misCategorias += categorias[i] + "\n";
                }
            }


            return misCategorias;
        }

   
        public string ListarActividadesPorCategoriaYFecha(string categoriaSeleccionada, DateTime fechaDesde, DateTime fechaHasta) // listar actividades por categoria y fecha
        {
           
            string misActividadesPorCategoriaYFecha = "";
            fechaHasta = fechaHasta.AddDays(1);

            if (ExisteCategoria(categoriaSeleccionada) != null) // se detecta si la categoria ingresada existe dentro de categoria
            {
              
                for (int i = 0; i < actividades.Count; i++) // se recorre la lista de actividades y se compara con el nombre de actividad y tambien se compara si esta dentro de las fechas
                {
                         if (actividades[i].CategoriaNombre.ToUpper() == categoriaSeleccionada.ToUpper() && actividades[i].Fecha >= fechaDesde && actividades[i].Fecha < fechaHasta)
                         {
                            misActividadesPorCategoriaYFecha += actividades[i] + "\n";
                          }
                            
                }
                    if (misActividadesPorCategoriaYFecha == "")
                        {
                            misActividadesPorCategoriaYFecha = "No existe la categoria asignada en las actividades o en las fechas introducidas no hay actividades";
                        }
            }
            else
            {
                misActividadesPorCategoriaYFecha = "No existe categoria asignada";
            }

            return misActividadesPorCategoriaYFecha;
        }

    }
}
