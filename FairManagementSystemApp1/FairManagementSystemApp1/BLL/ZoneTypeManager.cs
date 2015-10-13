using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApp1.DAL;
using FairManagementSystemApp1.Model;

namespace FairManagementSystemApp1.BLL
{
    class ZoneTypeManager
    {
        ZoneTypeGateway aZoneTypeGateway = new ZoneTypeGateway();

        public string Save(ZoneClass aZoneClass)
        {
           if (aZoneTypeGateway.Save(aZoneClass) > 0)
            {
                return "Added Successfully!";
            }
            else
            {
                return "Could Not Added!";
            }
        }
         
        public List<ZoneClass> LoadAllZoneType()
        {
            return aZoneTypeGateway.LoadAllZoneType();
        }
    }
}
