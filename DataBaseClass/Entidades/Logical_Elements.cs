using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseClass.Entidades
{
    public class Logical_Elements
    {
        public int Id { get; set; }
        public int Key_type { get; set; }
        public int Key_structure { get; set; }
        public int Uniqueness { get; set; }
        public int Null_support { get; set; }
        public int Values_entered_by { get; set; }
        public int Required_value { get; set; }
        public int Default_value { get; set; }
        public int Ranges_of_values { get; set; }
        public int Comparisons_allowed { get; set; }
        public int Operations_allowed { get; set; }
        public int Edit_rule { get; set; }
    }
}
