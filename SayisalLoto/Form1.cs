using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] loto = new int[6];

            Random r = new Random();
            loto[0] = Convert.ToInt32(Convert.ToInt32(r.Next(49) + 1));
            listBox1.Items.Add(loto[0]); //yazdırmak için

            for (int i= 1;  i<=5 ; i++)
            {
                loto[i] = Convert.ToInt32(Convert.ToInt32(r.Next(49) + 1));
                for (int j = 0; j <=(i-1); j++)
                {
                    if (loto[i]==loto[j]) //eşitse kuranın tekrar çekilmesi sağlanacak
                    {
                        loto[i] = Convert.ToInt32(Convert.ToInt32(r.Next(49) + 1));
                        j = j - 1;
                    }
                }

                listBox1.Items.Add(loto[i]); //her defasında değilde işlem bitince yazdırırız daha basit
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < listBox1.Items.Count; k++)

                //her bir değeri için
                for (int l = k + 1; l < listBox1.Items.Count; l++)
                {
                    if (Convert.ToInt32(listBox1.Items[k].ToString()) > Convert.ToInt32(listBox1.Items[l].ToString()))
                    {
                        int degis = Convert.ToInt32(listBox1.Items[k].ToString());
                        listBox1.Items[k] = listBox1.Items[l].ToString();
                        listBox1.Items[l] = degis;
                    }
                }
            
        }
    }}


