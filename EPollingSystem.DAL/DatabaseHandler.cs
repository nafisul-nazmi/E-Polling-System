using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using EPollingSystem.Models;
using System.Data;

namespace EPollingSystem.DAL
{
    public class DatabaseHandler
    {
        //CHANGE THE CONNECTION STRING AS REQUIRED
        static string ConString = "User Id=nazmi;Password=nazmi;Data Source=localhost:1521/XE;"; 

        public static List<Districts> GetAllDistricts()
        {
            List<Districts> lDist = new List<Districts>();
            Districts dist;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from districts";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        dist = new Districts();
                        dist.DistrictId = reader.GetInt32(0);
                        dist.DistrictName = reader.GetString(1);
                        lDist.Add(dist);
                    }
                    conn.Close();
                }
            }
            return lDist;
        }
        public static void AddDistrict(string dname)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("insert into districts(districtname) values ('{0}')", dname);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void DeleteDistrict(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("delete from districts where DistrictId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static List<Teams> GetAllTeams()
        {
            List<Teams> lTeam = new List<Teams>();
            Teams team;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from teams";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        team = new Teams();
                        team.TeamId = reader.GetInt32(0);
                        team.TeamName = reader.GetString(1);
                        team.Symbol = reader.GetString(2);
                        team.ObtainedSeats = reader.GetInt32(3);
                        lTeam.Add(team);
                    }
                    conn.Close();
                }
            }
            return lTeam;

        }

        public static void AddTeam(string teamName, string symbol)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("insert into teams(TeamName, Symbol, ObtainedSeats) values ('{0}', '{1}', 0)", teamName, symbol);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void DeleteTeam(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("delete from teams where TeamId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static List<Seats> GetAllSeats()
        {
            List<Seats> lSeat = new List<Seats>();
            Seats seat;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from seats";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        seat = new Seats();
                        seat.SeatId = reader.GetInt32(0);
                        seat.SeatName = reader.GetString(1);
                        seat.DistrictId = reader.GetInt32(2);
                        lSeat.Add(seat);

                    }
                    conn.Close();
                }
            }
            return lSeat;

        }
        public static void AddSeat(string seatName, int distId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("insert into seats(SeatName, DistrictId) values ('{0}', {1})", seatName, distId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void DeleteSeat(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("delete from seats where SeatId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static List<Centers> GetAllCenters()
        {
            List<Centers> lCenter = new List<Centers>();
            Centers center;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from centers";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        center = new Centers();
                        center.CenterId = reader.GetInt32(0);
                        center.CenterName = reader.GetString(1);
                        center.AgentName = reader.GetString(2);
                        center.Password = reader.GetString(3);
                        center.SeatId = reader.GetInt32(4);
                        center.Status = reader.GetInt32(5);
                        lCenter.Add(center);

                    }
                    conn.Close();
                }
            }
            return lCenter;

        }
        public static void DeleteCenter(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("delete from centers where CenterId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void AddCenter(string centerName, string agentName, string password, int seatId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("insert into centers(CenterName, AgentName, Password, SeatId, Status) values('{0}', '{1}', '{2}', {3}, 0)", centerName, agentName, password, seatId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static List<Candidates> GetAllCandidates()
        {
            List<Candidates> lCandidate = new List<Candidates>();
            Candidates candidate;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from candidates";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        candidate = new Candidates();
                        candidate.CandidateId = reader.GetInt32(0);
                        candidate.CandidateName = reader.GetString(1);
                        candidate.SeatId = reader.GetInt32(2);
                        candidate.TeamId = reader.GetInt32(3);
                        candidate.ObtainedVotes = reader.GetInt32(4);
                        lCandidate.Add(candidate);

                    }
                    conn.Close();
                }
            }
            return lCandidate;

        }
        public static void AddCandidate(string candidateName, int seatId, int teamId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("insert into candidates(CandidateName, SeatId, TeamId, ObtainedVotes) values ('{0}', {1}, {2}, 0)", candidateName, seatId, teamId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void DeleteCandidate(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("delete from candidates where CandidateId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void BlockCenter(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("update centers set status = 2 where CenterId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void UnblockCenter(int id)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("update centers set status = 1 where CenterId = {0}", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static List<Voters> GetVoter(int centerId)
        {
            List<Voters> voters = new List<Voters>();
            Voters voter;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select * from voters where CenterId = {0}", centerId);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        voter = new Voters();
                        voter.NId = reader.GetInt64(0);
                        voter.CenterId = centerId;
                        voter.Status = reader.GetInt32(1);
                        voters.Add(voter);
                    }
                    conn.Close();
                }
            }
            return voters;

        }
        public static List<Voters> GetAllVoters()
        {
            List<Voters> voters = new List<Voters>();
            Voters voter;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select * from voters");
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        voter = new Voters();
                        voter.NId = reader.GetInt64(0);
                        
                        voter.Status = reader.GetInt32(1);
                        voter.CenterId = reader.GetInt32(2);
                        voters.Add(voter);
                    }
                    conn.Close();
                }
            }
            return voters;
        }
        public static void PermitVoter(long nid)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("update voters set status = 2 where Nid = {0}", nid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void Voted(long nid)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("update voters set status = 3 where Nid = {0}", nid);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static int GetSeatIdFromCenterId(int centerId)
        {
            int SeatId = 0;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select SeatId from Centers where CenterId = {0}", centerId);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                        SeatId = reader.GetInt32(0);
                    conn.Close();
                }
            }
            return SeatId;

        }
        public static int GetCenterId(int seatId, string centerName)
        {
            int CenterId = 0;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select CenterId from Centers where CenterName = '{0}' and SeatId = {1}", centerName, seatId);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        CenterId = reader.GetInt32(0);
                    conn.Close();
                }
            }
            return CenterId;
        }
        public static int GetSeatId(string seatName)
        {
            int SeatId = 0;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select SeatId from Seats where SeatName = '{0}'", seatName);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        SeatId = reader.GetInt32(0);
                    conn.Close();
                }
            }
            return SeatId;
        }
        public static void AddVoter(long nid, int centerId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("insert into voters(nId, status, centerId) values ({0}, 1, {1})", nid, centerId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void DeleteVoter(long nId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("delete from voters where NId = {0}", nId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static int GetCenterStatus(int centerId)
        {
            int status = 0;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select status from Centers where CenterId = '{0}'", centerId);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        status = reader.GetInt32(0);
                    conn.Close();
                }
            }
            return status;
        }
        public static void Vote(int candidateId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("update candidates set ObtainedVotes = ObtainedVotes + 1 where candidateId = {0}", candidateId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void StartElection()
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update Centers set status = 1";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void EndElection()
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update Centers set status = 0";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void ObtainedSeatsReset()
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update Teams set ObtainedSeats = 0";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static void UpdateObtainedSeats(int teamId)
        {
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("update Teams set ObtainedSeats = ObtainedSeats + 1 where TeamId = {0}", teamId);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public static int GetMaxVotedTeam(int seatId)
        {
            int teamId = 0;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    int maxVotes = GetMaxVotes(seatId);
                    if (maxVotes > 0)
                    {
                        cmd.CommandText = string.Format("select teamId from Candidates where SeatId = {0} and ObtainedVotes = {1}", seatId, maxVotes);
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                            teamId = reader.GetInt32(0);
                    }
                    else
                        teamId = 0;
                    conn.Close();
                }
            }
            return teamId;
        }
        public static int GetMaxVotes(int seatId)
        {
            int maxVotes = 0;
            using (OracleConnection conn = new OracleConnection(ConString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format("select max(ObtainedVotes) from Candidates where seatId = {0}", seatId);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                            maxVotes = reader.GetInt32(0);
                    }
                    catch(Exception ex)
                    {
                        maxVotes = 0;
                    }
                    conn.Close();
                }
            }
            return maxVotes;
        }
    }
}
