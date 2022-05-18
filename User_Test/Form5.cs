using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace User_Test
{
    public partial class Form5 : Form
    {
        public string pass;
        private List<User> users;
        public Form5()
        {
            InitializeComponent();
        }

        internal Form5(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("data.txt", false);
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].login == textBox5.Text && users[i].password != textBox4.Text)
                {
                    sw.WriteLine(users[i].name + " " + users[i].login + " " + textBox4.Text);
                }
                else
                {
                    sw.WriteLine(users[i].name + " " + users[i].login + " " + users[i].password);
                }
            }
            sw.Close();
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
