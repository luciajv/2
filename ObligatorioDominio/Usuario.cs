using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioDominio
{
    class Usuario
    {
        private int id;
        private static int ultimoId=1;
        private string nombre;
        private string apellido;
        private string email;
        private DateTime fechaDeNacimiento;
        public Usuario(string nombre, string apellido, string email, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = ultimoId;
            ultimoId++;
            this.email = email;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        
        public string Nombre
        {
            get { return this.nombre; }
        }

        public override string ToString()
        {
            return this.id +" - "+ this.nombre + " - " + this.apellido + " - " + this.email + " - " + this.fechaDeNacimiento;
        }
    }

}
