﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için Temel Kurs";
            string kurs3 = "Java Kampı";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için Temel Kurs", "Java Kampı" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("*************************************************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
