using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.Models;
using EPollingSystem.DAL;

namespace EPollingSystem.BLL
{
    public class TeamHandler
    {
        public static List<ViewAbleTeams> GetViewAbleTeams()
        {
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            List<ViewAbleTeams> viewTeams = new List<ViewAbleTeams>();
            ViewAbleTeams team;
            foreach(Teams t in lTeam)
            {
                team = new ViewAbleTeams();
                team.TeamName = t.TeamName;
                team.Symbol = t.Symbol;
                team.ObtainedSeats = t.ObtainedSeats;
                viewTeams.Add(team);
            }
            return viewTeams;
        }
        public static bool AddTeam(string teamName, string symbol)
        {
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            foreach(Teams t in lTeam)
            {
                if (t.TeamName == teamName || t.Symbol == symbol)
                    return false;
            }
            DatabaseHandler.AddTeam(teamName, symbol);
            return true;
        }

        public static void DeleteTeam(string teamName)
        {
            List<Teams> lTeam = DatabaseHandler.GetAllTeams();
            int id;
            foreach (Teams t in lTeam)
            {
                if (t.TeamName == teamName)
                {
                    id = t.TeamId;
                    DatabaseHandler.DeleteTeam(id);
                    break;
                }
            }
        }
        

    }
}
