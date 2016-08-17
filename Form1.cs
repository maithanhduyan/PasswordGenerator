using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PWW
{
    public partial class Form1 : Form
    {
        String[] alphabet = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                             "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                             "1","2","3","4","5","6","7","8","9","0"
                            };
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button_Encript_Click(object sender, EventArgs e)
        {
            String s ="";
            for (int i = 1; i < 31; i++)
            {
               s+=alphabet[randText()];
            }
            
            textBox2.Text = s;
        }

        int randText() {
            return rand.Next(0, 61);
        }

    }
}
