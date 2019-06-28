using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            // if (File.Exists("asdsad")) 

            SaveFileDialog dlg = new SaveFileDialog();
            // dlg.InitialDirectory => Startordner für den Dialog
            dlg.Filter = "Textdokument|*.txt";//  Alles|*.*|Word-Datei|*.doc?  // ? = beliebiges Zeichen
            dlg.ShowDialog(); // Dialog wird angezeigt

            File.WriteAllText(dlg.FileName, textBox1.Text);
            File.SetCreationTime(dlg.FileName, new DateTime(1848, 3, 12, 14, 44, 59));


            MessageBox.Show("Datei wurde erfolgreich gespeichert !");

            // Verschlüsseln mit : System.Security.Cryptography
        }
    }
}
