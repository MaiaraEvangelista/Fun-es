using System;

namespace Funçoes
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Fazer um programa que receba o nome de 10 alunos e quatro notas.  Mostre:
           A- média do aluno (Função)
           B- quantidade de aprovados (média >=7)
           C- quantidade de reprovados (média <7)
           D- média geral
           */

           //variaveis
           string[] nomes = new string[5];
           float[] medias = new float[5];
           float[] notas = new float[4];

           //estruturas de repetição

           //array.Length = tamanho
            

           for (int i = 0; i < nomes.Length; i++)
           {
               Console.WriteLine("Digite o nome: ");
               nomes[i] = Console.ReadLine();

               for (int n = 0; n < notas.Length; n++)
               {
                   Console.WriteLine("Digite a "+(n+1)+"° nota: ");
                   notas[n] = float.Parse(Console.ReadLine());
               }

               //medias calculadas
               medias[i] = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
           }

           foreach(string nome in nomes){
               Console.WriteLine(nome);
           }

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome: {nomes[i]} media: {medias[i]}");
            }
           
        }
    }
}
