using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_1109ex
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 11; i++)
                {
                    int multi;
                    multi = 2 * i;
                    listBox1.Items.Add(multi);
                    
                }

                for (int i = 0; i < 11; i++)
                {
                    int multi;
                    multi = 5 * i;
                    listBox2.Items.Add(multi);

                }

            }

            catch (Exception erro)
            {

                MessageBox.Show(erro.Message.ToString()); 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i=1; i <13; i++)
            {
                int multi;
                if (i % 3 == 0)
                {
                    listBox3.Items.Add("Tabuada do" + i);

                    for (int j = 1; j < 11; j++) 
                    {
                        multi = i * j;
                        listBox3.Items.Add(multi);
                    }


                }
                
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int[] num = new int[8];
            int[] par = new int[8];
            int[] impar = new int[8];

            try
            {
                int multi;
                for (int i = 0; i < 8; i++)
                {
                    num[i] = randNum.Next(-20, 20);
                    listBox6.Items.Add(num[i]);
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (num[i] > num[j])
                        {
                            multi = num[i];
                            num[i] = num[j];
                            num[j] = multi;
                        }

                    }
                }
                for (int i = 0; i < 8; i++)

                    {
                    if (num[i] % 2 == 0)
                    {
                        listBox4.Items.Add(num[i]);
                    }
                    if (num[i] %2 !=0)
                    {
                        listBox5.Items.Add(num[i]);
                    }

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message.ToString());
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
