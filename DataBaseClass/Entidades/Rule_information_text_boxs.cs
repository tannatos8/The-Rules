using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseClass.Entidades
{
    public class Rule_information_text_boxs
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public string Constraints { get; set; }
        public string Field_names { get; set; }
        public string Table_names { get; set; }
        public string Action_taken { get; set; }
    }
}
