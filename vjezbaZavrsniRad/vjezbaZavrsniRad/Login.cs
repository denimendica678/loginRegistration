using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace vjezbaZavrsniRad
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        public string FromXMLkorisnik = "";
        public string FromXMLlozinka = "";
        public string FromXMLime = "";

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string korisnik = korisnickoIme.Text;
            string lozinka = this.lozinkaa.Text;

            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\korisnici.xml");
            var odabraniKorisnik = from x in doc.Descendants("korisnici").Where(x => (string)x.Element("korisnickoime") == korisnickoIme.Text)
                                   select new
                                   {
                                       XMLkorisnik = x.Element("korisnickoime").Value,
                                       XMLlozinka = x.Element("lozinka").Value

                                   };
            foreach(var x in odabraniKorisnik)
            {
                FromXMLkorisnik = x.XMLkorisnik;
                FromXMLlozinka = x.XMLlozinka;
            }

            

            if (korisnik == FromXMLkorisnik)
            {
                if(lozinka == FromXMLlozinka)
                {
                    if (korisnickoIme.Text == "" && lozinkaa.Text == "")
                    {
                        MessageBox.Show("Molimo vas upišite podatke za prijavu.");
                        Pocetna fm = new Pocetna();
                        fm.Hide();
                    }
                    else
                    {
                        ClearBoxes();
                        Pocetna fm = new Pocetna();
                        fm.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Neispravna lozinka. Pokušajte ponovno.");
                    ClearBoxes();
                }
            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime. Pokušajte ponovno.");
                ClearBoxes();
            }
        }

        private void ClearBoxes()
        {
            korisnickoIme.Clear();
            lozinkaa.Clear();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void prikazi_CheckedChanged(object sender, EventArgs e)
        {
            if (prikazi.Checked)
            {
                lozinkaa.UseSystemPasswordChar = true;
            }
            else
            {
                lozinkaa.UseSystemPasswordChar = false;
            }
        }

        private void linkRegistrirajSe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register fm = new Register();
            fm.Show();
        }
    }
}
