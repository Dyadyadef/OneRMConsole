using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OneRMConsole.Model
{
    public class Calculate
    {
        /// <summary>
        /// Формула Эпли (Epley)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double Epley(double M, int k)
        {
            return ((M * k) / 30.0 + M);
        }
        /// <summary>
        /// Формула Мэтта Бжицки (Matt Brzycki)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double MattBrzycki(double M, int k)
        {
            return (M * (36.0 / (37.0 - k)));
        }

        /// <summary>
        /// Формула Лэндера (Lander)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double Lander(double M, int k)
        {
            return ((100.0 * M) / (101.3 - 2.67123 * k));
        }
        /// <summary>
        /// Формула О Коннор (O Conner)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double OConner(double M, int k)
        {
            return (M * (1 + 0.025 * k));
        }
        /// <summary>
        /// Формула Ломбарди (Lombardi)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double Lombardi(double M, int k)
        {
            return (M * Math.Pow(k, 0.1));
        }
        /// <summary>
        /// Формула Мэйхью (Mayhew)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double Mayhew(double M, int k)
        {
            return ((100 * M) / (52.2 + 41.9 * Math.Exp(-0.055 * k)));
        }
        /// <summary>
        /// Формула Ватана (Wathan)
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns></returns>
        private double Wathan(double M, int k)
        {
            return ((100 * M) / (48.8 + 53.8*Math.Exp(-0.075*k)));
        }

        /// <summary>
        /// Рассчет среднего арифметического массива double
        /// </summary>
        /// <param name="arr">Массив double</param>
        /// <returns></returns>
        private double averageArray(double[] arr)
        {
            double average = 0;
            if (arr.Length > 0)
            {
                double sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    sum += arr[j];
                }
                average = sum / arr.Length;
            }
            else
            {
                return -1;
            }
            return average;
        }
        /// <summary>
        /// Рассчет жима штанги лежа
        /// </summary>
        /// <param name="M">Вес штанги</param>
        /// <param name="k">Количество повторений с данным весом</param>
        /// <returns>Список результатов рассчетов по формулам.
        /// (Первый элемент - среднее значение)
        /// </returns>
        public Dictionary<string, double> calculateBenchPress(double M, int k)
        {
            double epley = 0;
            double mattBrzycki = 0;
            double lander = 0;
            double oConner = 0;
            double average = 0;
            double lombardi = 0;
            double mayhew = 0;
            double wathan = 0;

            epley = Math.Round(Epley(M, k), 2);
            mattBrzycki = Math.Round(MattBrzycki(M, k), 2);
            lander = Math.Round(Lander(M, k), 2);
            oConner = Math.Round(OConner(M, k), 2);
            lombardi = Math.Round(Lombardi(M, k), 2);
            mayhew = Math.Round(Mayhew(M, k), 2);
            wathan = Math.Round(Wathan(M, k), 2);

            average = Convert.ToInt32(averageArray(new double[] { epley, mattBrzycki, lander, oConner, lombardi, mayhew, wathan }));
            
            Dictionary<string, double> result = new Dictionary<string, double>();
            result.Add("Average", average);
            result.Add("Epley", epley);
            result.Add("Matt Brzycki", mattBrzycki);
            result.Add("Lander", lander);
            result.Add("O Conner", oConner);
            result.Add("Lombardi", lombardi);
            result.Add("Mayhew", mayhew);
            result.Add("Wathan", wathan);
            return result;
        }
            
    }
}
