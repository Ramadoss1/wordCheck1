using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using intel.IT.WordChecker; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Console.Write("Enter a word : ");
            //String iWord = Console.ReadLine();
            // can add input validations to remove special characters, etc etc 
            string iWord;
            iWord = textBox1.Text;
            string cword = iWord; 
            LanguageWord lWord = new LanguageWord(iWord);
            if (lWord.isValidWord())
                label1.Text = iWord + "  Is a valid Word"; 
            else
                label1.Text = iWord + "  Is a invalid Word";
        }
    }
}
