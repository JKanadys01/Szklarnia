using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    internal class Alarm
    {
        public int id;
        public int alarm_parameter_id;
        public int record_id;

        public Alarm(int id, int alarm_parameter_id, int record_id)
        {
            this.id = id;
            this.alarm_parameter_id = alarm_parameter_id;
            this.record_id = record_id;
        }

        public override string ToString()
        {
            return $"ID: {id}\nAlarm parameter ID: {alarm_parameter_id}\nRecord Id: {record_id}\n";
        }

    }
}
