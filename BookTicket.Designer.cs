namespace project2
{
    partial class BookTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttptravelday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ltbtime = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.btncancle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTN = new System.Windows.Forms.TextBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.cmbDestn = new System.Windows.Forms.ComboBox();
            this.cmbtdb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book a car ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(72, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source province";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(72, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination province";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(74, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date";
            // 
            // ttptravelday
            // 
            this.ttptravelday.CalendarForeColor = System.Drawing.Color.LightSteelBlue;
            this.ttptravelday.CalendarMonthBackground = System.Drawing.Color.LightSkyBlue;
            this.ttptravelday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttptravelday.Location = new System.Drawing.Point(81, 511);
            this.ttptravelday.Name = "ttptravelday";
            this.ttptravelday.Size = new System.Drawing.Size(346, 36);
            this.ttptravelday.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(74, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = " Ticket Drawn By";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(100, 797);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "Receive a ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(74, 685);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Time";
            // 
            // ltbtime
            // 
            this.ltbtime.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbtime.FormattingEnabled = true;
            this.ltbtime.ItemHeight = 36;
            this.ltbtime.Items.AddRange(new object[] {
            "05:00",
            "07:00",
            "10:00",
            "12:00",
            "15:00",
            "17:00",
            "19:00",
            "21:00",
            "23:00"});
            this.ltbtime.Location = new System.Drawing.Point(79, 725);
            this.ltbtime.Name = "ltbtime";
            this.ltbtime.Size = new System.Drawing.Size(129, 40);
            this.ltbtime.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(243, 683);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "amount";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtamount.Location = new System.Drawing.Point(250, 723);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(177, 42);
            this.txtamount.TabIndex = 16;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncancle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncancle.Location = new System.Drawing.Point(378, 797);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(149, 57);
            this.btncancle.TabIndex = 17;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.Btncancle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ticket No";
            // 
            // txtTN
            // 
            this.txtTN.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTN.Location = new System.Drawing.Point(79, 183);
            this.txtTN.Multiline = true;
            this.txtTN.Name = "txtTN";
            this.txtTN.Size = new System.Drawing.Size(346, 42);
            this.txtTN.TabIndex = 19;
            this.txtTN.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // cmbSource
            // 
            this.cmbSource.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSource.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Bankkok",
            "Chiang Mai",
            "Khon Kaen",
            "Krabi",
            "Phuket "});
            this.cmbSource.Location = new System.Drawing.Point(79, 284);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(338, 50);
            this.cmbSource.TabIndex = 20;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.Cbxsource_SelectedIndexChanged);
            // 
            // cmbDestn
            // 
            this.cmbDestn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbDestn.FormattingEnabled = true;
            this.cmbDestn.Items.AddRange(new object[] {
            "Bankkok",
            "Chiang Mai",
            "Khon Kaen",
            "Krabi",
            "Phuket "});
            this.cmbDestn.Location = new System.Drawing.Point(79, 399);
            this.cmbDestn.Name = "cmbDestn";
            this.cmbDestn.Size = new System.Drawing.Size(338, 50);
            this.cmbDestn.TabIndex = 21;
            this.cmbDestn.SelectedIndexChanged += new System.EventHandler(this.CbxDestin_SelectedIndexChanged);
            // 
            // cmbtdb
            // 
            this.cmbtdb.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtdb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbtdb.FormattingEnabled = true;
            this.cmbtdb.Items.AddRange(new object[] {
            "Bankkok",
            "Chiang Mai",
            "Khon Kaen",
            "Krabi",
            "Phuket "});
            this.cmbtdb.Location = new System.Drawing.Point(89, 608);
            this.cmbtdb.Name = "cmbtdb";
            this.cmbtdb.Size = new System.Drawing.Size(338, 50);
            this.cmbtdb.TabIndex = 22;
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(567, 880);
            this.Controls.Add(this.cmbtdb);
            this.Controls.Add(this.cmbDestn);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.txtTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ltbtime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttptravelday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTicket";
            this.Text = "BookTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ttptravelday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ltbtime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTN;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.ComboBox cmbDestn;
        private System.Windows.Forms.ComboBox cmbtdb;
    }
}