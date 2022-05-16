using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MarketManagementSystem
{
    class DBConnect

    { //static String MyDBConStr = "Data Source=.\sqlexpress; Initial Catalog=AddressDb; Integrated Security=True";
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acikg\OneDrive\Belgeler\mymarketdb.mdf;Integrated Security=True;Connect Timeout=30
        private SqlConnection connection = new SqlConnection(@"Data Source =.\sqlexpress; Initial Catalog = marketdb; Integrated Security = True");
        
        public SqlConnection GetCon()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        
        public void CloseCon()
        {
            if (connection.State==System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
    
}
