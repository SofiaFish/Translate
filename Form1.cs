using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        List<string> english;
        List<List<string>> en_rus;
        List<List<string>> russ_en;
        List<string> russian;
        public Form1()
        {
            InitializeComponent();

            english = new List<string>();
            russian = new List<string>();
            en_rus = new List<List<string>>();
            russ_en = new List<List<string>>();


        }

        private void bAdd_Click(object sender, EventArgs e)
        {
         
            english.Add(tbEn.Text);
            russian.Add(tbRus.Text);
            cbEn.Items.Add(tbEn.Text);
            cbRus.Items.Add(tbRus.Text);
            tbEn.Clear();
            tbRus.Clear();

        }

        private void cbEn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbEn.Items.Clear();
            int index = cbEn.SelectedIndex;
            if (cbEn.SelectedIndex >-1)
            {
                if (cbEn.Items[index] == cbRus.Items[index])
                {
                    if (cbEn.Text == russian[index])
                    {
                        en_rus[index].Add(russian[index]);
                        lbEn.Items.Add(russian[index]);  
                    }
                }
            }
        }
    }
}
