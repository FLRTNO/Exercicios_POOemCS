using System;
using static System.Console;

namespace exercicio_cs_animal_estimacao
{
    public class Animal
    {
        private String nomeAnimal;
        public String NomeAnimal 
        {
            get { return nomeAnimal; }
            set { nomeAnimal = value.ToUpper(); }
        }
        
        private String tipoAnimal;
        public String TipoAnimal
        {
            //valores definidos:: aceitar apenas Gato - Cachorro - Peixe
            get { return tipoAnimal; }
            set 
            { 
                if (value == "Cachorro" || value=="Gato" || value=="Peixe")
            {
                tipoAnimal = value;
            } else{
                tipoAnimal = "Peixe"; 
                  } 
                 
            }
        }
        
    }
}