using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тест_на_скоропечатание
{
    public class FileSaver
    {

        public FileSaver(String filePath, List<Record> records) {
            String json = JsonConvert.SerializeObject(records);
            File.WriteAllText(filePath, json);
        }
    }
}
