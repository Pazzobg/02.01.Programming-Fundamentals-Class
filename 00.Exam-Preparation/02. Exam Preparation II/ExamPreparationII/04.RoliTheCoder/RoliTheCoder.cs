namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var eventsAndParticipants = new SortedDictionary<string, Event>();

            var eventPattern = @"^(.+?) #(\w+)( (@\w+))*";
            var regex = new Regex(eventPattern);

            string line = Console.ReadLine();

            while (line != "Time for Code")
            {
                var match = regex.Match(line);
                if (!match.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                string[] input = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                string currentId = input[0];
                string currentName = input[1].TrimStart('#');

                var currentEvent = new Event
                {
                    ID = currentId,
                    Name = currentName,
                    Participants = new SortedSet<string>()
                };

                if (!eventsAndParticipants.ContainsKey(currentId))
                {
                    eventsAndParticipants[currentId] = currentEvent;
                    AddParticipants(eventsAndParticipants, input, currentId);
                }
                else if (eventsAndParticipants.ContainsKey(currentId)
                    && eventsAndParticipants[currentId].Name == currentName)
                {
                    AddParticipants(eventsAndParticipants, input, currentId);
                }

                line = Console.ReadLine();
            }

            foreach (var kvp in eventsAndParticipants
                .OrderByDescending(x => x.Value.Participants.Count)
                .ThenBy(x => x.Value.Name))
            {
                var eventObject = kvp.Value;

                Console.WriteLine($"{eventObject.Name} - {eventObject.Participants.Count}");

                foreach (var name in eventObject.Participants)
                {
                    Console.WriteLine(name);
                }
            }
        }

        private static void AddParticipants(SortedDictionary<string, Event> eventsAndParticipants, string[] input, string currentId)
        {
            for (int i = 2; i < input.Length; i++)
            {
                eventsAndParticipants[currentId].Participants.Add(input[i]);
            }
        }
    }
}
