using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FairManagementSystemApp1.Model;
using FairManagementSystemApp1.UI;

namespace FairManagementSystemApp1.DAL
{
    class ZoneTypeGateway
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public int Save(ZoneClass aZoneClass)
        {
            SqlConnection connection = new SqlConnection(conString);

            string query = "INSERT INTO tbl_zoneType VALUES ('" + aZoneClass.visitorZoneId+"','"+ aZoneClass.zoneType+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public List<ZoneClass> LoadAllZoneType()
        {
            SqlConnection connection = new SqlConnection(conString);

            string query = "SELECT zoneType FROM tbl_zoneType";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<ZoneClass> aZoneClasses = new List<ZoneClass>();

            while (reader.Read())
            {
                ZoneClass aZoneClass = new ZoneClass();
                aZoneClass.zoneType = reader["zoneType"].ToString();

                aZoneClasses.Add(aZoneClass);
            }
            reader.Close();
            connection.Close();

            return aZoneClasses;
        }
    }

}
