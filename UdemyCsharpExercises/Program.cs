using System;
using System.Globalization;
using System.Collections.Generic;
namespace UdemyCsharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.Write("O curso B possui quantos alunos? ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");

            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.Write("O curso C possui quantos alunos? ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");

            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Resultado = new HashSet<int>();
            Resultado.UnionWith(A);
            Resultado.UnionWith(B);
            Resultado.UnionWith(C);

            Console.WriteLine("Total de alunos: " + Resultado.Count);
            Console.ReadLine();
        }
    }
}
