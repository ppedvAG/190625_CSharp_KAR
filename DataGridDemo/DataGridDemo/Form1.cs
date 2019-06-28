using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person[] personen = new Person[]
            {
                new Person{Vorname="Tom",Nachname="Ate"},
                new Person{Vorname="Anna",Nachname="Ate"},
                new Person{Vorname="Peter",Nachname="Ate"},
                new Person{Vorname="Franz",Nachname="Ate"}
            };
            dataGridView1.DataSource = personen;
        }
    }
}
