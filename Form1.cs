

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


            listBox1.Text = "Button Clicked";
            textBox1.Text = "Button Clicked";

            // make the sql call and populate listview
            myTribunalManager.ListTribunals();


        }

        // Create the manager class here
        TribunalManager myTribunalManager
            = new TribunalManager();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}