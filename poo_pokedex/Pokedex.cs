using System;
using System.Collections.Generic;
using static System.Console;

namespace poo_pokedex
{
    public class Pokedex
    {
       public Pokedex(){
           this.IniciaLista();
       }
        private List<Pokemons> _Pokemon;
        public List<Pokemons> Pokemon
        {
            get { return _Pokemon; }
            
        }
        private void IniciaLista()
        {
            //instanciar "dar vida" a lista//
            //utiliza a propriedade para receber os valores
            this._Pokemon = new List<Pokemons>();
            
            /*Lista dos Pokemons*/
            // 1
            Pokemons Poke = new Pokemons("squirtle", "When it retracts its long neck into its shell, it squirts out water with vigorous force.");
            this._Pokemon.Add(Poke);
            //2
            Poke = new Pokemons("Charmarder", "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.");
            this._Pokemon.Add(Poke);
            //3           
            Poke = new Pokemons("Bulbasaur","There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger");
            this._Pokemon.Add(Poke);
            //4
            Poke = new Pokemons("Caterpie", "For protection, it releases a horrible stench from the antenna on its head to drive away enemies.");
            this._Pokemon.Add(Poke);
            //5
            Poke = new Pokemons("Weedle ","Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.");
            this._Pokemon.Add(Poke);
        }
        public void ListarPokemons(){
            for (int i = 0; i < this._Pokemon.Count; i++)
            {
               this.Pokemon[i].ExibirDadosPoke();
            }
        }
        
    }
}