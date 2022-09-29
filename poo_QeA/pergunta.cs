using System;
using static System.Console;

namespace poo_QeA
{
    public class pergunta
    {
        //construtor
        public pergunta()
        {
            this.Texto = "";
            this.Resposta = "";
        }
        // sobrecarga

        public pergunta( String texto, String resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;


        }
        public String Texto { get; set; }
        public String Resposta { get; set; }

        
    }
}