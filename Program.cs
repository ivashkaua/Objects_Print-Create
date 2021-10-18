using System;

namespace Object_Printer_upd
{
    using System.IO;

    class PrintText
    {
        
        public static string EnterPrintText_1()
        {
            string Text;
            Text = Console.ReadLine();
            return Text;
        }

    }

    class CreateFile
    {
        public static void CreateTXT()
        {

            using (StreamWriter outfile = new StreamWriter(@"C:\Users\ivan.melnyk\Desktop\Temp\temp.txt"))
            {

                //string Text1 = PrintText.EnterPrintText_1();
                outfile.Write(PrintText.EnterPrintText_1());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст, который необходимо вывести на экран:");
            Console.WriteLine("\n" + PrintText.EnterPrintText_1());
            CreateFile.CreateTXT();
            Console.WriteLine("Текстовый файл с текстом создан по адресу C:/Users/ivan.melnyk/Desktop/Temp/");
            Console.ReadLine();
        }
    }
}
