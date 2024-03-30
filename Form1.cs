

using Tribunal4;


namespace Tribunal4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            listBox1.Text = "Button Clicked"; // debug
            textBox1.Text = "Button Clicked"; // debug

            // event handler to make the sql call and populate listview
            myTribunalManager.ListTribunals();

            // now populate the result - as a test we only retrieve a single record into a text box (later to be a listview)

            CurrentReg.Text = myTribunalManager.getTribunalref();

        }

        // Create the manager class here
        TribunalManager myTribunalManager
            = new TribunalManager();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}