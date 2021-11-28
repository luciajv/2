using System;
using System.Collections.Generic;
using System.Text;

namespace Practico2Dominio
{
   public  class Cuenta
    {
        private string titular;
        private string tipoCuenta;
        private string tipoMoneda;
        private double saldoCuenta;
        private int numeroCuenta;
        private int cantidadRetiros;

        public double SaldoCuenta
        {
            get { return this.saldoCuenta; }
        }
        public Cuenta(int numero, string titular, string tipoCuenta, string tipoMoneda)
        {
            this.numeroCuenta = numero;
            this.titular = titular;
            this.tipoCuenta = tipoCuenta;
            this.tipoMoneda = tipoMoneda;
        }
        public static bool ValidarTipoCuenta(string tipoCuenta)
        {
            return tipoCuenta == "CA" || tipoCuenta == "CC";
        }
        public static bool ValidarTipoMoneda(string tipoMoneda)
        {
            return tipoMoneda == "$" || tipoMoneda == "U$$";
        }
        public bool AgregarDeposito(double importe, string tipoMoneda)
        {
            bool deposito = false;
            if (this.tipoMoneda == tipoMoneda)
            {
                if((tipoMoneda=="$" && importe <= 50000) ||
                   (tipoMoneda == "U$S" && importe <=1000) )
                {//Si se cumplen las condiciones asociados a moneda y tope, modifica el valor del atributo saldoCuenta
                    this.saldoCuenta += importe;
                    deposito = true;
                }
               
            }
            return deposito;            
        }
        public bool AgregarRetiro(double importe, string tipoMoneda)
        {
            bool retiro = false;
            //Verifica si la moneda recibida es la misma que esta asociada a la cuenta
            if (this.tipoMoneda == tipoMoneda)
            {//Verifica si  la cantidad de retiros es mayor a 5 y si la moneda es pesos para sumar al importe de retiro, el importe de comisión
                if (cantidadRetiros > 5 && this.tipoMoneda == "$")
                {
                    importe += 50;
                }
                else if (cantidadRetiros > 5 && this.tipoMoneda == "U$S")
                {//Verifica si la cantidad de retiros es mayor a 5 y si la moneda es dólares para sumar el importe de retiro, el importe de comisión
                    importe += 1;
                }
                if (importe <= this.saldoCuenta)
                {//Modifica el valor del atributo saldoCuenta
                    this.saldoCuenta -= importe;
                    retiro = true;
                    cantidadRetiros++;
                }
            }
            return retiro;

        }
    }
}
