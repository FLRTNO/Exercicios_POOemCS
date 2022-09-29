using static System.Console;

namespace exercicio_maioridade
{
    public class Pessoa
    {
       //Construtores
       public Pessoa()
       {
           this.Nome = "";
           this.Idade = 0;
       }

       public Pessoa(string nome, int idade)
       {
           this.Nome = nome;
           this.Idade = idade;
       }
       
       
       //Propriedades
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private int _Idade;
        public int Idade {
            get {return _Idade;}
            set 
            {
                if(value >= 0)
                {
                    _Idade = value;
                }
                else
                {
                    this._Idade = 0;
                }
            }
        }
        
        //Métodos-Função
        public void ExibirDados()
        {
            WriteLine($"Nome:{Nome}; Idade:{Idade}");
        }
    }
}