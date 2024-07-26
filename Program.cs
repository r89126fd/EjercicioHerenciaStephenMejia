using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesHerencia operaciones = new OperacionesHerencia();
            operaciones.CalcularAreaCuadrado(4);
            operaciones.CalcularLongitudCircunferencia(5);
            operaciones.CalcularVolumenCubo(3);
            operaciones.Imprimir();
        }
    }

    class Operaciones
    {
        public double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double LongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double VolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }
    }

    class OperacionesHerencia : Operaciones
    {
        private double areaCuadrado;
        private double longitudCircunferencia;
        private double volumenCubo;

        public void CalcularAreaCuadrado(double lado)
        {
            areaCuadrado = AreaCuadrado(lado);
        }

        public void CalcularLongitudCircunferencia(double radio)
        {
            longitudCircunferencia = LongitudCircunferencia(radio);
        }

        public void CalcularVolumenCubo(double lado)
        {
            volumenCubo = VolumenCubo(lado);
        }

        public void Imprimir()
        {
            Console.WriteLine($"area del cuadrado: {areaCuadrado}");
            Console.WriteLine($"Longitud de la circunferencia: {longitudCircunferencia}");
            Console.WriteLine($"Volumen del cubo: {volumenCubo}");
        }
    }
}
