using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Соответствие номера из таблицы Unicode символу
            //for (int i = 0; i < 256; i++)
            //Console.WriteLine($"Код {i} соответсвует символу {(char)i}");

            //Задача 2.Дан символ.Вывести его код   
            //Console.Write("Введите символ: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символ: {ch} - код: {(int)ch}") ;

            //Задача 3.Дан символ.Вывести символ, который в кодовой таблице ASCII следует за этим символом
            //Console.Write("Введите символ: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символ: {(char)(int)(ch+1)}");

            //Дан символ. Вывести два символа, стоящие перед ним в кодовой таблице ASCII
            //Console.Write("Введите символ: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символы: {(char)(int)(ch -1)} и {(char)(int)(ch - 2)}");

            // Дан символ. Вывести два символа, первый из которых предшествует введенному символу в кодовой таблице, а второй – следует после него
            //Console.Write("Введите символ: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символы: {(char)(int)(ch - 1)} и {(char)(int)(ch +1)}");

            //Задача 6.Дано название футбольного клуба.Напечатать его на экране «столбиком»
            //Console.WriteLine("Введите название футбольного клуба: ");
            //string name = Convert.ToString(Console.ReadLine());
            //char[] omas = name.ToCharArray();
            //for (int i=0;i<omas.Length;i++)
            //{ Console.WriteLine(omas[i]); }

            //Задача 7.Составить программу, которая печатает заданное слово, начиная с последней буквы
            //Console.WriteLine("Введите слово: ");
            //string name = Console.ReadLine();
            //char[] omas = name.ToCharArray();
            //for (int i = name.Length-1; i >= 0; i--)
            //{ Console.WriteLine($"{omas[i]}"); }

            //Задача 8. Преобразовать символы в строке из строчных в прописные и обратно
            Console.Write("Введите строку:");
            string str = Console.ReadLine();
            char[] simvol = str.ToCharArray();
            for (int i = 0; i < simvol.Length; i++)
            {
                Console.Write(char.ToUpper(simvol[i]));
            }
            Console.WriteLine();
            for (int i = 0; i < simvol.Length; i++)
            {
                Console.Write(char.ToLower(simvol[i]));
            }
            Console.ReadKey();
        }
    }
}
