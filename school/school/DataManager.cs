using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    static class DataManager
    {
        private const string CONNECTION = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\documents\visual studio 2015\Projects\school\school\school.mdf;Integrated Security=True";

        public static  User FindUser(string mail, string password)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(CONNECTION);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM [dbo].[user] WHERE [dbo].[user].[mail]=n'" + mail + "' AND [dbo].[user].[pass]=n'" + password + "';", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                sqlconn.Close();

                if (dt.Rows.Count == 0)
                {
                    return null;
                }

                User user = new User((int)dt.Rows[0].ItemArray[0], (string)dt.Rows[0].ItemArray[1], (string)dt.Rows[0].ItemArray[2], (string)dt.Rows[0].ItemArray[3], (string)dt.Rows[0].ItemArray[4]);
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void AddUser(User user)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(CONNECTION);
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO user VALUES (NULL,'" + user.Nick + "', '" + user.Mail + "', '" + user.Password + "', '" + user.Type + "')", sqlconn);
                cmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            catch
            {

            }
        }
    }
}
