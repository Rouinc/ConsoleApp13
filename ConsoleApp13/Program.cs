using System;

public class program
{
    public static void Main(string[] args)
    {
        int data;
        Console.WriteLine("Mau berapa data?");
        data = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i<= data; i++)
        {
            while (true)
            {
                Console.WriteLine(" Data ke " + i);
                Console.Write("NIM :");
                int nim = Convert.ToInt32(Console.ReadLine());
                Console.Write("NAMA:");
                string nama = Convert.ToString(Console.ReadLine());
                Console.Write("Jenis kelamin:");
                string jk = Convert.ToString(Console.ReadLine());
                Console.Write("Tahun masuk :");
                int thn = Convert.ToInt32(Console.ReadLine());
                Console.Write("Program studi :");
                string ps = Convert.ToString(Console.ReadLine());
                Console.Write("Kelas :");
                string kelas = Convert.ToString(Console.ReadLine());
             
            }
        }
    }
}