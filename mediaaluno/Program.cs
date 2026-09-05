using System;

class URI
{

    static void Main(string[] args)
    {
        double n1, n2, n3, n4, md;

        Console.WriteLine("Programa para ler media de aluno baseada em suas quatro notas:\n");
        Console.WriteLine("Primeira nota:");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Segunda nota:");
        n2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Terceira nota:");
        n3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Quarta nota:");
        n4 = double.Parse(Console.ReadLine());


        md = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

        if (md >= 7.0)
        {
            Console.WriteLine($"Media: {md:F1}");
            Console.WriteLine("Aluno aprovado.");
        }
        else if (md < 5.0)
        {
            Console.WriteLine($"Media: {md:F1}");
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine($"Media: {md:F1}");
            Console.WriteLine("Aluno em exame.");

            Console.WriteLine("Digita a nota obtida em exame");
            double exame = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {exame:F1}");

            double md2 = (exame + md) / 2;
            if (md2 >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {md2:F1}");
        }
    }

}