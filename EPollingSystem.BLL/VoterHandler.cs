using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.DAL;
using EPollingSystem.Models;

namespace EPollingSystem.BLL
{
    public class VoterHandler
    {
        public static int CheckStatus(long NId)
        {
            List<Voters> voters = DatabaseHandler.GetVoter(LoginHandler.CenterId);
            foreach(Voters v in voters)
            {
                if(v.NId == NId)
                {
                    return v.Status;
                }
            }
            return 0;
        }
        public static bool Permit(long nid)
        {
            if(CheckStatus(nid) == 1)
            {
                DatabaseHandler.PermitVoter(nid);
                return true;
            }
            return false;
        }
        public static bool Voted(long nid)
        {
            int status = CheckStatus(nid);
            if(status == 2)
            {
                DatabaseHandler.Voted(nid);
                return true;
            }
            return false;
        }
        public static void Vote(int candidateId)
        {
            DatabaseHandler.Vote(candidateId);
        }
        public static bool AddVoter(long nId, string seatName, string centerName)
        {
            List<Voters> lVoters = DatabaseHandler.GetAllVoters();
            foreach(Voters voter in lVoters)
            {
                if (voter.NId == nId)
                    return false;
            }

            int seatId = DatabaseHandler.GetSeatId(seatName);
            int centerId = DatabaseHandler.GetCenterId(seatId, centerName);
            DatabaseHandler.AddVoter(nId, centerId);
            return true;

        }
        public static void DeleteVoter(long nid)
        {
            DatabaseHandler.DeleteVoter(nid);
        }
        public static List<Voters> GetVoters(string seatName, string centerName)
        {
            
            int seatId = DatabaseHandler.GetSeatId(seatName);
            int centerId = DatabaseHandler.GetCenterId(seatId, centerName);
            List<Voters> lVoter = DatabaseHandler.GetVoter(centerId);
            return lVoter;

        }
        
    }
}
