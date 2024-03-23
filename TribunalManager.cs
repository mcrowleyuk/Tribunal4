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
            string connectionString = "server=(local);database=Tribunal;integrated Security=SSPI;";

            SqlConnection _con = new SqlConnection(connectionString);
            
            string queryStatement = "SELECT * FROM Tribunal.Registration";

            SqlCommand _cmd = new SqlCommand(queryStatement, _con);
            
            _con.Close();

            
            
            return false; // test only
        
        }
        public bool CreateNewTribunal() { 
        
            // establish a connection to sql server




            // insert the new record


            
            
            
            
            
            return false; }

        public bool SetR1Date() { return false; }

        public bool SetFinalEvidence() { return false; }

        public bool SetBundleDue() { return false; }




    //data


      //  private String TribunalReference("");
      //  private DateOnly r1Date;
       // private DateOnly hearingDate;

    }
}
