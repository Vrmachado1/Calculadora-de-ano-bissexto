using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int Ainicial, Afinal, cont = 1;
            Ainicial = int.Parse(txtAinicial.Text);
            Afinal = int.Parse(txtAfinal.Text);
            while (Ainicial <= Afinal)
            {
                if (Ainicial % 4 == 0)
                {
                    lstAnos.Items.Add(Ainicial);
                    Ainicial++;
                }

                else
                {
                    Ainicial++;
                }
            }
          
        }
    }
}
