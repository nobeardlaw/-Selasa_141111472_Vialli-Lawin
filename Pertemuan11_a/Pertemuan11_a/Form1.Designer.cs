namespace Pertemuan11_a
{
    partial class Form1
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
            this.txId = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.txZipCode = new System.Windows.Forms.TextBox();
            this.txPhoneNumber = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDaftar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // txId
            // 
            this.txId.Enabled = false;
            this.txId.Location = new System.Drawing.Point(152, 15);
            this.txId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(132, 22);
            this.txId.TabIndex = 0;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(152, 47);
            this.txName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(132, 22);
            this.txName.TabIndex = 1;
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(152, 79);
            this.txAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txAddress.Multiline = true;
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(236, 50);
            this.txAddress.TabIndex = 2;
            // 
            // txZipCode
            // 
            this.txZipCode.Location = new System.Drawing.Point(152, 137);
            this.txZipCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txZipCode.Name = "txZipCode";
            this.txZipCode.Size = new System.Drawing.Size(132, 22);
            this.txZipCode.TabIndex = 3;
            // 
            // txPhoneNumber
            // 
            this.txPhoneNumber.Location = new System.Drawing.Point(152, 169);
            this.txPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txPhoneNumber.Name = "txPhoneNumber";
            this.txPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.txPhoneNumber.TabIndex = 4;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(152, 201);
            this.txEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(132, 22);
            this.txEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zip Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // dgvDaftar
            // 
            this.dgvDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftar.Location = new System.Drawing.Point(16, 255);
            this.dgvDaftar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDaftar.Name = "dgvDaftar";
            this.dgvDaftar.Size = new System.Drawing.Size(661, 270);
            this.dgvDaftar.TabIndex = 12;
            this.dgvDaftar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftar_CellClick);
            this.dgvDaftar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftar_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 127);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(551, 183);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 42);
            this.button4.TabIndex = 16;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 539);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDaftar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txPhoneNumber);
            this.Controls.Add(this.txZipCode);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.TextBox txZipCode;
        private System.Windows.Forms.TextBox txPhoneNumber;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDaftar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

