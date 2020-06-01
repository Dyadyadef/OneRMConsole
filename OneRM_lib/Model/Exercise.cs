using System;
using System.Collections.Generic;
using OneRMConsole.Model;

namespace OneRMConsole.Model
{
    public class Exercise
    {
        private string Name { get; set; }
        private Dictionary<string, double> calculateData;
        public Exercise(string name)
        {
            Name = name;
        }
        public int calculate()
        {
            Calculate clc = new Calculate();
            Console.WriteLine("Введите вес штанги: ");
            double M = Convert.ToDouble(Console.ReadLine());
            // TODO проверка 
            Console.WriteLine("Введите количество повторений с данным весом: ");
            int k = Convert.ToInt32(Console.ReadLine());
            // TODO проверка 
            calculateData =  clc.calculateBenchPress(M, k);
            return 1;
        }
        public void showInfo()
        {
            if (calculateData.Count == 0)
            {
                Console.WriteLine("Список пуст!");
            }
            else
            {
                foreach (var element in calculateData)
                    Console.WriteLine("Формула {0} - {1}", element.Key, element.Value);
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
