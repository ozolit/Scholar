using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.Model
{
    internal class PersonType
    {
        [PrimaryKey,AutoIncrement]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
