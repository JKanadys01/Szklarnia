using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse
{
    public class All_data
    {
        public List<Record> records { get; set; }
        public All_data() { records = new List<Record>(); }

        public void Add(Record record)
        {
            if (records.Count > 0 && records.Last().date_time < record.date_time)
            {
                records.Add(record);
            }
            else if (records.Count == 0)
            {
                records.Add(record);
            }


        }

        public Record Last_record()
        {
            if (records.Count > 0)
            {
                return records.Last();
            }
            else
            {
                // Jeśli lista jest pusta, zwróć null lub inną wartość oznaczającą brak rekordów
                return null;
            }
        }
    }





}
