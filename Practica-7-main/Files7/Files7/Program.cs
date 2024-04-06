using System;
using System.IO;
using System.Net.NetworkInformation;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            //try
            //{
            //    BinaryWriter fout = new BinaryWriter(new FileStream("binary.dat", FileMode.Create));
            //    int i, l =0;
            //    double d = 0, k;
            //    Console.WriteLine("средние температуры за каждый месяц года");
            //    for (i = 0; i < 36; i++)
            //    {
            //        l = Console.Read();
            //        fout.Write(l);
            //        Console.WriteLine(l);
            //    }
            //    fout.Close();
            //    Console.WriteLine();
            //    Console.WriteLine("Среднегодовая температура: \n");
            //    FileStream f = new FileStream("binary.dat", FileMode.Open);
            //    BinaryReader fin = new BinaryReader(f);
            //    double[] x1 = new double[12];
            //    int count = 0;
            //    //for (i = 0; i < x1.Length; i++)
            //    //{
            //    //    x1[i] = fin.ReadDouble();
            //    //    d += x1[i];
            //    //    count++;
            //    //}
            //    //k = d / count;
            //    //Console.WriteLine(d);
            //    //Console.WriteLine(k);
            //    //Console.WriteLine(count);
            //    try
            //    {
            //        while (true)
            //        {
            //            d += fin.ReadDouble(); // чтение из файла вещественных чисел
            //            i++;

            //        }
            //    }
            //    catch (Exception e)
            //    {

            //    }
            //    Console.WriteLine(d);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error end: " + e.Message);
            //    return;
            //}
            try
            {
                BinaryWriter fout = new BinaryWriter(new FileStream("binary.dat", FileMode.Create));
                double[] d = new double[12];
                double i = 1;
                double k = 1;
                double l = 0;
                while (i < d.Length)
                {
                    k += 0.5;
                    fout.Write(k);
                    i++;
                }
                fout.Close();
                i = 0;
                FileStream f = new FileStream("binary.dat", FileMode.Open);
                BinaryReader fin = new BinaryReader(f);
                try
                {
                    while (true)
                    {
                        l = fin.ReadDouble();     // чтение из файла вещественных чисел 
                    }
                }
                catch (EndOfStreamException e) { }
                fin.Close();
                f.Close();
                double p = 0, t = 0;
                fin = new BinaryReader(new FileStream("binary.dat", FileMode.Open));
                for (int j = 0; j < 10; j++)   // печать содержащихся в файле вещественных чисел
                {
                    l = fin.ReadDouble();
                    p += l;
                    Console.Write(l + " ");
                }
                Console.Write("\nСумма: " + p);
                t = p / 12;
                Console.Write("\nСр сумма: " + t);
                fin.Close();
                Console.WriteLine();
                fout = new BinaryWriter(new FileStream("binary.dat", FileMode.Append));
                fout.Write(t);   // запись в конец файла количества отрицательных элементов
                fout.Close();
                Console.WriteLine("i= " + i);
                
                i = fin.ReadInt32();   // считывание количества отрицательных элементов с конца файла
                Console.WriteLine();
                Console.WriteLine("negative = " + i);
                fin.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error end: " + e.Message);
                return;
            }
        }

    }
}
