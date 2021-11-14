﻿using System;

namespace NewDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = new string[]
            {
                "Kıskanç mısın? (1: hayır, 2: evet)",
                "Aşk mı para mı? (1:para, 2: aşk)",
                "Kedi mi, köpek mi? (1:köpek, 2:kedi)",
                "Sosyete pazarından alışveriş yapar mısın?(1:evet, 2:hayır)",
                "Zeka mı, tip mi?(1:zeka, 2:tip)"
           };
            string[] cevaplar = new string[sorular.Length];
            for (int i = 0; i < sorular.Length; i++)
            {
                Console.Write(sorular[i] + " ");
                cevaplar[i] = Console.ReadLine();
            }
            int sonuc = 0;
            foreach (string cevap in cevaplar)
            {
                if (cevap == "1") 
                { 
                    sonuc = sonuc + 20;
                }
                
            }
            if (sonuc>70)
            {
                Console.WriteLine("Harika bir ilişkiniz olabilir");
            }
            else if(sonuc >= 30 && sonuc <= 70)
            {
                Console.WriteLine("İlişkiye bir şans verilebilir");
            }
            else
            {
                Console.WriteLine("Vazgeçsen bu ilişkiden iyi olur");
            }
            Console.ReadLine();
        }
    }
}
