using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KoliZadacha
{
    class Automobile
    {
        public string brand;
        public string model;
        public DateTime date;
        public string colour;
        public double cost;
        public Automobile(string brand, string model, DateTime date, string colour, double cost)
        {
            this.brand = brand;
            this.model = model;
            this.date = date;
            this.colour = colour;
            this.cost = cost;
        }
    }
    class Program
    { static void SortDate(Automobile[] auto)
        {
            var sortAuto = auto.OrderByDescending(sorted => sorted.date.Year).ToArray();
            auto = sortAuto;
        }static double AverageCost(Automobile[] auto)
        {
            double average;
            average = TotalCost(auto) / auto.Length;
            return average;
        }
        static double TotalCost(Automobile[] auto)
        {
            double sum = 0;
            for (int i = 0; i < auto.Length; i++)
            {
                sum += auto[i].cost;
            }
            return sum;
        }
        static int Under50000(Automobile[] auto)
        {
            int count = 0;
            for (int i = 0; i < auto.Length; i++)
            {
                if (auto[i].cost < 50000)
                {
                    count++;
                }
            }
            return count;
        }
        
       
        static void Main(string[] args)
        {
            string brand, model, colour;
            double price;
            DateTime date;
            Automobile[] auto = new Automobile[50];
            for (int i = 0; i < auto.Length; i++)
            {
                Console.WriteLine($"Car #{i + 1}");
                Console.WriteLine("Enter type: ");
                brand = Console.ReadLine();
                Console.WriteLine("Enter model: ");
                model = Console.ReadLine();
                Console.WriteLine("Enter date: ");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter colour: ");
                colour = Console.ReadLine();
                Console.WriteLine("Enter cost: ");
                price = Convert.ToDouble(Console.ReadLine());
                auto[i] = new Automobile(brand, model, date, colour, price);
            }
            SortDate(auto);
            Console.WriteLine("Sum of cars prices: " + TotalCost(auto));
            Console.WriteLine("Cars under 50 000: " + Under50000(auto));
            Console.WriteLine("Average price of cars" + AverageCost(auto));
            Console.ReadKey();
        }
    }
}
