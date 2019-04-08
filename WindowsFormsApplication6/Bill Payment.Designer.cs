namespace WindowsFormsApplication6
{
    partial class BillPayment
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
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textPID = new System.Windows.Forms.TextBox();
            this.textptname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textdoctor = new System.Windows.Forms.TextBox();
            this.textmdcn = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textRpt = new System.Windows.Forms.TextBox();
            this.textOther = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfetch = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Patient Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Patient Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Bill Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Doctor Visit Charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Medicine Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Room Rent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Report Charges";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Others";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(151, 113);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(117, 20);
            this.textBox9.TabIndex = 67;
            // 
            // textPID
            // 
            this.textPID.Location = new System.Drawing.Point(151, 146);
            this.textPID.Name = "textPID";
            this.textPID.Size = new System.Drawing.Size(117, 20);
            this.textPID.TabIndex = 68;
            // 
            // textptname
            // 
            this.textptname.Location = new System.Drawing.Point(151, 183);
            this.textptname.Name = "textptname";
            this.textptname.Size = new System.Drawing.Size(117, 20);
            this.textptname.TabIndex = 69;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 70;
            // 
            // textdoctor
            // 
            this.textdoctor.Location = new System.Drawing.Point(472, 146);
            this.textdoctor.Name = "textdoctor";
            this.textdoctor.Size = new System.Drawing.Size(117, 20);
            this.textdoctor.TabIndex = 71;
            // 
            // textmdcn
            // 
            this.textmdcn.Location = new System.Drawing.Point(472, 110);
            this.textmdcn.Name = "textmdcn";
            this.textmdcn.Size = new System.Drawing.Size(117, 20);
            this.textmdcn.TabIndex = 72;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 267);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 20);
            this.textBox6.TabIndex = 73;
            // 
            // textRpt
            // 
            this.textRpt.Location = new System.Drawing.Point(472, 183);
            this.textRpt.Name = "textRpt";
            this.textRpt.Size = new System.Drawing.Size(117, 20);
            this.textRpt.TabIndex = 74;
            // 
            // textOther
            // 
            this.textOther.Location = new System.Drawing.Point(472, 227);
            this.textOther.Name = "textOther";
            this.textOther.Size = new System.Drawing.Size(117, 20);
            this.textOther.TabIndex = 75;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(472, 263);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(117, 20);
            this.textBox10.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(209, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 31);
            this.label9.TabIndex = 77;
            this.label9.Text = "Patient Total Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Room No.";
            // 
            // btnfetch
            // 
            this.btnfetch.Location = new System.Drawing.Point(274, 143);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(43, 23);
            this.btnfetch.TabIndex = 78;
            this.btnfetch.Text = "Fetch";
            this.btnfetch.UseVisualStyleBackColor = true;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(607, 227);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(66, 23);
            this.btncalculate.TabIndex = 79;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseMnemonic = false;
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // BillPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 403);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textOther);
            this.Controls.Add(this.textRpt);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textmdcn);
            this.Controls.Add(this.textdoctor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textptname);
            this.Controls.Add(this.textPID);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillPayment";
            this.Text = "Bill Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textPID;
        private System.Windows.Forms.TextBox textptname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textdoctor;
        private System.Windows.Forms.TextBox textmdcn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textRpt;
        private System.Windows.Forms.TextBox textOther;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Button btncalculate;

    }
}