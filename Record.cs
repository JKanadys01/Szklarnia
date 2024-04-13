using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    public class Record
    {
        public int id { get; set; }
        public double temperature { get; set; }
        
        public double humidity { get; set; }
        public DateTime date_time { get; set; }

        public Record() { id = 0; temperature = 0; humidity = 0; date_time = new DateTime(); }
        public Record(int id, double temperature, double humidity, DateTime date_time)
        {
            this.id = id;
            this.temperature = temperature;
            this.humidity = humidity;
            this.date_time = date_time;
        }

        public override string ToString()
        {
            return $"Id:{id}|temp:{temperature}|time:{date_time}\n";
        }
    }
}
