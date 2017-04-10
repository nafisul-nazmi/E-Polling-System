using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.DAL;
using EPollingSystem.Models;

namespace EPollingSystem.BLL
{
    public class ResultGenerator
    {
        public static void GenerateResult()
        {
            DatabaseHandler.ObtainedSeatsReset();
            List<Seats> lSeats = DatabaseHandler.GetAllSeats();
            foreach(Seats seat in lSeats)
            {
                int winnerTeamId = DatabaseHandler.GetMaxVotedTeam(seat.SeatId);
                DatabaseHandler.UpdateObtainedSeats(winnerTeamId);
            }
        }
    }
}
