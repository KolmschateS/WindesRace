using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public String name { get; set; }
        public LinkedList<Section> Sections { get; set; }

        public Track(string name, LinkedList<Section> sections)
        {
            this.name = name;
            Sections = sections;
        }
    }
}
