using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Model;


namespace Controller {
    public static class Data
    {
        public static Competition Competition { get; set; }
        public static Race CurrentRace {get; set; }


        public static void Initialize() {
            Competition = new Competition();
            Participants();
            Tracks();
        }
        public static void Participants()
        {
            IEquipment car1 = new Car(60, 50, 79, false);
            IEquipment car2 = new Car(30, 78, 85, false);
            IEquipment car3 = new Car(50, 70, 82, false);

            Driver driver1 = new Driver("rijder1", 0, car1, TeamColors.Red);
            Driver driver2 = new Driver("rijder2", 0, car2, TeamColors.Red);
            Driver driver3 = new Driver("rijder3", 0, car3, TeamColors.Blue);

            Competition.Participants.Add(driver1);
            Competition.Participants.Add(driver2);
            Competition.Participants.Add(driver3);
        }
        public static void Tracks()
        {
            LinkedList<Section> sections = new LinkedList<Section>();
            Section straight = new Section();
            straight.SectionType = SectionTypes.Straight;

            sections.AddLast(straight);
            sections.AddLast(straight);
            sections.AddLast(straight);
            sections.AddLast(straight);

            Track amersfoort = new Track("Amersfoort", sections);

            Competition.Tracks.Enqueue(amersfoort);
        }

        public static void NextRace()
        {
            Track _nextTrack = Competition.NextTrack();
            if (_nextTrack != null)
            {
                CurrentRace = new Race(_nextTrack, Competition.Participants);
            }
        }

    }
}
