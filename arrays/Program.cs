
using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo a usar Array!");

            string[] Filmes = new string[4];
            int[] Ano = new int[4];
            //Criando os Arrays, usando NEW para um novo indice e [] para determinar numero de espaços 


            Filmes[0] = "Capitão América - O Primeiro Vingador";
            Filmes[1] = "Capitã Marvel";
            Filmes[2] = "Homem de Ferro";
            Filmes[3] = "O Incrível Hulk";

            Ano[0] = 1943;
            Ano[1] = 1995;
            Ano[2] = 2010;
            Ano[3] = 2011;

            //string concatenado com o array 
            Console.WriteLine("filme 1: " + Filmes[0]);
            Console.WriteLine("Ano que se passa: " + Ano[0]);
            Console.WriteLine("=======================================================)");

            Console.WriteLine("Filme 2: " + Filmes[1]);
            Console.WriteLine("Ano que se passa: " + Ano[1]);
            Console.WriteLine("=======================================================)");

            Console.WriteLine("Filme 3: " + Filmes[2]);
            Console.WriteLine("Ano que se passa: " + Ano[2]);
            Console.WriteLine("=======================================================)");

            Console.WriteLine("Filme 4: " + Filmes[3]);
            Console.WriteLine("Ano que se passa: " + Ano[3]);
            Console.WriteLine("=======================================================)");

        }
    }
}
