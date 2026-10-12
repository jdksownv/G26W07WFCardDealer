using System.Xml.Linq;

namespace G26W07WFCardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e)
        {
            //Card1.Image = Properties.Resources.ace_of_clubs;
            //Card1.Image = Properties.Resources._10_of_clubs;

            String name = "3000_of_clubs";

            Card1.Image = Properties.Resources.ResourceManager
                .GetObject(name) as Image
                ?? Properties.Resources.red_joker;

        }
    }
}
