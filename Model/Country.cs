using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.Model
{
    public class Country
    {
        [PrimaryKey,AutoIncrement]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
