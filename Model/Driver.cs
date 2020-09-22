using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Driver : IParticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipement { get; set; }
        public TeamColors TeamColor { get; set; }

        public Driver(string name, int points, IEquipment equipement, TeamColors teamColor)
        {
            Name = name;
            Points = points;
            Equipement = equipement;
            TeamColor = teamColor;
        }
    }
}
