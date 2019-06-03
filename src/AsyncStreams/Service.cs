using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncStreams
{
    public class Service
    {
        public static IEnumerable<Candidate> GetCandidates()
        {
            var x = new[] {
                new Candidate("Lady", "Sansa", "Stark"),
                new Candidate("Knight", "Lady", "Brianne"),
                new Candidate("Denerys", "MotherOfDragons", "Targaryen"),
                new Candidate("Jon", "ThisIsMyQueen", "Snow"),
                new Candidate("Aria", "Stark")
            };

            for (int i = 0; i < 5; i++)
            {
                yield return x[i];
            }
        }
    }
}
