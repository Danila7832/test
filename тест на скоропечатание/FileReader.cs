using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace тест_на_скоропечатание
{
    internal class FileReader
    {
        private List<Record> records = new List<Record>();

        public FileReader(String filePath)
        {
            String fileText = File.ReadAllText(filePath);
            records = JsonConvert.DeserializeObject<List<Record>>(fileText);
        }

        public List<Record> getRecorts()
        {
            return records;
        }
    }
}