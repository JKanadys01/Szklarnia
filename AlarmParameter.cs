using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    internal class AlarmParameter
    {
        public int id;
        public int device_id;
        public string parameter;
        public int min_value;
        public int max_value;

        public AlarmParameter(int id, int device_id, string parameter, int min_value, int max_value)
        {
            this.id = id;
            this.device_id = device_id;
            this.parameter = parameter;
            this.min_value = min_value;
            this.max_value = max_value;
        }

        public override string ToString()
        {
            return $"ID: {id}\nDevice ID: {device_id}\nParameter: {parameter}\nMin value: {min_value}\nMax value: {max_value}\n";
        }

    }
}
