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
        public float min_value;
        public float max_value;

        public AlarmParameter(int id, int device_id, string parameter, float min_value, float max_value)
        {
            this.id = id;
            this.device_id = device_id;
            this.parameter = parameter;
            this.min_value = min_value;
            this.max_value = max_value;
        }

        public override string ToString()
        {
            return $"\nID: {id}\nDevice ID: {device_id}\nParameter: {parameter}\nMin value: {min_value}\nMax value: {max_value}\n";
        }

    }
}
