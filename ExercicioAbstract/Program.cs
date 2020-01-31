using ExercicioAbstract.Entitites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxes> list = new List<Taxes>();
            Console.Write("Enter the number of tax payers: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company(i / c) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    Console.Write("Number of employees ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
                else
                {
                    Console.Write("Health expenditures ");
                    double health = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, health));
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totaltaxes = 0;

            foreach (Taxes tax in list)
            {
                totaltaxes += tax.Calculo();
                Console.WriteLine(tax.Name + ": $ " + tax.Calculo().ToString("F2"), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("TAXES PAID: $ ");
            Console.WriteLine(totaltaxes.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
