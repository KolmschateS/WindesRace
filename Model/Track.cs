using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Track
    {
        public String Name { get; set; }
        public LinkedList<Section> Sections { get; set; }

        public Track(string name, LinkedList<Section> sections)
        {
            this.Name = name;
            Sections = sections;
        }
        public Track(string name, SectionTypes[] _sectionTypes)
        {
            this.Name = name;
            Sections = GenerateTrack(_sectionTypes);
        }

        public LinkedList<Section> GenerateTrack(SectionTypes[] _sectionTypes)
        {
            LinkedList<Section> LLSection = new LinkedList<Section>();
            foreach (SectionTypes _sectionType in _sectionTypes)
            {
 /*Creates new section, then assigns that sectiontype to the section. The section gets added to the linkedlist.*/
                Section section = new Section();
                section.SectionType = _sectionType;
                LLSection.AddLast(section);
            }
            return LLSection;
        }
    }
}
