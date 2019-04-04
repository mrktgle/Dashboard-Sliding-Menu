using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DashboardSlidingMenu
{
    class crudTools
    {
        MySqlConnection cn;
        private string connectionString;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adptr = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        public crudTools()
        {
            cn = new MySqlConnection(globalVariable.connectionString);
        }

        public void FillDataGrid(string sql, ref DataGridView dg)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                adptr = new MySqlDataAdapter(cmd);

                ds = new DataSet();
                adptr.Fill(ds);
                dg.DataSource = "";
                dg.DataSource = ds.Tables[0];
                dg.AutoResizeColumns();

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            cn.Close();
        }

        //call it everytime you have a query
        public void ExecuteQuery(string sql)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                cmd.ExecuteReader(); //executes sql
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            cn.Close();
        }
        public MySqlDataReader RetrieveRecords(string sql, ref MySqlDataReader reader)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                reader = cmd.ExecuteReader();
                return reader;


            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
                return null;
            }
        }


        public void CloseConnection()
        {
            cn.Close();
        }
    }
}
