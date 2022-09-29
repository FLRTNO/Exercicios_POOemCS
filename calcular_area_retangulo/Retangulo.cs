using static System.Console;
namespace calcular_area_retangulo
{
    public class Retangulo
    {
        //Construtor
        public Retangulo()
        {
            this.ALtura = 0;
            this.Base = 0;
        }
        
        //Base do retangulo
        private float _base;
        public float Base
        {
            get { return _base; }
            set 
            { 
               if(value >= 0) _base = value;
               else _base = 0; 
               }
        }
        // ALtura Retangulo
        private float _altura;
        public float ALtura
        {
            get { return _altura; }
            set { 
                if(value>=0) _altura = value; 
                else _altura = 0;
                }
        }

        public float Area 
        { 
            get {return _altura*_base;} //nao consegue receber nada apenas repassar o valor//
        }
        
        public void ExibirDados()
        {
            WriteLine($"Base:{this.Base}; Altura:{this.ALtura}; A Area será:{this.Area}");
        }
        
    }
}