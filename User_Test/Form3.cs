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
    public partial class Form3 : Form
    {
        public string user_name;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("ошибка");
            }

            else
            {
                StreamReader sr = new StreamReader("data.txt");
                bool flag = false;
                while(!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string [] mas = str.Split();
                    if (mas[1] == textBox5.Text && mas[2] == textBox4.Text)
                    {
                        flag = true;
                        user_name = mas[0];
                        //MessageBox.Show(user_name);
                        break;
                        
                    }
                    else if (mas[1] == textBox5.Text && mas[2] != textBox4.Text)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }



                }

                sr.Close();
                if (flag)
                {
                    Form4 form4 = new Form4(user_name);
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("reg");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
