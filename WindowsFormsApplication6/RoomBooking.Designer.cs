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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbnsharing = new System.Windows.Forms.RadioButton();
            this.rbndelux = new System.Windows.Forms.RadioButton();
            this.rbnsingle = new System.Windows.Forms.RadioButton();
            this.rbnsuite = new System.Windows.Forms.RadioButton();
            this.txtenddate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtstartdate = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtroomno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfetch = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Room Booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Room no";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbnsharing);
            this.groupBox2.Controls.Add(this.rbndelux);
            this.groupBox2.Controls.Add(this.rbnsingle);
            this.groupBox2.Controls.Add(this.rbnsuite);
            this.groupBox2.Controls.Add(this.txtenddate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtstartdate);
            this.groupBox2.Controls.Add(this.txtstatus);
            this.groupBox2.Controls.Add(this.txtroomno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(50, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 243);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Room Type";
            // 
            // rbnsharing
            // 
            this.rbnsharing.AutoSize = true;
            this.rbnsharing.Location = new System.Drawing.Point(148, 168);
            this.rbnsharing.Name = "rbnsharing";
            this.rbnsharing.Size = new System.Drawing.Size(61, 17);
            this.rbnsharing.TabIndex = 13;
            this.rbnsharing.TabStop = true;
            this.rbnsharing.Text = "Sharing";
            this.rbnsharing.UseVisualStyleBackColor = true;
            // 
            // rbndelux
            // 
            this.rbndelux.AutoSize = true;
            this.rbndelux.Location = new System.Drawing.Point(231, 168);
            this.rbndelux.Name = "rbndelux";
            this.rbndelux.Size = new System.Drawing.Size(52, 17);
            this.rbndelux.TabIndex = 14;
            this.rbndelux.TabStop = true;
            this.rbndelux.Text = "Delux";
            this.rbndelux.UseVisualStyleBackColor = true;
            // 
            // rbnsingle
            // 
            this.rbnsingle.AutoSize = true;
            this.rbnsingle.Location = new System.Drawing.Point(148, 204);
            this.rbnsingle.Name = "rbnsingle";
            this.rbnsingle.Size = new System.Drawing.Size(54, 17);
            this.rbnsingle.TabIndex = 15;
            this.rbnsingle.TabStop = true;
            this.rbnsingle.Text = "Single";
            this.rbnsingle.UseVisualStyleBackColor = true;
            // 
            // rbnsuite
            // 
            this.rbnsuite.AutoSize = true;
            this.rbnsuite.Location = new System.Drawing.Point(234, 204);
            this.rbnsuite.Name = "rbnsuite";
            this.rbnsuite.Size = new System.Drawing.Size(49, 17);
            this.rbnsuite.TabIndex = 16;
            this.rbnsuite.TabStop = true;
            this.rbnsuite.Text = "Suite";
            this.rbnsuite.UseVisualStyleBackColor = true;
            // 
            // txtenddate
            // 
            this.txtenddate.Location = new System.Drawing.Point(148, 104);
            this.txtenddate.Name = "txtenddate";
            this.txtenddate.Size = new System.Drawing.Size(135, 20);
            this.txtenddate.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "End Date";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(148, 130);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(135, 20);
            this.txtprice.TabIndex = 26;
            // 
            // txtstartdate
            // 
            this.txtstartdate.Location = new System.Drawing.Point(148, 81);
            this.txtstartdate.Name = "txtstartdate";
            this.txtstartdate.Size = new System.Drawing.Size(135, 20);
            this.txtstartdate.TabIndex = 25;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(148, 55);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(135, 20);
            this.txtstatus.TabIndex = 24;
            // 
            // txtroomno
            // 
            this.txtroomno.Location = new System.Drawing.Point(148, 31);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(135, 20);
            this.txtroomno.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(74, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "PID";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(156, 97);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(135, 20);
            this.txtpid.TabIndex = 28;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnupdate.Location = new System.Drawing.Point(147, 422);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 33);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btndelete.Location = new System.Drawing.Point(247, 422);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnsubmit.Location = new System.Drawing.Point(50, 422);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 33);
            this.btnsubmit.TabIndex = 31;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.AliceBlue;
            this.btnback.Location = new System.Drawing.Point(337, 422);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 33);
            this.btnback.TabIndex = 32;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnfetch.Location = new System.Drawing.Point(308, 95);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(75, 23);
            this.btnfetch.TabIndex = 33;
            this.btnfetch.Text = "Fetch";
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // RoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 478);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "RoomBooking";
            this.Text = "RoomInfo";
            this.Load += new System.EventHandler(this.RoomBooking_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtstartdate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtroomno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbnsharing;
        private System.Windows.Forms.RadioButton rbndelux;
        private System.Windows.Forms.RadioButton rbnsingle;
        private System.Windows.Forms.RadioButton rbnsuite;
        private System.Windows.Forms.TextBox txtenddate;
        private System.Windows.Forms.Label label7;
    }
}