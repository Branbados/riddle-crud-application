using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace riddle_crud_application.Models
{
    public class Riddle
    {
        public int id { get; set; }
        public string RiddleQuestion { get; set; }
        public string RiddleAnswer { get; set; }
    }
}
