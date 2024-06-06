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
        public AlarmParameter alarmParameter { get; set; }
        public Record alarmRecord { get; set; }
        public Alarm(int id, int alarm_parameter_id, int record_id, AlarmParameter alarmParameter, Record alarmRecord)
        {
            this.id = id;
            this.alarm_parameter_id = alarm_parameter_id;
            this.record_id = record_id;
            this.alarmParameter = alarmParameter;
            this.alarmRecord = alarmRecord;
        }

        public override string ToString()
        {
            return $"Alarm ID: {id}\nAlarm Parameters: "+alarmParameter.ToString() + "Alarm Record" +alarmRecord.ToString() ;
        }
    }
}
