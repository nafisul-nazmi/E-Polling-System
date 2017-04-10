using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPollingSystem.Models;
using EPollingSystem.DAL;

namespace EPollingSystem.BLL
{
    public class DistrictHandler
    {
        public static List<ViewAbleDistricts> GetViewAbleDistricts()
        {
            List<Districts> lDist = DatabaseHandler.GetAllDistricts();
            List<ViewAbleDistricts> viewDistricts = new List<ViewAbleDistricts>();
            ViewAbleDistricts dist;
            foreach (Districts d in lDist)
            {
                dist = new ViewAbleDistricts();
                dist.DistrictName = d.DistrictName;
                viewDistricts.Add(dist);
            }
            return viewDistricts;
        }
        public static bool AddDistrict(string dname)
        {
            List<Districts> lDist = DatabaseHandler.GetAllDistricts();
            foreach(Districts d in lDist)
            {
                if (d.DistrictName == dname)
                    return false;
            }
            DatabaseHandler.AddDistrict(dname);
            return true;
            
        }
        public static void DeleteDistrict(string dname)
        {
            List<Districts> lDist = DatabaseHandler.GetAllDistricts();
            int id;
            foreach (Districts d in lDist)
            {
                if (d.DistrictName == dname)
                {
                    id = d.DistrictId;
                    DatabaseHandler.DeleteDistrict(id);
                    break;
                }
            }
        }
    }
}
