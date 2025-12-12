namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            txtNamaDev = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            txtJumlahBug = new TextBox();
            txtFiturSelesai = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            dgDeveloper = new DataGridView();
            cmbProyek = new ComboBox();
            cmbStatusKontrak = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDeveloper).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Aplikasiku";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 30);
            label2.Name = "label2";
            label2.Size = new Size(200, 15);
            label2.TabIndex = 1;
            label2.Text = "Developer Team Performance tracker";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LawnGreen;
            btnInsert.Location = new Point(57, 270);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientInactiveCaption;
            btnUpdate.Location = new Point(183, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(310, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbStatusKontrak);
            groupBox1.Controls.Add(cmbProyek);
            groupBox1.Controls.Add(txtNamaDev);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(57, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 114);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // txtNamaDev
            // 
            txtNamaDev.Location = new Point(110, 16);
            txtNamaDev.Name = "txtNamaDev";
            txtNamaDev.Size = new Size(211, 23);
            txtNamaDev.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 79);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 2;
            label5.Text = "Status Kontrak :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 1;
            label4.Text = "Pilih Proyek :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 0;
            label3.Text = "Nama Developer :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(57, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 36);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("STXingkai", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(77, 24);
            label6.Name = "label6";
            label6.Size = new Size(37, 12);
            label6.TabIndex = 7;
            label6.Text = "LOGO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtJumlahBug);
            groupBox2.Controls.Add(txtFiturSelesai);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(57, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 85);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(157, 48);
            label11.Name = "label11";
            label11.Size = new Size(167, 15);
            label11.TabIndex = 6;
            label11.Text = "(Jumlah bug yang ditemukan)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(157, 19);
            label10.Name = "label10";
            label10.Size = new Size(165, 15);
            label10.TabIndex = 5;
            label10.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // txtJumlahBug
            // 
            txtJumlahBug.Location = new Point(104, 45);
            txtJumlahBug.Name = "txtJumlahBug";
            txtJumlahBug.Size = new Size(47, 23);
            txtJumlahBug.TabIndex = 4;
            // 
            // txtFiturSelesai
            // 
            txtFiturSelesai.Location = new Point(104, 16);
            txtFiturSelesai.Name = "txtFiturSelesai";
            txtFiturSelesai.Size = new Size(47, 23);
            txtFiturSelesai.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 79);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 48);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 1;
            label8.Text = "Jumlah Bug :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 0;
            label9.Text = "Fitur Selesai :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgDeveloper);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(57, 299);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 125);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // dgDeveloper
            // 
            dgDeveloper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDeveloper.Location = new Point(0, 22);
            dgDeveloper.Name = "dgDeveloper";
            dgDeveloper.Size = new Size(328, 103);
            dgDeveloper.TabIndex = 9;
            // 
            // cmbProyek
            // 
            cmbProyek.FormattingEnabled = true;
            cmbProyek.Location = new Point(110, 45);
            cmbProyek.Name = "cmbProyek";
            cmbProyek.Size = new Size(211, 23);
            cmbProyek.TabIndex = 4;
            // 
            // cmbStatusKontrak
            // 
            cmbStatusKontrak.FormattingEnabled = true;
            cmbStatusKontrak.Location = new Point(110, 76);
            cmbStatusKontrak.Name = "cmbStatusKontrak";
            cmbStatusKontrak.Size = new Size(211, 23);
            cmbStatusKontrak.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(437, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDeveloper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtNamaDev;
        private PictureBox pictureBox1;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtFiturSelesai;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private TextBox txtJumlahBug;
        private GroupBox groupBox3;
        private DataGridView dgDeveloper;
        private ComboBox cmbStatusKontrak;
        private ComboBox cmbProyek;
    }
}
