using System;
using System.IO;
using System.Windows.Forms;

namespace project2
{
    public partial class BookTicket : Form
    {
        public String Ticket;
        public String source;
        public String Destination;
        public String Date;
        public String Drawn;
        public String time ;
        public String amount;
        public String a;
        public BookTicket()
        {
            InitializeComponent();
        }
        public int randomnumber(int min, int max)
        {
            Random rnum = new Random();
            return rnum.Next(min, max);
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            Ticket = txtTN.Text.ToString();
            source = cmbSource.Text.ToString();
            Destination = cmbDestn.Text.ToString();
            Date = ttptravelday.Text.ToString();
            Drawn = cmbtdb.Text.ToString();
            time = ltbtime.Text.ToString();
            amount = txtamount.Text.ToString();
             if (Ticket != null && source != null && Destination != null && Date != null && Drawn != null && time != null && amount != null)
            {
                File.WriteAllText(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", string.Empty);
                a = randomnumber(0, 99999999).ToString();
               MessageBox.Show(" ID :" + a + "\n Ticket No :" + Ticket + "\n Source province :" + source + "\n Destination province :" + Destination + "\n Date :" +
                      Date + "\n Ticket Drawn By :" + Drawn + "\n time :" + time + "\n amount :" + amount);


                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("ID :" + a);
                }             
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("Ticket No :" + Ticket);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("Source province :" + source);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("Destination province :" + Destination);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("Date :" + Date);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("Ticket Drawn By :" + Drawn);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("time :" + time);
                }
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Thananun\Desktop\project_hong\project2\project2\data.txt", true))
                {
                    writer.WriteLine("amount :" + amount);
                }

                Paymoney v = new Paymoney();
                v.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please input again!!!!");
                this.Hide();
            }

            this.Close();
        }


        private void Btncancle_Click(object sender, EventArgs e)
        {
            txtTN.Clear();
            txtamount.Clear();

        }

        private void CbxDestin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkSameSelection();

            if (cmbSource.SelectedIndex == 0 && cmbDestn.SelectedIndex == 1)
            {
                txtamount.Text = "200.00";
            }
            else if (cmbSource.SelectedIndex == 0 && cmbDestn.SelectedIndex == 2)
            {
                txtamount.Text = "300.00";
            }
            else if (cmbSource.SelectedIndex == 0 && cmbDestn.SelectedIndex == 3)
            {
                txtamount.Text = "400.00";
            }
            else if (cmbSource.SelectedIndex == 0 && cmbDestn.SelectedIndex == 4)
            {
                txtamount.Text = "500.00";
            }
            else if (cmbSource.SelectedIndex == 0 && cmbDestn.SelectedIndex == 5)
            {
                txtamount.Text = "600.00";
            }
            else if (cmbSource.SelectedIndex == 1 && cmbDestn.SelectedIndex == 2)
            {
                txtamount.Text = "200.00";
            }
            else if (cmbSource.SelectedIndex == 1 && cmbDestn.SelectedIndex == 3)
            {
                txtamount.Text = "300.00";
            }
            else if (cmbSource.SelectedIndex == 1 && cmbDestn.SelectedIndex == 4)
            {
                txtamount.Text = "400.00";
            }
            else if (cmbSource.SelectedIndex == 1 && cmbDestn.SelectedIndex == 5)
            {
                txtamount.Text = "500.00";
            }
            else if (cmbSource.SelectedIndex == 2 && cmbDestn.SelectedIndex == 3)
            {
                txtamount.Text = "200.00";
            }
            else if (cmbSource.SelectedIndex == 2 && cmbDestn.SelectedIndex == 4)
            {
                txtamount.Text = "300.00";
            }
            else if (cmbSource.SelectedIndex == 2 && cmbDestn.SelectedIndex == 5)
            {
                txtamount.Text = "400.00";
            }
            else if (cmbSource.SelectedIndex == 3 && cmbDestn.SelectedIndex == 4)
            {
                txtamount.Text = "300.00";
            }
            else if (cmbSource.SelectedIndex == 3 && cmbDestn.SelectedIndex == 5)
            {
                txtamount.Text = "400.00";
            }
            else if (cmbSource.SelectedIndex == 4 && cmbDestn.SelectedIndex == 5)
            {
                txtamount.Text = "200.00";
            }
        }

        private void checkSameSelection()
        {
            if (cmbSource.SelectedIndex == cmbDestn.SelectedIndex)
            {
                MessageBox.Show("You Have selected source and destination as same....Please Select Different station to drawn Ticket");
                txtTN.Text = "0";
                return;
            }
        }
    }
}
