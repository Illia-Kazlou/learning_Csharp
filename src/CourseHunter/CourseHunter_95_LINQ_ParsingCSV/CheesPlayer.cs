using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_95_LINQ_ParsingCSV
{
    public class CheesPlayer
    {
        public int Rank { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Country { get; set; }

        public int Rating { get; set; }

        public int Birthday { get; set; }

        public CheesPlayer()
        {

        }

        public static CheesPlayer ParseFideCSV(string line)
        {
            string[] parts = line.Split(';');
            var cheesPlayer = new CheesPlayer()
            {
                Rank = int.Parse(parts[0]),
                FirstName = parts[1].Split(" ")[1],
                LastName = parts[1].Split(" ")[0],
                Country = parts[3],
                Rating = int.Parse(parts[4]),
                Birthday = int.Parse(parts[6])
            };
            return cheesPlayer;
        }

        public override string ToString()
        {
            return $"Rank in world {Rank}\t " +
                    $"Full name {FirstName +" "+ LastName}\t " +
                    $"country: {Country}\t " +
                    $"rating: {Rating}\t " +
                    $"B-day: {Birthday}.";
        }
    }
}
