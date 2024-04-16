

using System.CodeDom;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using Tribunal4;


namespace Tribunal4
{
    public partial class ExitApp : Form
    {
        public ExitApp()
        {
            InitializeComponent();
        }

        private void ListTribunalbutton1_Click(object sender, EventArgs e)
        {
            this.TribunalHelpMsg.Visible = true;

            // event handler to make the sql call and populate listview

            List<string> strListTribunals = new List<string>();

            //pass in a list which is then populated with the output from sql query
            bool bResult;

            bResult = myTribunalManager.ListTribunals(ref strListTribunals);

            // now populate the result - as a test we only retrieve a single record into a text box (later to be a listview)

            CurrentTribunal.Text = myTribunalManager.getTribunalref();

            // clear the ListView

            this.ListTribunals.Items.Clear();

            // now populate the full list with the query result

            if (bResult)
            {
                for (int i = 0; i < strListTribunals.Count; i++)

                    this.ListTribunals.Items.Add(strListTribunals[i]);
            }
        } // end button1_Click



        private void Form1_Load(object sender, EventArgs e)
        {
            this.TribunalHelpMsg.Visible = false;

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // MC consider any other close down steps prior to exit
            // SQL connections etc.



            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // refresh - MCC to do     
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // refresh - MCC to do   
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Add a tribunal prep
            // First check that the 3 mandatory fields are not null

            if ((this.NewTribunalNumber.Text != "") &&
               (this.LastName.Text != "") &&
               (this.Firstname.Text != ""))
            {
                // Tribunal Manager - add record call

                myTribunalManager.CreateNewTribunal(NewTribunalNumber.Text, LastName.Text, Firstname.Text);

                MessageBox.Show("Tribunal Record Added");

                this.NewTribunalNumber.Text = "ED555/024/XXX";
                this.LastName.Text = "";
                this.Firstname.Text = "";
            }
            else
            {

                MessageBox.Show("Error - Tribunal Ref, Lastname and Firstname must be populated");
            }

            //
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ListTribunals_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On a select item do nothing as yet
        }

        private void ListTribunals_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // On a double click do the following

            /* clear the list view
             * 
             *
             * 
             * 
             * Query the associated directions with this tribunal
             * 
             * 
             * Display each direction in the list view
             * 
             * 
             * 
             * */

            this.ListTribunals.Items.Clear();

            MessageBox.Show("List of associate court directions will be displayed in the listbox");

        }

        private void TribunalHelpMsg_Click(object sender, EventArgs e)
        {
            //TBA
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //TBA
        }


        // Create the manager class here
        private static TribunalManager myTribunalManager
            = new TribunalManager();
    }
}