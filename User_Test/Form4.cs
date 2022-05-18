using System.Windows.Forms;

namespace User_Test
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(string user_name)
        {
            InitializeComponent();
            label1.Text = "Hi " + user_name;
        }
    }
}
