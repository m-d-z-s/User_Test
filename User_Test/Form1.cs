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

    public partial class Form1 : Form
    {
        internal List<User> users = new List<User>();
        int flag;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            string s = "";
            for(int i = 0; i < 5; i++)
            {
                s =s + Convert.ToString(Convert.ToChar(rnd.Next(97, 123)));
            }
            textBox3.Text = s;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < 8; i++)
            {
                flag = rnd.Next(0, 2);
                if (flag == 0)
                {
                    s = s + Convert.ToString(rnd.Next(0, 9));
                }
                else if (flag == 1)
                {
                    s = s + Convert.ToString(Convert.ToChar(rnd.Next(97, 123)));
                }
            }
            textBox3.Text = s;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                flag = rnd.Next(0, 3);
                if (flag == 0)
                {
                    s = s + Convert.ToString(rnd.Next(0, 9));
                }
                else if (flag == 1)
                {
                    s = s + Convert.ToString(Convert.ToChar(rnd.Next(97, 123)));
                }
                else if (flag == 2)
                {
                    s = s + Convert.ToString(Convert.ToChar(rnd.Next(65, 90)));
                }

            }
            textBox3.Text = s;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("data.txt",true);
            sw.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            sw.Close();
            
            users.Add(new User(textBox1.Text, textBox2.Text, textBox3.Text));
            //запись в массив
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
/*
 * класс user (name, login, pass, status(права доступа:администратор, пользователь))
 * конструктор класса
 */
