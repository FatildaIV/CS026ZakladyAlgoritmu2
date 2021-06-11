using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS025ZakladyAlgoritmu
{
    public partial class ZakladyAlgoritmuForm : Form
    {
        public ZakladyAlgoritmuForm()
        {
            InitializeComponent();
        }
        
        public delegate string AlgoritmusFunkce(string vstup);

        public struct Algoritmus
        {
            public string popis;
            public string pokyny;
            public AlgoritmusFunkce funkce;

            public Algoritmus (string popis, string pokyny, AlgoritmusFunkce funkce)
            {
                this.popis = popis;
                this.pokyny = pokyny;
                this.funkce = funkce;
            }
        }

        static Algoritmus[] algoritmy;

        private void vstupTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vystupLabel.Text = string.Format("= {0}", algoritmy[algoritmyComboBox.SelectedIndex].funkce(vstupTextBox.Text));
            }
            catch
            {
                vystupLabel.Text = string.Format("= {0}", "?");
            }
        }

        private void ZakladyAlgoritmuForm_Load(object sender, EventArgs e)
        {
            // Inicializace datového pole algoritmů
            algoritmy = new Algoritmus[4];
            algoritmy[0] = new Algoritmus("", "Zadejte dvě celá čísla, oddělená čárkou", Alg1NerovnostSoucetJinakSoucet3x);
            algoritmy[1] = new Algoritmus("", "Zadejte jedno celé číslo", Alg2RozdilOd51NeboTrojnasobek);
            algoritmy[2] = new Algoritmus("", "Zadejte dvě celá čísla, oddělená čárkou", Alg3JeCisloNeboSoucetTricet);
            algoritmy[3] = new Algoritmus("", "Zadejte jedno celé číslo", Alg4CisloMezi10Az100Nebo200);
        }

        private void algoritmyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokynyTextBox.Text = algoritmy[algoritmyComboBox.SelectedIndex].pokyny;
        }

        private void algoritmyComboBox_KeyDown(object sender, KeyEventArgs e)
        {            
            
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    algoritmyComboBox.SelectedIndex = int.Parse(algoritmyComboBox.Text) - 1;
                }
                catch
                {
                    algoritmyComboBox.Text += " Neexistuje";
                    
                }
                algoritmyComboBox.Select(0, algoritmyComboBox.Text.Length);
            }
        }

        static string Alg1NerovnostSoucetJinakSoucet3x(string vstup)
        {
            string[] data = vstup.Split(',');
            return NerovnostSoucetJinakSoucet3x(int.Parse(data[0]), int.Parse(data[1])).ToString();
        }
        static int NerovnostSoucetJinakSoucet3x(int a, int b)
        {
            return (a == b) ? (3 * (a + b)) : (a + b);
        }
        
        
        static string Alg2RozdilOd51NeboTrojnasobek(string vstup)
        {
            return RozdilOd51NeboTrojnasobek(int.Parse(vstup)).ToString();
        }
        static int RozdilOd51NeboTrojnasobek(int n)
        {
            return (n < 51) ? Math.Abs(51 - n) : (3 * Math.Abs(51 - n));
        }

        static string Alg3JeCisloNeboSoucetTricet(string vstup)
        {
            string[] data = vstup.Split(',');
            return JeCisloNeboSoucetTricet(int.Parse(data[0]), int.Parse(data[1])).ToString();
        }

        static bool JeCisloNeboSoucetTricet(int a, int b)
        {
            return (a == 30) || (b == 30) || ((a + b) == 30);
        }

        static string Alg4CisloMezi10Az100Nebo200(string vstup)
        {
            return CisloMezi10Az100Nebo200(int.Parse(vstup)).ToString();
        }

        static bool CisloMezi10Az100Nebo200(int n)
        {
            return (n >= 10) && (n <= 100) || (n == 200) ;
        }


    }
}
