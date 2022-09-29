using System;
using static System.Console;

namespace calcular_area_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            WriteLine("Calcula a área do retangulo");
            WriteLine("Informe a Altura:");
            retangulo.ALtura = float.Parse(ReadLine());
            WriteLine("Informe a Base/Largura");
            retangulo.Base = float.Parse(ReadLine());
            retangulo.ExibirDados();
            ReadKey();
        }
    }
}
