using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingListProject.Models
{
    public class Player
    {
        public string FullName { get; set; }
        public int Number { get; set; }
        public PostPlayer TypeOfPlayer { get; set; }
    }
}
