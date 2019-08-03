using iTextSharp.text.pdf;
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
using System.Windows.Media;


namespace project2
{
    public partial class Paymoney : Form
    {
       
        public Paymoney()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            BookTicket v = new BookTicket();
            v.ShowDialog();
            this.Hide();
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            this.Close();
            BookTicket v = new BookTicket();
            v.ShowDialog();
            this.Hide();
        }

        private void Paymoney_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", Encoding.UTF8);
            textBox1.Text = text.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Btnok_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
