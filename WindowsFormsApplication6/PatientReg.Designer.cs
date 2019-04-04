namespace WindowsFormsApplication6
{
    partial class Form3
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
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblpid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbnmale = new System.Windows.Forms.RadioButton();
            this.rtaddress = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdisease = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.rbnfemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(100, 19);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(195, 20);
            this.txtpid.TabIndex = 2;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(21, 56);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "Date";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(21, 28);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(25, 13);
            this.lblpid.TabIndex = 4;
            this.lblpid.Text = "PID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(7, 117);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(26, 13);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Disease";
            // 
            // rbnmale
            // 
            this.rbnmale.AutoSize = true;
            this.rbnmale.Location = new System.Drawing.Point(115, 88);
            this.rbnmale.Name = "rbnmale";
            this.rbnmale.Size = new System.Drawing.Size(48, 17);
            this.rbnmale.TabIndex = 12;
            this.rbnmale.TabStop = true;
            this.rbnmale.Text = "Male";
            this.rbnmale.UseVisualStyleBackColor = true;
            // 
            // rtaddress
            // 
            this.rtaddress.Location = new System.Drawing.Point(100, 150);
            this.rtaddress.Name = "rtaddress";
            this.rtaddress.Size = new System.Drawing.Size(195, 52);
            this.rtaddress.TabIndex = 13;
            this.rtaddress.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblpid);
            this.groupBox1.Controls.Add(this.txtpid);
            this.groupBox1.Location = new System.Drawing.Point(232, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 73);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resistration Id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdisease);
            this.groupBox2.Controls.Add(this.txtage);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.rbnfemale);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtaddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Controls.Add(this.rbnmale);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(232, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 237);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient\'s Information";
            // 
            // txtdisease
            // 
            this.txtdisease.Location = new System.Drawing.Point(100, 211);
            this.txtdisease.Name = "txtdisease";
            this.txtdisease.Size = new System.Drawing.Size(195, 20);
            this.txtdisease.TabIndex = 16;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(100, 114);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(195, 20);
            this.txtage.TabIndex = 15;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(195, 20);
            this.txtname.TabIndex = 14;
            // 
            // rbnfemale
            // 
            this.rbnfemale.AutoSize = true;
            this.rbnfemale.Location = new System.Drawing.Point(223, 88);
            this.rbnfemale.Name = "rbnfemale";
            this.rbnfemale.Size = new System.Drawing.Size(59, 17);
            this.rbnfemale.TabIndex = 13;
            this.rbnfemale.TabStop = true;
            this.rbnfemale.Text = "Female";
            this.rbnfemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Patient Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(232, 396);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 18;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(484, 396);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Fetch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 431);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "PatientReg";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbnmale;
        private System.Windows.Forms.RichTextBox rtaddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnfemale;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdisease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}