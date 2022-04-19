using AdvancedLINQ.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQ.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Academy AcademyType { get; set; }
        

        public Subject(int id, string name, Academy academyType)
        {
            Id = id;
            Name = name;
            AcademyType = academyType;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
