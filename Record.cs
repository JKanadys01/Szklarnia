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
        public int serial_number;
        public double humidity { get; set; }
        public double insolation { get; set; }
        public DateTime date_time { get; set; }

        public Record() { id = 0; temperature = 0; humidity = 0; date_time = new DateTime(); }
        public Record(int id, double temperature, double humidity, DateTime date_time, int serial_number,double insolation)
        {
            this.id = id;
            this.temperature = temperature;
            this.humidity = humidity;
            this.date_time = date_time;
            this.serial_number = serial_number;
            this.insolation = insolation;
        }

        public override string ToString()
        {
            return $"\nId: {id}\nTemperature: {temperature}\nHumidity: {humidity}\nInsolation: {insolation}\ntime: " + date_time.ToString() + "\n\n";
        }
    }
}
