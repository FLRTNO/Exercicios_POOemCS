using System;
using static System.Console;

namespace exercicio_maioridade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa usuario1;
            Pessoa usuario2;
            Pessoa usuario3;
            WriteLine("Determina qual usuario é mais velho.");
        
            //Instanciando a Pessoa 1
            usuario1 = new Pessoa();
            WriteLine("Nome usuario 1:");
            usuario1.Nome = ReadLine();
            WriteLine("Idade primeira pessoa");
            usuario1.Idade = int.Parse(ReadLine());

            // 2o usuario
            usuario2 = new Pessoa();
            WriteLine("Nome usuario 2");
            usuario2.Nome = ReadLine();
            WriteLine("Idade 2o usuario");
            usuario2.Idade = int.Parse(ReadLine());

            // 3o usuario
            WriteLine("Nome do terceiro usuario");
            string nome = ReadLine();
            WriteLine("Idade terceiro usuario");
            int idade = int.Parse(ReadLine());
            usuario3 = new Pessoa(nome, idade);

            //Aplicando a logica para saber qual usuario é mais velho
            if((usuario1.Idade > usuario2.Idade) && (usuario1.Idade>usuario3.Idade))
            {
                WriteLine("O usuario 1 é mais velho");
                usuario1.ExibirDados();
            } else if ((usuario2.Idade > usuario3.Idade) && (usuario2.Idade > usuario1.Idade))
            {
                WriteLine("O usuario mais velho é:");
                usuario2.ExibirDados();    
            } else if ((usuario3.Idade > usuario1.Idade) && (usuario3.Idade > usuario2.Idade))
            {
                WriteLine("O usuario mais velho é:");
                usuario3.ExibirDados();
            } else{
                WriteLine("Todos possuem a mesma idade");
            } 
            ReadKey();
        }
    }
}
