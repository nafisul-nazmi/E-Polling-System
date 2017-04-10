using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.Models;
using EPollingSystem.DAL;

namespace EPollingSystem.BLL
{
    public class CenterHandler
    {
        public static List<ViewAbleCenters> GetViewAbleCenters(string seatName)
        {
            List<Centers> lCenter = DatabaseHandler.GetAllCenters();
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<ViewAbleCenters> viewCenter = new List<ViewAbleCenters>();
            ViewAbleCenters vCenter;
            int id = 0;
            foreach(Seats s in lSeat)
            {
                if(s.SeatName == seatName)
                {
                    id = s.SeatId;
                    break;
                }
            }

            foreach (Centers center in lCenter)
            {
                if (center.SeatId == id)
                {
                    vCenter = new ViewAbleCenters();
                    vCenter.CenterId = center.CenterId;
                    vCenter.CenterName = center.CenterName;
                    vCenter.AgentName = center.AgentName;
                    vCenter.Password = center.Password;
                    vCenter.SeatName = seatName;
                    vCenter.Status = center.Status;
                    viewCenter.Add(vCenter);
                }
            }
            return viewCenter;

        }
        public static List<ViewAbleCenters> GetViewAbleCenters()
        {
            List<Centers> lCenter = DatabaseHandler.GetAllCenters();
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<ViewAbleCenters> viewCenter = new List<ViewAbleCenters>();
            ViewAbleCenters vCenter;
            
            

            foreach (Centers center in lCenter)
            {
     
                vCenter = new ViewAbleCenters();
                vCenter.CenterId = center.CenterId;
                vCenter.CenterName = center.CenterName;
                vCenter.AgentName = center.AgentName;
                vCenter.Password = center.Password;
                foreach (Seats s in lSeat)
                {
                    if (s.SeatId == center.SeatId)
                    {
                        vCenter.SeatName = s.SeatName;
                        break;
                    }
                }
                vCenter.Status = center.Status;
                viewCenter.Add(vCenter);
            }
            
            return viewCenter;

        }
        public static List<ViewAbleCenters> GetBlockedCenters(string seatName)
        {
            List<ViewAbleCenters> viewCenter = GetViewAbleCenters(seatName);
            List<ViewAbleCenters> blockedCenters = new List<ViewAbleCenters>();
            foreach(ViewAbleCenters center in viewCenter)
            {
                if(center.Status == 2)
                {
                    blockedCenters.Add(center);
                }
            }
            return blockedCenters;
        }
        public static List<ViewAbleCenters> GetBlockedCenters()
        {
            List<ViewAbleCenters> viewCenter = GetViewAbleCenters();
            List<ViewAbleCenters> blockedCenters = new List<ViewAbleCenters>();
            foreach (ViewAbleCenters center in viewCenter)
            {
                if (center.Status == 2)
                {
                    blockedCenters.Add(center);
                }
            }
            return blockedCenters;
        }
        public static void DeleteCenter(int id)
        {
            DatabaseHandler.DeleteCenter(id);
        }
        public static bool AddCenter(string centerName, string agentName, string password, string seatName)
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<ViewAbleCenters> viewCenter = GetViewAbleCenters(seatName);
            int id = 0;
            foreach(ViewAbleCenters vCenter in viewCenter)
            {
                if (vCenter.CenterName == centerName)
                    return false;
            }
            foreach(Seats s in lSeat)
            {
                if(s.SeatName == seatName)
                {
                    id = s.SeatId;
                    break;
                }
            }
            DatabaseHandler.AddCenter(centerName, agentName, password, id);
            return true;

        }
        public static void UnblockCenter(int id)
        {
            DatabaseHandler.UnblockCenter(id);
        }
        public static int GetSeatId(int centerId)
        {
            return DatabaseHandler.GetSeatIdFromCenterId(centerId);
        }
        public static int GetCenterStatus(int centerId)
        {
            return DatabaseHandler.GetCenterStatus(centerId);
        }
        public static void StartElection()
        {
            DatabaseHandler.StartElection();
        }
        public static void EndElection()
        {
            DatabaseHandler.EndElection();
        }
    }
}
