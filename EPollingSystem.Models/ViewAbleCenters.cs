﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPollingSystem.Models
{
    public class ViewAbleCenters
    {
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public string AgentName { get; set; }
        public string Password { get; set; }
        public string SeatName { get; set; }
        public int Status { get; set; }
    }
}
