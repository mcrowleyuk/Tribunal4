using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Tribunal4
{
    internal class TribunalManager
    {

        public TribunalManager() {; }

        public bool ListTribunals() 
        {
            const string connectionString = "server=(local);database=Tribunal;integrated Security=SSPI;";

            const string queryStatement = "SELECT tribunal_ref FROM Tribunal.Registration";

            SqlConnection _con = new SqlConnection(connectionString);

            SqlCommand _cmd = new SqlCommand(queryStatement, _con);

            // extract the response and display in list view

            SqlDataReader reader = _cmd.ExecuteReader();

            while (reader.Read())
            {
                //Form1.CurrentReg.Text = reader.GetString(0);
            }
       

            //

            // close connection

            _con.Close();

            
            
            return false; // test only
        
        }
        public bool CreateNewTribunal() 
        {
            // establish a connection to sql server

            const string connectionString = "server=(local);database=Tribunal;integrated Security=SSPI;";

            SqlConnection _con = new SqlConnection(connectionString);

            // Insert new record


            //


            // close connection

            _con.Close();

            return false; // Test only
          }

        public bool SetR1Date() { return false; }

        public bool SetFinalEvidence() { return false; }

        public bool SetBundleDue() { return false; }


        private string TribunalReference;
        private DateOnly r1Date;
        private DateOnly hearingDate;

    }
}
