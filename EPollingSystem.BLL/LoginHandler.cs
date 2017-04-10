using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.Models;
using EPollingSystem.DAL;

namespace EPollingSystem.BLL
{

    public class LoginHandler
    {
        public static int CenterId { get; set; }
        public static bool Verify(int centerId, string password)
        {
            List<Centers> lCenter = DatabaseHandler.GetAllCenters();
            foreach(Centers center in lCenter)
            {
                if(center.CenterId == centerId && center.Password == password)
                {
                    CenterId = centerId;
                    return true;
                }
            }
            return false;
        }
        public static void BlockCenter()
        {
            DatabaseHandler.BlockCenter(CenterId);
        }
    }
}
