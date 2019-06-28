using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Welt aus Windows-Forms");

            // Zugriff auf ein Steuerelement geht über den Namen
            MessageBox.Show(textBox1.Text);

            // Unterschiedliche MessageBoxen:
            var result = MessageBox.Show("ACHTUNG !", "Mein Titel", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ; // logik ..
        }
    }
}
