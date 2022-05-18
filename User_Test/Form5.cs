using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //public Form5(string[] user)
        //{
        //    InitializeComponent();

        //}
        internal Form5(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //    StreamReader sr = new StreamReader("data.txt");

            //    while (!sr.EndOfStream)
            //    {
            //        string str = sr.ReadLine();
            //        //string swt = str.Trim();
            //        //sw1.WriteLine(swt);
            //        string[] mas = str.Split();
            //        if (mas[1] == textBox5.Text)
            //        {
            //            //str.Replace(mas[0], mas);
            //            //sw1 = new StreamWriter(textBox5.Text + " " + textBox4.Text);
            //            pass = textBox4.Text;
            //            //mas[0].
            //            //StreamWriter sw = new StreamWriter("data.txt", true);
            //            //sw.WriteLine();
            //            break;

            //        }


            //    }
            //    sr.Close();
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
            this.Hide();
            
        }
    }
}
