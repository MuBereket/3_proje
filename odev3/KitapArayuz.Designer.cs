namespace odev3
{
    partial class KitapArayuz
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            Adi = new ColumnHeader();
            yazar = new ColumnHeader();
            Edit = new ColumnHeader();
            Acik = new ColumnHeader();
            inceleme = new ColumnHeader();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1279, 699);
            button2.Name = "button2";
            button2.Size = new Size(257, 58);
            button2.TabIndex = 20;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1279, 635);
            button1.Name = "button1";
            button1.Size = new Size(257, 58);
            button1.TabIndex = 19;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1279, 133);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 18;
            label2.Text = "Yazar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1279, 29);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 17;
            label1.Text = "Kitap ismi:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(1279, 350);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 115);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1279, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 46);
            textBox1.TabIndex = 15;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.BackgroundImageTiled = true;
            listView1.Columns.AddRange(new ColumnHeader[] { Adi, yazar, Edit, Acik, inceleme });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(1261, 745);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Adi
            // 
            Adi.Text = "Kitap ismi";
            Adi.Width = 250;
            // 
            // yazar
            // 
            yazar.Text = "Yazar";
            yazar.Width = 250;
            // 
            // Edit
            // 
            Edit.Text = "Editor";
            Edit.Width = 250;
            // 
            // Acik
            // 
            Acik.Text = "Aciklama";
            Acik.Width = 400;
            // 
            // inceleme
            // 
            inceleme.Text = "Incelemede";
            inceleme.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1279, 315);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 22;
            label3.Text = "Aciklama:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1279, 231);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 24;
            label4.Text = "Editor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1279, 468);
            label5.Name = "label5";
            label5.Size = new Size(139, 32);
            label5.TabIndex = 25;
            label5.Text = "Incelemde:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1279, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 38);
            comboBox1.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1279, 266);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(246, 38);
            comboBox2.TabIndex = 27;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(1311, 513);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(162, 34);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Duzenlenecek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(1311, 544);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(127, 34);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "Onaylandi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(1311, 579);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(132, 34);
            radioButton3.TabIndex = 30;
            radioButton3.TabStop = true;
            radioButton3.Text = "Reddedildi";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // KitapArayuz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 805);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            MaximizeBox = false;
            Name = "KitapArayuz";
            Text = "KitapArayuz";
            Load += KitapArayuz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader Adi;
        private ColumnHeader yazar;
        private ColumnHeader Edit;
        private ColumnHeader Acik;
        private ColumnHeader inceleme;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}