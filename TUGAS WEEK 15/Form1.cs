using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGAS_WEEK_15
{
    public partial class Formsatu : Form
    {
        public Formsatu()
        {
            InitializeComponent();

        }

        public string[] datamakan = new string[100];
        public string[] dataminum = new string[100];
        int tambahmakan = 0;
        int tambahminum = 0;

        private void buttonInput_Click(object sender, EventArgs e)
        {
            
            if(listBoxKiri.Items.Contains(textBoxNamaItem.Text))
            {
                MessageBox.Show("Data sudah tersedia !");
            }
            else if (textBoxNamaItem.Text == "" )
            {
                MessageBox.Show("Lengkapi data terlebih dulu !");
            }
            else if(textBoxNamaItem.Text != "" && radioButtonMakanan.Checked == true )
            {
                listBoxKiri.Items.Add(datamakan[tambahmakan] = textBoxNamaItem.Text);
                textBoxNamaItem.Text = "";
                tambahmakan++;
                //textBoxNamaItem.Clear();
            }
            else if (textBoxNamaItem.Text != "" && radioButtonMinuman.Checked == true)
            {
                listBoxKiri.Items.Add(dataminum[tambahminum] = textBoxNamaItem.Text);
                textBoxNamaItem.Text = "";
                tambahminum++;
                //textBoxNamaItem.Clear();
            }
            else if(textBoxNamaItem.Text == "" && radioButtonMakanan.Checked == false && radioButtonMinuman.Checked == false )
            {
                MessageBox.Show("Lengkapi data terlebih dulu !");
            }
            

        }


        private void listBoxKiri_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

      

        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        private void buttonSalin_Click(object sender, EventArgs e)
        {
            //string salin = listBoxKiri.SelectedItem.ToString();
            //Clipboard.SetData(DataFormats.StringFormat, salin);
            //listBoxKanan.Items.Add(salin);
            //listBoxKiri.ClearSelected();

            foreach(var item in listBoxKiri.SelectedItems)
            {
                if(!listBoxKanan.Items.Contains(item))
                {
                    listBoxKanan.Items.Add(item);
                }
            }
            listBoxKiri.ClearSelected();

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if(listBoxKanan.SelectedIndex==-1)
            {
                listBoxKanan.Items.Clear();
            }
            else
            {
                for( int ab = listBoxKanan.SelectedItems.Count - 1;ab >= 0;ab-- )
                {
                    listBoxKanan.Items.Remove(listBoxKanan.SelectedItems[ab]);
                }
            }
            
            //else
            //{
            //    listBoxKanan.Items.Clear();
            //}
        }

        private void Formsatu_Load(object sender, EventArgs e)
        {
            //datamakan[0] = "Mie Instan";
            //datamakan[1] = "Telor";
            //datamakan[2] = "Roti";
            //datamakan[3] = "Keju";
            //datamakan[4] = "Daging Giling";
            //dataminum[0] = "Susu sapi";
            //dataminum[1] = "Kopi";
            //dataminum[2] = "Teh";
            //dataminum[3] = "Bir";
        }

        private void checkBoxMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMakanan.Checked == true)
            {
                for (int i = 0; i <= listBoxKiri.Items.Count; i++)
                {
                    listBoxKiri.SelectedItem = "Mie Instan";
                    listBoxKiri.SelectedItem = "Telor";
                    listBoxKiri.SelectedItem = "Roti";
                    listBoxKiri.SelectedItem = "Keju";
                    listBoxKiri.SelectedItem = "Daging Giling";

                    listBoxKiri.SelectedItem = datamakan[tambahmakan];

                }

            }
            else if(checkBoxMakanan.Checked == false)
            {
                listBoxKiri.ClearSelected();
            }
        }

        private void checkBoxMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinuman.Checked == true)
            {
                for (int i = 0; i <= listBoxKiri.Items.Count; i++)
                {
                    listBoxKiri.SelectedItem = "Kopi";
                    listBoxKiri.SelectedItem = "Susu Sapi";
                    listBoxKiri.SelectedItem = "Teh";
                    listBoxKiri.SelectedItem = "Bir";
                    listBoxKiri.SelectedItem = dataminum[tambahminum];

                }

            }
            else if (checkBoxMinuman.Checked == false)
            {
                listBoxKiri.ClearSelected();
            }
        }

        private void listBoxKanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBoxKanan.SelectedItems.Contains(0))
            //{
            //    listBoxKanan.Items.Clear();
            //}
            //else
            //{
            //    listBoxKanan.SelectedItems.Remove(listBoxKanan.SelectedItem);
            //}
        }
    }
} 
