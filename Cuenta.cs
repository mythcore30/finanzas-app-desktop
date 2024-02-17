using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp
{
    public class Cuenta
    {
        private int Id;
        private string Username;
        private string Password;
        private double Saldo;
        private Estado EstadoCliente;
        public List<Movimiento> MovimientosCuenta = new List<Movimiento>();

        public Cuenta()
        {
            EstadoCliente = Estado.NULL;
        }

        // Metodos get
        public int getId()
        {
            return Id;
        }

        public string getUsername()
        {
            return Username;
        }

        public string getPassword()
        {
            return Password;
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public Estado getEstadoCliente()
        {
            return EstadoCliente;
        }

        //Metodos set
        public void setId(int id)
        {
            this.Id = id;
            Id++;
        }

        public void setUsername(string username)
        {
            this.Username = username;
        }

        public void setPassword(string password)
        {
            this.Password = password;
        }

        public void setSaldo(double saldo)
        {
            this.Saldo = saldo;
        }

        public void setEstadoCliente(Estado estado)
        {
            this.EstadoCliente = estado;
        }


        // Metodos de clase
        public Movimiento NuevoMovimiento(double monto, TipoMovimiento tipo, string concepto)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Monto = monto;
            movimiento.Concepto = concepto;

            switch(tipo)
            {
                case TipoMovimiento.Ingreso:
                    movimiento.fecha = DateTime.Now;
                    setSaldo(getSaldo() + movimiento.Monto);
                    break;
                case TipoMovimiento.Egreso:
                    movimiento.fecha = DateTime.Now;
                    setSaldo(getSaldo() - movimiento.Monto);
                    break;
            }

            return movimiento;
        }

        public void GuardarMovimiento(Movimiento mov)
        {
            MovimientosCuenta.Add(mov);
        }
    }

    public enum Estado
    {
        SUPERAVIT,
        DEFICIT,
        EQUILIBRIO,
        NULL
    }
}
