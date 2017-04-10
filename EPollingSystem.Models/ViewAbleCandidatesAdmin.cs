using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPollingSystem.Models
{
    public class ViewAbleCandidatesAdmin : ViewAbleCandidates
    {
        public int ObtainedVotes { get; set; }
    }
}
