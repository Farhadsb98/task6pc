namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 10
            //Console.Write("Massivin uzunlugun daxil edin:");  
            //string struzun=Console.ReadLine();
            //bool tr=int.TryParse(struzun, out int uzunluq);
            //int[]mass=new int[uzunluq];
            //int enkicik = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"[{i + 1}]=");
            //    string strarray=Console.ReadLine();
            //    bool tru=int.TryParse(strarray, out int array);
            //    mass[i]=array;
            //    if (mass[i]<0)
            //    {
            //        if (enkicik > mass[i])
            //        {
            //            enkicik = mass[i];
            //        }
            //    }

            //}
            //Console.WriteLine(enkicik);
            #endregion

            #region task 11
            //Console.Write("Massivin uzunlugun daxil edin:");
            //string struzun = Console.ReadLine();
            //bool tr = int.TryParse(struzun, out int uzunluq);
            //int[] mass = new int[uzunluq];
            //Random random= new Random();
            //int enkicik = 0;
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"[{i + 1}]=");


            //    mass[i] = random.Next(0,101);
            //    Array.Sort(mass);
            //    Console.WriteLine(mass[i]);

            //}
            #endregion

            #region task 6
            l1:
            Console.Write("Massivin uzunlugun daxil edin:");
            string struzun = Console.ReadLine();
            bool tr = int.TryParse(struzun, out int uzunluq);
            if (!tr)
            {
                goto l1;
            }
            int[] mass = new int[uzunluq];

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"[{i + 1}]=");
                string strarray = Console.ReadLine();
                bool tru = int.TryParse(strarray, out int array);
                mass[i] = array;
            }
        l2:
            Console.Write("Massivin uzunlugun daxil edin:");
            string struzun1 = Console.ReadLine();
            bool tr1 = int.TryParse(struzun1, out int uzunluq1);
            if (!tr1)
            {
                goto l2;
            }
            int[] mass1 = new int[uzunluq1];
            for (int j = 0; j < mass1.Length; j++)
            {
                Console.Write($"[{j + 1}]=");
                string strarray = Console.ReadLine();
                bool tru = int.TryParse(strarray, out int array1);
                mass[j] = array1;
            }

            #endregion
        }
    }
}