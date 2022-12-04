using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Items
{
    public class TODOItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool  IsFinished { get; set; }
        public DateTime Started { get; set; }
    }
}
