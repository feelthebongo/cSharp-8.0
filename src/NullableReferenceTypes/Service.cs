using System;
using System.Collections.Generic;
using System.Text;

namespace NullableReferenceTypes
{
    class Service
    {
        internal static IEnumerable<Candidate> GetCandidates()
        {
            return new[]
            {
                new Candidate("Lady", "Sansa","Stark"),
                new Candidate("Knight", "Lady","Brianne"),
                new Candidate("Denerys", "MotherOfDragons", "Targaryen"),
                new Candidate("Jon","ThisIsMyQueen" ,"Snow"),
                new Candidate("Aria","Stark"),
            };
        }
    }
}
