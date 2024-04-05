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
    public class TribunalManager
    {

        public TribunalManager() {; }

        public bool ListTribunals() 
        {
           

            //establish connection

            try
            {
                SqlConnection _con = new SqlConnection(connectionString);

                SqlCommand _cmd = new SqlCommand(queryStatement, _con);

                // extract the response and display in list view

                SqlDataReader reader = _cmd.ExecuteReader();

                while (reader.Read()) 
                {
                   TribunalReference = reader.GetString(0);// Tribunal Ref retrieved
                }


                // close connection

                _con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error establishing SQL Query: Error" + ex.GetType());
            }

            
            
            return false; // test only
        
        }
        public bool CreateNewTribunal(string strRef, string strLastName, string strFirstname)
        {
                    

            try
            {
                //establish connection

                SqlConnection _con = new SqlConnection(connectionString);


                // Insert new record


                SqlCommand _cmd = new SqlCommand(TribunalInsertStatement, _con);



                // close connection

                _con.Close();

                return true; // Test only
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error establishing SQL Query: Error" + ex.GetType());
            }
            return false;
        }


        public bool SetR1Date() { return false; } // to do

        public bool SetFinalEvidence() { return false; } // to do

        public bool SetBundleDue() { return false; } //to do

        public ref string getTribunalref() { return ref TribunalReference; }


        private string TribunalReference;
        private DateOnly r1Date;
        private DateOnly hearingDate;

        // const SQL statements

        //private const string TribunalInsertStatement = "Insert into Tribunal.dbo.Registration (tribunal_ref,last_name,first_name) " +
        //     "values (@strref, @strLastName, @strFirstname)";


        // MCC DEBUG - TO REPLACE WITH ABOVE LINE ON CHECK-IN
        private const string TribunalInsertStatement = "Insert into Tribunal.dbo.Registration (tribunal_ref,last_name,first_name) values ('A', 'B', 'C')";
        

        private const string queryStatement = "SELECT tribunal_ref FROM Tribunal.dbo.Registration";

        //private const string connectionString = "server=localhost\\SQLEXPRESS;Initial Catalog=Tribunal;integrated Security=true;";  //MCC DEBUG REF TO LOCAL HOSTNAME
        private const string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Tribunal;integrated Security=true;";  //MCC DEBUG REF TO LOCAL HOSTNAME
    }
}

