using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationDashboard
{
    class MySqlClient
    {
        MySqlConnection m_Client = null;

        string m_IP;
        string m_DBName;
        string m_UserName;
        string m_Password;

        public MySqlClient(string ip, string userName, string password, string database)
        {
            m_IP = ip;
            m_DBName = database;
            m_UserName = userName;
            m_Password = password;

            string connectionString = "Server=" + m_IP + ";Database=" + m_DBName + ";Uid=" + m_UserName + ";Pwd=" + m_Password + ";";

            try
            {
                m_Client = new MySqlConnection(connectionString);
                m_Client.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Failed to connect to MySql server.\n\n" + e.Message, "Connection Falied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsConnected
        {
            get
            {
                if (m_Client != null && m_Client.State == System.Data.ConnectionState.Open)
                    return true;
                else
                    return false;
            }
        }

        public DataTable GetAllTests()
        {
            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM TestCases ORDER BY TestCaseName ASC";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }

        public string[] GetAllVersions()
        {
            List<string> versions = new List<string>();
            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM Versions ORDER BY ID ASC";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                versions.Add(dr["Name"].ToString());
            }
            return versions.ToArray();
        }

        public string[] GetAllBranches()
        {
            List<string> branches = new List<string>();
            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM Branches ORDER BY ID ASC";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                branches.Add(dr["Name"].ToString());
            }
            return branches.ToArray();
        }

        public Dictionary<DateTime, double> GetTestsCountByDate(string version, string branch, string node, string service, DateTime from, DateTime to)
        {
            Dictionary<DateTime, double> ret = new Dictionary<DateTime, double>();

            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM ExecutionStatistics WHERE StartTime>='" + from.ToString("yyyy-MM-dd")  + "' and StartTime<='" + to.ToString("yyyy-MM-dd") + "'";

            if (version != "All")
                cmd.CommandText += " and version='" + version + "'";

            if (branch != "All")
                cmd.CommandText += " and branch='" + branch + "'";

            if (node != "All")
                cmd.CommandText += " and threeNode=" + NodeAsInt(node);

            if (service != "All")
                cmd.CommandText += " and service='" + service + "'";

            cmd.CommandText += " ORDER BY StartTime ASC";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable executionsDT = new DataTable();
            adap.Fill(executionsDT);

            foreach (DataRow exec in executionsDT.Rows)
            {
                ret.Add((DateTime)exec["StartTime"], double.Parse(exec["Passed"].ToString()) + double.Parse(exec["Failed"].ToString()));
            }

            return ret;
        }

        public Dictionary<DateTime, List<double>> GetPassFailTestsCountByDate(string version, string branch, string node, string service, DateTime from, DateTime to)
        {
            Dictionary<DateTime, List<double>> ret = new Dictionary<DateTime, List<double>>();

            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM ExecutionStatistics WHERE StartTime>='" + from.ToString("yyyy-MM-dd") + "' and StartTime<='" + to.ToString("yyyy-MM-dd") + "'";

            if (version != "All")
                cmd.CommandText += " and version='" + version + "'";

            if (branch != "All")
                cmd.CommandText += " and branch='" + branch + "'";

            if (node != "All")
                cmd.CommandText += " and threeNode=" + NodeAsInt(node);

            if (service != "All")
                cmd.CommandText += " and service='" + service + "'";

            cmd.CommandText += " ORDER BY StartTime ASC";

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable executionsDT = new DataTable();
            adap.Fill(executionsDT);

            foreach (DataRow exec in executionsDT.Rows)
            {
                ret.Add((DateTime)exec["StartTime"], new List<double>() { double.Parse(exec["Passed"].ToString()), double.Parse(exec["Failed"].ToString()) });
            }

            return ret;
        }

        public int GetTestStatusCountByDate(string version, string branch, string node, string service, string testCaseID, string status, DateTime from, DateTime to)
        {
            int ret = 0;

            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT ID FROM ExecutionStatistics WHERE StartTime>='" + from.ToString("yyyy-MM-dd") + "' and StartTime<='" + to.ToString("yyyy-MM-dd") + "'";

            if (version != "All")
                cmd.CommandText += " and version='" + version + "'";

            if (branch != "All")
                cmd.CommandText += " and branch='" + branch + "'";

            if (node != "All")
                cmd.CommandText += " and threeNode=" + NodeAsInt(node);

            if (service != "All")
                cmd.CommandText += " and service='" + service + "'";

            cmd.CommandText += " ORDER BY StartTime ASC";

            List<string> executionIDs = new List<string>();
             
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable executionsDT = new DataTable();
            adap.Fill(executionsDT);

            foreach (DataRow exec in executionsDT.Rows)
            {
                executionIDs.Add(exec["ID"].ToString());
            }

            cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM TestCaseStatistics WHERE TestCaseID='" + testCaseID + "' and status ='" + status + "' ORDER BY StartTime ASC";
            adap = new MySqlDataAdapter(cmd);
            DataTable testsDT = new DataTable();
            adap.Fill(testsDT);

            foreach (DataRow exec in testsDT.Rows)
            {
                if (executionIDs.Contains(exec["ExecutionID"].ToString()))
                    ret++;
            }

            return ret;
        }

        public Dictionary<DateTime, string> GetTestCaseExecutionsByDate(string version, string branch, string node, string service, string testCaseID, DateTime from, DateTime to)
        {
            Dictionary<DateTime, string> ret = new Dictionary<DateTime, string>();

            MySqlCommand cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT ID FROM ExecutionStatistics WHERE StartTime>='" + from.ToString("yyyy-MM-dd") + "' and StartTime<='" + to.ToString("yyyy-MM-dd") + "'";

            if (version != "All")
                cmd.CommandText += " and version='" + version + "'";

            if (branch != "All")
                cmd.CommandText += " and branch='" + branch + "'";

            if (node != "All")
                cmd.CommandText += " and threeNode=" + NodeAsInt(node);

            if (service != "All")
                cmd.CommandText += " and service='" + service + "'";

            cmd.CommandText += " ORDER BY StartTime ASC";

            List<string> executionIDs = new List<string>();

            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable executionsDT = new DataTable();
            adap.Fill(executionsDT);

            foreach (DataRow exec in executionsDT.Rows)
            {
                executionIDs.Add(exec["ID"].ToString());
            }

            cmd = m_Client.CreateCommand();
            cmd.CommandText = "SELECT * FROM TestCaseStatistics WHERE TestCaseID='" + testCaseID + "' ORDER BY StartTime ASC";
            adap = new MySqlDataAdapter(cmd);
            DataTable testsDT = new DataTable();
            adap.Fill(testsDT);

            foreach (DataRow exec in testsDT.Rows)
            {
                if (executionIDs.Contains(exec["ExecutionID"].ToString()))
                    ret.Add((DateTime)exec["StartTime"], exec["Status"].ToString());
            }

            return ret;
        }

        private int NodeAsInt(string node)
        {
            if (node == "Single")
                return 0;
            else
                return 1;
        }
    }
}
