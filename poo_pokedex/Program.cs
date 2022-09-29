using System;
using System.Collections.Generic;
using static System.Console;

namespace poo_pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100; // deve receber um valor que seja diferente (!=) de zero para que possa entrar no loop
            while (resp != 0){
                resp = Menu(); 
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                    
                }
                
            }
            ReadKey();
            Clear(); // Console.clear() limpa a tela
         }

         static int Menu(){
            WriteLine("Pokedex: Agenda pokemon");
            WriteLine("0 - Sair da Pokedex");
            WriteLine("1 - Listar todos os Pokemons");
            Write("O que deseja fazer??");
            int resp = int.Parse(ReadLine());

            return resp;

         }

         
    }
}
