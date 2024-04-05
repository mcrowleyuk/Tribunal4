

using System.CodeDom;
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

        private void button1_Click(object sender, EventArgs e)
        {


            listBox1.Text = "Button Clicked"; // debug

            // event handler to make the sql call and populate listview
            myTribunalManager.ListTribunals();

            // now populate the result - as a test we only retrieve a single record into a text box (later to be a listview)

            CurrentTribunal.Text = myTribunalManager.getTribunalref();

        }

        // Create the manager class here
        TribunalManager myTribunalManager
            = new TribunalManager();

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // MC consider any other close down steps prior to exit
            // SQL connections etc.

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

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

                myTribunalManager.CreateNewTribunal(NewTribunalNumber.Text,LastName.Text,Firstname.Text);

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
    }
}