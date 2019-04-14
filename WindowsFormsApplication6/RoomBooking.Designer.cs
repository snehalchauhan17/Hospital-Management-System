namespace WindowsFormsApplication6
{
    partial class RoomBooking
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfetch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtroomno = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbnsuite = new System.Windows.Forms.RadioButton();
            this.rbnsingle = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbndelux = new System.Windows.Forms.RadioButton();
            this.rbnsharing = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(208, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Room Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "PID";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(178, 161);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(147, 20);
            this.txtpid.TabIndex = 28;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Lavender;
            this.btnupdate.Location = new System.Drawing.Point(209, 459);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 33);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Lavender;
            this.btndelete.Location = new System.Drawing.Point(331, 459);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Lavender;
            this.btnsubmit.Location = new System.Drawing.Point(80, 459);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 33);
            this.btnsubmit.TabIndex = 31;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Lavender;
            this.btnback.Location = new System.Drawing.Point(461, 459);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 33);
            this.btnback.TabIndex = 32;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.Lavender;
            this.btnfetch.Location = new System.Drawing.Point(384, 159);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(75, 23);
            this.btnfetch.TabIndex = 33;
            this.btnfetch.Text = "Fetch";
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Room no";
            // 
            // txtroomno
            // 
            this.txtroomno.Location = new System.Drawing.Point(148, 31);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(147, 22);
            this.txtroomno.TabIndex = 23;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(148, 135);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(147, 22);
            this.txtprice.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "End Date";
            // 
            // rbnsuite
            // 
            this.rbnsuite.AutoSize = true;
            this.rbnsuite.Location = new System.Drawing.Point(110, 51);
            this.rbnsuite.Name = "rbnsuite";
            this.rbnsuite.Size = new System.Drawing.Size(56, 20);
            this.rbnsuite.TabIndex = 16;
            this.rbnsuite.TabStop = true;
            this.rbnsuite.Text = "Suite";
            this.rbnsuite.UseVisualStyleBackColor = true;
            // 
            // rbnsingle
            // 
            this.rbnsingle.AutoSize = true;
            this.rbnsingle.Location = new System.Drawing.Point(24, 51);
            this.rbnsingle.Name = "rbnsingle";
            this.rbnsingle.Size = new System.Drawing.Size(64, 20);
            this.rbnsingle.TabIndex = 15;
            this.rbnsingle.TabStop = true;
            this.rbnsingle.Text = "Single";
            this.rbnsingle.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Room Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(338, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 52);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vacant";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 20);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Occupied";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbndelux);
            this.groupBox4.Controls.Add(this.rbnsuite);
            this.groupBox4.Controls.Add(this.rbnsingle);
            this.groupBox4.Controls.Add(this.rbnsharing);
            this.groupBox4.Location = new System.Drawing.Point(145, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 79);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // rbndelux
            // 
            this.rbndelux.AutoSize = true;
            this.rbndelux.Location = new System.Drawing.Point(107, 19);
            this.rbndelux.Name = "rbndelux";
            this.rbndelux.Size = new System.Drawing.Size(60, 20);
            this.rbndelux.TabIndex = 14;
            this.rbndelux.TabStop = true;
            this.rbndelux.Text = "Delux";
            this.rbndelux.UseVisualStyleBackColor = true;
            // 
            // rbnsharing
            // 
            this.rbnsharing.AutoSize = true;
            this.rbnsharing.Location = new System.Drawing.Point(24, 19);
            this.rbnsharing.Name = "rbnsharing";
            this.rbnsharing.Size = new System.Drawing.Size(72, 20);
            this.rbnsharing.TabIndex = 13;
            this.rbnsharing.TabStop = true;
            this.rbnsharing.Text = "Sharing";
            this.rbnsharing.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtroomno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 257);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Info";
            // 
            // RoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication6.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 504);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "RoomBooking";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtroomno;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbnsuite;
        private System.Windows.Forms.RadioButton rbnsingle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbndelux;
        private System.Windows.Forms.RadioButton rbnsharing;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}