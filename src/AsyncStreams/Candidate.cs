using System.Collections.Generic;

namespace AsyncStreams
{
    public class Candidate
    {
        public Candidate(string firstName, string lastname)
        {
            FirstName = firstName;
            LastName = lastname;
        }

        public Candidate(string firstName, string middleName, string lastname)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastname;
        }

        public Candidate(string firstName, string middleName, string lastname, List<int> apps)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastname;
            Applications = apps;
        }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public List<int> Applications { get; set; }

    }
}