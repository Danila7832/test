using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тест_на_скоропечатание
{
    internal class Test
    {
        internal String name;
        internal double result;
        internal Record start() 
        {
            Stopwatch stopwatch = new Stopwatch();

            string text = "13 октября 1987 года было зафиксировано первое военное использование подготовленных дельфинов. " +
                            "Военно-морской флот США привлек морских млекопитающих на службу в Персидском заливе. Дельфины помогали " +
                            "очищать акваторию порта от мин. В Советском Союзе военные начали работать с дельфинами в 60-е годы ХХ века, " +
                            "после того как разведка донесла, что аналогичные опыты проводят американцы. В Севастополе подготовленные группы " +
                            "специалистов тренировали дельфинов, моржей, морских львов, тюленей и косатку. Морских животных призвали на военную " +
                            "службу из-за их природной сообразительности и уникальных сенсорных возможностей, позволяющих обнаружить противника на " +
                            "расстояниях и глубинах, недосягаемых для современной техники. Дельфины, например, были обучены брать в плен вражеских " +
                            "водолазов, различать типы подводных лодок по работе винтов, а также взрывать корабли.";
            int mistakesCount = 0;
            int i = 0;

            Console.Clear();

            Console.WriteLine("Напечатайте следующий текст:");
            Console.WriteLine(text);
            Console.WriteLine();

            
            
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
            }

            char c;
            stopwatch.Start();
            
            while (i <= text.Length - 1 && stopwatch.Elapsed.Minutes < 1)
            {
                c = Console.ReadKey(true).KeyChar;

                if (c == text[i])
                {
                    i++;
                    Console.Write(c);
                }
                else mistakesCount++;

            }

            stopwatch.Stop();

            double resultInSeconds = i / (stopwatch.Elapsed.Minutes * 60 + stopwatch.Elapsed.Seconds);
            result = resultInSeconds * 60;

            Console.WriteLine();
            Console.WriteLine($"Успех!!! ошибок: {mistakesCount}. Ваша скорость печати {result} символов в минуту ");

            do
            {
                Console.WriteLine("введите свое имя");

                name = Console.ReadLine();
            } while (name.Equals("")); 

            return new Record(name, resultInSeconds, result, mistakesCount);
        }
    }
}
