using System;

namespace Array8523
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Çağıl";
            string student2 = "Leo";
            string student3 = "Angel";

            string[] students = new string[4];
            students[0] = "Çağıl";
            students[1] = "Leo";
            students[2] = "Angel";
            students[3] = "Muhittin";

            int[] numbers = new int[4]
            {
                1,2,3,4
            };
            int[] number = new[]
            {
                1,2,3,4
            };

            decimal[] decimals = new decimal[] { 1.1m, 2.2m };

            char[] characters = { 'A', 'b', 'i' };

            Console.WriteLine(students[0]);

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.Write("****");


            #region Multi Dimensional Arrays: Çok boyutlu diziler
            string[,] bolgelerVeSehirler = new string[3, 2];
            bolgelerVeSehirler[0, 0] = "Marmara";
            bolgelerVeSehirler[0, 1] = "Istanbul";
            bolgelerVeSehirler[1, 0] = "İç Anadolu";
            bolgelerVeSehirler[1, 1] = "Ankara";
            bolgelerVeSehirler[2, 0] = "Akdeniz";
            bolgelerVeSehirler[2, 1] = "Antalya";

            //foreach (var bolgeVeSehir in bolgelerVeSehirler)
            //{
            //    Console.WriteLine(bolgeVeSehir);

            //}

            BolgelerSehirYazdır(bolgelerVeSehirler);
            bolgelerVeSehirler = new string[2, 3] //2:0 , 3:1
            {
                {"Marmara", "İç Anadolu", "Akdeniz" },
                {"İstanbul","Ankara","Adana"}
                
            };
            BolgelerSehirYazdır(bolgelerVeSehirler);

            #endregion

            Console.ReadLine();
        }

        private static void BolgelerSehirYazdır(string[,] bolgelerVeSehirler)
        {
            for (int satir = 0; satir <= bolgelerVeSehirler.GetUpperBound(0); satir++)
            {
                for (int sutun = 0; sutun <= bolgelerVeSehirler.GetUpperBound(1); sutun++)
                {
                    Console.Write(bolgelerVeSehirler[satir, sutun] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
