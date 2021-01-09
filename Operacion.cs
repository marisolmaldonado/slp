using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public abstract class Operacion
    {
        public double OperadorUno { get; set; }
        public double OperadorDos { get; set; }
        public abstract double Calcular();
    }

    public class OperacionSumar : Operacion
    {
        public override double Calcular()
        {
            double result = this.OperadorDos + this.OperadorDos;
            return result;
        }
    }

    public class OperacionRestar : Operacion
    {
        public override double Calcular()
        {
            double result = this.OperadorDos - this.OperadorDos;
            return result;
        }
    }

    public class OperacionMultiplicar : Operacion
    {
        public override double Calcular()
        {
            double result = this.OperadorDos * this.OperadorDos;
            return result;
        }
    }

    public class OperacionDividir : Operacion
    {
        public override double Calcular()
        {
            double result = this.OperadorDos / this.OperadorDos;
            return result;
        }
    }

    public class Calculadora
    {
        public void Calcular(Operacion op)
        {
            double result = op.Calcular();
            Console.WriteLine("Resultado=" + result);
        }
    }

}
