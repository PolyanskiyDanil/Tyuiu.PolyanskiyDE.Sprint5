using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PolyanskiyDE.Sprint5.Task0.V10.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint5.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 2;
            Console.Title = "Спринт #5 | Выполнил: Полянский Д. Э. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Полянский Данил Эдуардович | АСОиУБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вычислить его значение при x = 2, результат сохранить в текстовый файл  *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков      *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();

        }
    }
}
