using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    internal class Device
    {
        public int id;
        public int serial_number;
        public int status;
        public String description;

        public Device(int id, int serial_number, int status, string description)
        {
            this.id = id;
            this.serial_number = serial_number;
            this.status = status;
            this.description = description;
        }
    }
}
