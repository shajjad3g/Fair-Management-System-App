using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApp1.DAL;
using FairManagementSystemApp1.Model;

namespace FairManagementSystemApp1.BLL
{
    class FM_manager
    {
        FMS_gateway aFMSGateway = new FMS_gateway();

        public string Save(visitor aVisitor)
        {
           if (aFMSGateway.Save(aVisitor)>0)
            {
                return "Added Successfully!";
            }
            else
            {
                return "Could Not Added!";
            }
        }

        public List<visitor> LoadAllVisitors()
        {
            return aFMSGateway.LoadAllVisitors();
        }

       
    }
}
