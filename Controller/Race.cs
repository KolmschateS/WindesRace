using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public class Race
    {
        public Track Track { get; set; }
        public List<IParticipant> Participants { get; set; }
        public DateTime StartTime { get; set; }

        private Random _random;

        private Dictionary<Section, SectionData> _positions;

        public Race(Track track, List<IParticipant> participants)
        {
            Track = track;
            Participants = participants;
            _random = new Random(DateTime.Now.Millisecond);
        }

        public SectionData GetSectionData(Section section)
        {
            return _positions[section];
        }

        public void RandomizeEquipement()
        {
            foreach (IParticipant participant in Participants)
            {
                participant.Equipement.Quality = _random.Next(0, 100);
                participant.Equipement.Performance = _random.Next(0, 100);
                participant.Equipement.Speed = _random.Next(0, 100);
            }
        }
    }
}
