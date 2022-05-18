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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1(); 
        public Form2()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("data.txt");

            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                //string swt = str.Trim();
                string[] mas = str.Split();
                form1.users.Add(new User(name: mas[0], login: mas[1], password: mas[2]));
                //if (mas[1] == textBox5.Text)
                //{
                //    str.Replace(mas[0], mas);
                //    sw1 = new StreamWriter(textBox5.Text + " " + textBox4.Text);
                //    pass = textBox4.Text;
                //    mas[0].
                //    StreamWriter sw = new StreamWriter("data.txt", true);
                //    sw.WriteLine();
                //    break;

                //}


            }
            sr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(form1.users);
            form5.Show();
            this.Hide();
        }
    }
}
