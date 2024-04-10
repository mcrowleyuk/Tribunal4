using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
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

        public bool ListTribunals(ref List<string> rstrListTribunals) 
        {
           

            //establish connection

            try
            {
                SqlConnection _con = new SqlConnection(connectionString);

                _con.Open();

                SqlCommand _cmd = new SqlCommand(queryStatement, _con);

                // extract the response and display in list view

                SqlDataReader reader = _cmd.ExecuteReader();

                while (reader.Read()) 
                {
                   TribunalReference = reader.GetString(0);// Tribunal Ref retrieved

                    rstrListTribunals.Add(TribunalReference);
                }

                return true;

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

                _con.Open();

                // Insert new record


                SqlCommand _cmd = new SqlCommand(TribunalInsertStatement, _con);

                _cmd.Parameters.AddWithValue("@strref", strRef);
                _cmd.Parameters.AddWithValue("@strLastName", strLastName);
                _cmd.Parameters.AddWithValue("@strFirstname", strFirstname);
               

                _cmd.ExecuteNonQuery();

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

        public bool SetFinalEvidence() { return false; } // to do

        public bool SetBundleDue() { return false; } //to do

        public ref string getTribunalref() { return ref TribunalReference; }

        public List<string> listTribunals;

        private string TribunalReference;
        private DateOnly r1Date { get; set; } = new DateOnly();
        private DateOnly hearingDate { get; set; } = new DateOnly();

        // const SQL statements

        private const string TribunalInsertStatement = "Insert into Tribunal.dbo.Registration (tribunal_ref,last_name,first_name) " +
             "values (@strref, @strLastName, @strFirstname)";


        private const string queryStatement = "SELECT tribunal_ref FROM Tribunal.dbo.Registration";

        // 06/04/2024 Correct Version
        private const string connectionString = "server=localhost\\SQLEXPRESS;Initial Catalog=Tribunal;integrated Security=true;TrustServerCertificate=True;";  //MCC DEBUG REF TO LOCAL HOSTNAME
        
    }
}

