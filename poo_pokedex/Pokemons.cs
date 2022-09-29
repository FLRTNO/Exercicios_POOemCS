using System;
using System.Collections.Generic;
using static System.Console;

namespace poo_pokedex
{
    public class Pokemons
    {
        public Pokemons()
        {
            this.Nome = "";
            this.DescricaoPoke = "";
        }
        public Pokemons(String nome, String descricaoPoke)
        {
            this.Nome = nome;
            this.DescricaoPoke = descricaoPoke;
        }
        private String nome; 
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String descricaoPoke; //armazena o valor da propriedade descrição
        public String DescricaoPoke //método de acesso pois a propriedade é privada. Representa as caracteristicas da prop.
        {
            get { return descricaoPoke; }
            set { descricaoPoke = value; }
        }

        public void ExibirDadosPoke()
        {
            WriteLine($"Pokemon: {Nome}");
            WriteLine($"About: {DescricaoPoke.ToUpper()}");
        }

    }
}