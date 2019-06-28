using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HalloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonKlickMich_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Welt aus Windows-Forms");

            // Zugriff auf ein Steuerelement geht über den Namen
            MessageBox.Show(textBox1.Text);

            // Unterschiedliche MessageBoxen:
            var result = MessageBox.Show("ACHTUNG !", "Mein Titel", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ; // logik ..
        }

        private void ButtonTextSpeichern_Click(object sender, EventArgs e)
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

        private void ButtonPersonSpeichern_Click(object sender, EventArgs e)
        {
            List<Person> personen = new List<Person>();
            personen.Add(new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100 });
            personen.Add(new Person { Vorname = "Anna", Nachname = "Nass", Alter = 20, Kontostand = 2000 });
            personen.Add(new Person { Vorname = "Peter", Nachname = "Silie", Alter = 30, Kontostand = 3330 });
            personen.Add(new Person { Vorname = "Franz", Nachname = "Ose", Alter = 40, Kontostand = -123100 });
            personen.Add(new Person { Vorname = "Martha", Nachname = "Pfahl", Alter = 50, Kontostand = 213213123100 });

            // 3 Techniken
            // 1) Binär
            // 2) XML
            // 3) JSON (JavaScript Object Notation)


            // JSON:
            // Externe DLL
            string json = JsonConvert.SerializeObject(personen);
            File.WriteAllText("person.json", json);

            // Binär:
            // Serialisieren
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("personenliste.bin", FileMode.Create);
            formatter.Serialize(stream, personen);
            stream.Close();

            // Deserialisieren
            stream = new FileStream("personenliste.bin", FileMode.Open);
            object data = formatter.Deserialize(stream);
            stream.Close();

            // XML:
            // Serialisieren
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>)); // Angabe vom Root-Objekt
            stream = new FileStream("personenliste.xml", FileMode.Create);
            xmlSerializer.Serialize(stream, personen);
            stream.Close();

            // Deserialisieren
            stream = new FileStream("personenliste.xml", FileMode.Open);
            object xmlData = xmlSerializer.Deserialize(stream);
            stream.Close();

        }

        private void ButtonPersonLaden_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("person.json");

            Person[] allePersonen = JsonConvert.DeserializeObject<Person[]>(json);
        }
    }
}
