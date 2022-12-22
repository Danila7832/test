using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тест_на_скоропечатание
{
    public class Record
    {
        string name;
        double sek;
        double min;
        int errorCount;

        public Record(string name, double sek, double min, int errorCount)
        {
            this.name = name;
            this.sek = sek;
            this.min = min;
            this.errorCount = errorCount;
        }

        public string Name { get { return name; } }
        public double Sek { get { return sek; } }

        public double Min { get { return min; } }
        public int ErrorCount { get { return errorCount; } }
    }
}
