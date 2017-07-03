namespace _04.RoliTheCoder
{
    using System.Collections.Generic;

    public class Event
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public SortedSet<string> Participants { get; set; }
    }
}
