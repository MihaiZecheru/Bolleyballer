using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bolleyballer
{
    public class Database
    {
        private SqlConnection conn { get; set; }

        public Database()
        {
            Connect();

            // make sure database exists
            if (!File.Exists("db.exists"))
            {
                string cmd =
                    "CREATE TABLE wins(" +
                    "name VARCHAR(30), " +
                    "score INT);";
                Execute(cmd);
                File.Create("db.exists");
            }
        }

        private void Connect()
        {
            conn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }

        public void Execute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
