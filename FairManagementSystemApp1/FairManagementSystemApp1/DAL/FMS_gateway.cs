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
    class FMS_gateway
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public int Save(visitor aVisitor)
        {

            SqlConnection connection = new SqlConnection(conString);

            string query = "INSERT INTO visitor VALUES ('" + aVisitor.visitorName  + "','" + aVisitor.visitorEmail +
                           "','" + aVisitor.visitorCellNo + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public List<visitor> LoadAllVisitors()
        {
            SqlConnection connection = new SqlConnection(conString);
            string query = "SELECT visitorName,visitorEmail,visitorCellNo FROM visitor";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<visitor> visitorList = new List<visitor>();

            while (reader.Read())
            {
                visitor aVisitor = new visitor();

                aVisitor.visitorName = reader["visitorName"].ToString();
                aVisitor.visitorEmail = reader["visitorEmail"].ToString();
                aVisitor.visitorCellNo = int.Parse(reader["visitorCellNo"].ToString());

                visitorList.Add(aVisitor);
            }
            reader.Close();
            connection.Close();

            return visitorList;
        }

     }
}
