using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPollingSystem.Models
{
    public class Candidates
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public int SeatId { get; set; }
        public int TeamId { get; set; }
        public int ObtainedVotes { get; set; }
    }
}
