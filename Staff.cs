using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace IUL
{
    class Staff
    {
        public Staff(string surname, string workRole) 
        {
            _workRole = workRole;
            _surname = surname;
        }
        public Staff() 
        {
            _workRole = "Разработал";
            _surname = "Архипов";
        }
        private string _workRole;
        private string _surname;
        public string WorkRole 
        {
            get {   return _workRole;   }
            set {   _workRole = value;  }
        }
        public string Surname 
        {
            get {  return _surname; }
            set { _surname = value; }
        }
        public static List<Staff> GetStaffs() 
        {
            List<Staff> staffs = new List<Staff>(15);
            string querySelect = "SELECT Surname, Work_role FROM Staff;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection("18.117.109.19", "IUL"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querySelect, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    { 
                        while (reader.Read())
                        {
                            staffs.Add(new Staff(reader[0].ToString().Trim(), reader[1].ToString().Trim()));
                        }
                    }
                }
            }
            return staffs;
        }
        public static HashSet<string> GetFаield(string fаield)
        {
            HashSet<string> result = new HashSet<string>();
            string querySelect = "SELECT " + fаield + " FROM Staff;";
            using (SqlConnection connection = DbProviderFactories.GetDBConnection("18.117.109.19", "IUL"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querySelect, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(reader[0].ToString().Trim());
                        }
                    }
                }
            }
            return result;
        }
    }
}
