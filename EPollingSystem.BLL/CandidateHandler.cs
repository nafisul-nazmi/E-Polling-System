using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.Models;
using EPollingSystem.DAL;

namespace EPollingSystem.BLL
{
    public class CandidateHandler
    {
        public static List<ViewAbleCandidatesAdmin> GetViewAbleCandidatesAdmin(string seatName)
        {
            List<ViewAbleCandidatesAdmin> vCandidateAdmin = new List<ViewAbleCandidatesAdmin>();
            List<Candidates> candidates = DatabaseHandler.GetAllCandidates();
            List<Seats> lSeats = DatabaseHandler.GetAllSeats();
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            ViewAbleCandidatesAdmin vCanAd;
            int seatId = 0;
            foreach(Seats seat in lSeats)
            {
                if(seat.SeatName == seatName)
                {
                    seatId = seat.SeatId;
                    break;
                }
            }
            foreach(Candidates can in candidates)
            {
                if (can.SeatId == seatId)
                {
                    vCanAd = new ViewAbleCandidatesAdmin();
                    vCanAd.CandidateName = can.CandidateName;
                    vCanAd.SeatName = seatName;
                    foreach(Teams t in lTeam)
                    {
                        if(t.TeamId == can.TeamId)
                        {
                            vCanAd.TeamName = t.TeamName;
                            vCanAd.Symbol = t.Symbol;
                            break;
                        }
                    }
                    vCanAd.CandidateId = can.CandidateId;
                    vCanAd.ObtainedVotes = can.ObtainedVotes;
                    vCandidateAdmin.Add(vCanAd);
                }
            }
            return vCandidateAdmin;

        }
        public static List<ViewAbleCandidates> GetViewAbleCandidates(string seatName)
        {
            List<ViewAbleCandidates> vCandidate = new List<ViewAbleCandidates>();
            List<Candidates> candidates = DatabaseHandler.GetAllCandidates();
            List<Seats> lSeats = DatabaseHandler.GetAllSeats();
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            ViewAbleCandidates vCan;
            int seatId = 0;
            foreach (Seats seat in lSeats)
            {
                if (seat.SeatName == seatName)
                {
                    seatId = seat.SeatId;
                    break;
                }
            }
            foreach (Candidates can in candidates)
            {
                if (can.SeatId == seatId)
                {
                    vCan = new ViewAbleCandidatesAdmin();
                    vCan.CandidateName = can.CandidateName;
                    vCan.SeatName = seatName;
                    foreach (Teams t in lTeam)
                    {
                        if (t.TeamId == can.TeamId)
                        {
                            vCan.TeamName = t.TeamName;
                            vCan.Symbol = t.Symbol;
                            break;
                        }
                    }
                    vCan.CandidateId = can.CandidateId;
                    vCandidate.Add(vCan);
                }
            }
            return vCandidate;
        }
        public static bool AddCandidate(string candidateName, string seatName, string teamName)
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            List<Candidates> lCan = DatabaseHandler.GetAllCandidates();
            int seatId = 0;
            int teamId = 0;
            foreach(Seats seat in lSeat)
            {
                if(seat.SeatName == seatName)
                {
                    seatId = seat.SeatId;
                    break;
                }
            }
            foreach(Teams team in lTeam)
            {
                if(team.TeamName == teamName)
                {
                    teamId = team.TeamId;
                    break;
                }
            }
            foreach (Candidates can in lCan)
            {
                if (can.SeatId == seatId && can.TeamId == teamId)
                {
                    return false;
                }
            }
            DatabaseHandler.AddCandidate(candidateName, seatId, teamId);
            return true;

        }
        public static void DeleteCandidate(string candidateName, string seatName, string teamName)
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            List<Candidates> lCan = DatabaseHandler.GetAllCandidates();
            int seatId = 0;
            int teamId = 0;
            foreach (Seats seat in lSeat)
            {
                if (seat.SeatName == seatName)
                {
                    seatId = seat.SeatId;
                    break;
                }
            }
            foreach (Teams team in lTeam)
            {
                if (team.TeamName == teamName)
                {
                    teamId = team.TeamId;
                    break;
                }
            }
            foreach(Candidates can in lCan)
            {
                if(can.CandidateName == candidateName && can.TeamId == teamId && can.SeatId == seatId)
                {
                    DatabaseHandler.DeleteCandidate(can.CandidateId);
                    break;
                }
            }
            
        }
        public static List<ViewAbleCandidates> GetViewAbleCandidates(int seatId)
        {
            List<ViewAbleCandidates> vCandidate = new List<ViewAbleCandidates>();
            List<Candidates> candidates = DatabaseHandler.GetAllCandidates();
            List<Seats> lSeats = DatabaseHandler.GetAllSeats();
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            ViewAbleCandidates vCan;
            string seatName = "";
            foreach(Seats s in lSeats)
            {
                if(s.SeatId == seatId)
                {
                    seatName = s.SeatName;
                    break;
                }
            }
            
            foreach (Candidates can in candidates)
            {
                if (can.SeatId == seatId)
                {
                    vCan = new ViewAbleCandidatesAdmin();
                    vCan.CandidateName = can.CandidateName;
                    vCan.SeatName = seatName;
                    foreach (Teams t in lTeam)
                    {
                        if (t.TeamId == can.TeamId)
                        {
                            vCan.TeamName = t.TeamName;
                            vCan.Symbol = t.Symbol;
                            break;
                        }
                    }
                    vCan.CandidateId = can.CandidateId;
                    vCandidate.Add(vCan);
                }
            }
            return vCandidate;
        }
    }
}
