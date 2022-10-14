using System;

namespace Exercise_1
{
    class Program
    {
        //mendeklarasi array integer dengan ukuran 618
        private int[] a = new int[618];

        //Mendeklarasi variable integer untuk menyimpan banyaknya data pada array
        private int siti;

        //Method untuk menerima input
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimoan pada array 
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                siti = Int32.Parse(s);
                if (siti <= 618)
                    break;
                else Console.WriteLine("\nArray dapat mempunyai maksimal 618 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("=======================");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("=======================");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < siti; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("==============================");
            Console.WriteLine(" Element array telah tersusun ");
            Console.WriteLine("==============================");
            for (int SL = 0; SL < siti; SL++)
            {
                Console.WriteLine(a[SL]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < siti; i++)  //for n-1 passes
            {
                //Pada pass i, bandingkan n-1 elemen pertama dengan elemen selanjutnya
                for (int SL = 0; SL < siti - i; SL++)
                {
                    if (a[SL] > a[SL + 1]) //Jika elemen tidak dalam ukuran yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = a[SL];
                        a[SL] = a[SL + 1];
                        a[SL + 1] = temp;
                    }
                }
            }
        }
        static void Main(String[] args)
        {
            //Creating the object of the Bubbleshort class
            Program myList = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myList.read();

            //Pemanggilan fungsi untuk mengurutkan array 
            myList.BubbleSortArray();

            //Pemanggilan fungsi untuk menampilkan array yang tesusun
            myList.display();

            //Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
