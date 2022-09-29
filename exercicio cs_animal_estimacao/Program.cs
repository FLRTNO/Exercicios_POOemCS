using System;
using static System.Console;

namespace exercicio_cs_animal_estimacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            WriteLine("CONTROLE DE ANIMAIS");
            // PRIMEIRO ANIMAL
            Write("Informe o nome do 1o Animal:");
            a1.NomeAnimal = ReadLine();
            WriteLine("Informe se seu animal é: Cachorro, Gato ou Peixe");
            a1.TipoAnimal = ReadLine();
            if(a1.TipoAnimal == "Cachorro") tlCachorro++;
            if(a1.TipoAnimal == "Gato") tlGato++;
            if(a1.TipoAnimal == "Peixe") tlPeixe++;

        // SEGUNDO ANIMAL
        Write("Informe o nome do 2o Animal:");
        a2.NomeAnimal = ReadLine();
        WriteLine("Informe se seu animal é: Cachorro, Gato ou Peixe");
        a2.TipoAnimal = ReadLine();
        if(a2.TipoAnimal == "Cachorro") tlCachorro++;
        if(a2.TipoAnimal == "Gato") tlGato++;
        if(a2.TipoAnimal == "Peixe") tlPeixe++;

        // TERCEIRO ANIMAL
        Write("Informe o nome do 3o Animal:");
        a3.NomeAnimal = ReadLine();
        WriteLine("Informe se seu animal é: Cachorro, Gato ou Peixe");
        a3.TipoAnimal = ReadLine();
        if(a3.TipoAnimal == "Cachorro") tlCachorro++;
        if(a3.TipoAnimal == "Gato") tlGato++;
        if(a3.TipoAnimal == "Peixe") tlPeixe++;

        // QUARTO ANMAL
        Write("Informe o nome do 4o Animal:");
        a4.NomeAnimal = ReadLine();
        WriteLine("Informe se seu animal é: Cachorro, Gato ou Peixe");
        a4.TipoAnimal = ReadLine();
        if(a4.TipoAnimal == "Cachorro") tlCachorro++;
        if(a4.TipoAnimal == "Gato") tlGato++;
        if(a4.TipoAnimal == "Peixe") tlPeixe++;

        // QUINTO ANIMAL
        Write("Informe o nome do 5o Animal:");
        a5.NomeAnimal = ReadLine();
        WriteLine("Informe se seu animal é: Cachorro, Gato ou Peixe");
        a5.TipoAnimal = ReadLine();
        if(a5.TipoAnimal == "Cachorro") tlCachorro++;
        if(a5.TipoAnimal == "Gato") tlGato++;
        if(a5.TipoAnimal == "Peixe") tlPeixe++;

        // RESULTADO
        WriteLine("Cachorros:" + tlCachorro + "Gatos:" + tlGato + "Peixes:" + tlPeixe);
        ReadKey();
        
        }
    }
}
