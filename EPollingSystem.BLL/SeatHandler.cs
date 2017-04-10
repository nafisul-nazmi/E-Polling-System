using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.Models;
using EPollingSystem.DAL;

namespace EPollingSystem.BLL
{
    public class SeatHandler
    {
        public static List<ViewAbleSeats> GetViewAbleSeats(string districtName)
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<Districts> lDist = DatabaseHandler.GetAllDistricts();
            int id = 0;
            foreach(Districts d in lDist)
            {
                if(d.DistrictName == districtName)
                {
                    id = d.DistrictId;
                    break;
                }
            }
            List<ViewAbleSeats> viewSeats = new List<ViewAbleSeats>();
            ViewAbleSeats seat;
            foreach(Seats s in lSeat)
            {
                if (s.DistrictId == id)
                {
                    seat = new ViewAbleSeats();
                    seat.SeatName = s.SeatName;
                    seat.DistrictName = districtName;
                    viewSeats.Add(seat);
                }
            }
            return viewSeats;

        }
        public static bool AddSeat(string seatName, string districtName)
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            foreach (Seats s in lSeat)
            {
                if (s.SeatName == seatName)
                    return false;
            }
            int districtId = 0;
            List<Districts> lDist = DatabaseHandler.GetAllDistricts();
            foreach(Districts d in lDist)
            {
                if(d.DistrictName == districtName)
                {
                    districtId = d.DistrictId;
                    break;
                }
            }
            DatabaseHandler.AddSeat(seatName, districtId);
            return true;
        }

        public static void DeleteSeat(string seatName)
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            int id;
            foreach (Seats s in lSeat)
            {
                if (s.SeatName == seatName)
                {
                    id = s.SeatId;
                    DatabaseHandler.DeleteSeat(id);
                    break;
                }
            }
        }
        public static List<ViewAbleSeats> GetAllViewAbleSeats()
        {
            List<Seats> lSeat = DatabaseHandler.GetAllSeats();
            List<Districts> lDist = DatabaseHandler.GetAllDistricts();
            
            
            List<ViewAbleSeats> viewSeats = new List<ViewAbleSeats>();
            ViewAbleSeats seat;
            foreach (Seats s in lSeat)
            {
                seat = new ViewAbleSeats();
                seat.SeatName = s.SeatName;
                foreach(Districts d in lDist)
                {
                    if(d.DistrictId == s.DistrictId)
                    {
                        seat.DistrictName = d.DistrictName;
                        break;
                    }
                }
                viewSeats.Add(seat);
                
            }
            return viewSeats;
        }
    }
}
