using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    interface IParticipant
    {
        string Name { get; set; }
        int Points { get; set; }
        IEquipment Equipement { get; set; }
        TeamColors TeamColor { get; set; }
    }

    enum TeamColors{
        Red,
        Green,
        Blue,
        Yellow,
        Grey
    }
}
