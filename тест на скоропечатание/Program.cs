using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using тест_на_скоропечатание;

internal class Program
{
    private static void Main()
    {
        List<Record> records = new List<Record>();
        SortedSet<double> sortedList = new SortedSet<double>();
        String filePath = "../../../records.json";
        ConsoleKeyInfo key;

        FileReader fr = new FileReader(filePath);
        records = fr.getRecorts();

        do
        {
            Console.Clear();
            Console.WriteLine("F1 - запустить тест");
            Console.WriteLine("esc - выход");

            Console.WriteLine("Таблица рекордов:");
            foreach (Record record in records)
            {
                sortedList.Add(record.Min);
            }
           
            int i = 1;
            foreach (double result in sortedList.Reverse())
            {
                foreach (Record record in records)
                {
                    if (record.Min == result) {
                        Console.WriteLine($"{i}. {record.Name} с результатом в минуту = {record.Min} и с результатом в секунду = {record.Sek} и с количеством ошибок = {record.ErrorCount}");
                    }
                }
                i++;
            }

            key = Console.ReadKey();
            if (ConsoleKey.F1.Equals(key.Key)) { 
                Test test = new Test();
                records.Add(test.start());
                Console.Clear();
            }

        } while (!key.Key.Equals(ConsoleKey.Escape)) ;

        new FileSaver(filePath, records);

    }
}










