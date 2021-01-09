namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            OperacionSumar suma = new OperacionSumar
            {
                OperadorUno = 10,
                OperadorDos = 4
            };

            calc.Calcular(suma);


            OperacionRestar resta = new OperacionRestar
            {
                OperadorUno = 10,
                OperadorDos = 4
            };

            calc.Calcular(resta);

            OperacionMultiplicar multiplicacion = new OperacionMultiplicar
            {
                OperadorUno = 6,
                OperadorDos = 5
            };

            calc.Calcular(multiplicacion);


            OperacionDividir division = new OperacionDividir
            {
                OperadorUno = 6,
                OperadorDos = 5
            };

            calc.Calcular(division);
        }
    }
}
