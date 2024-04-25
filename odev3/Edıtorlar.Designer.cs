namespace odev3
{
    partial class Editorlar
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
            soyad = new ColumnHeader();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(582, 427);
            button2.Name = "button2";
            button2.Size = new Size(243, 58);
            button2.TabIndex = 13;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(585, 363);
            button1.Name = "button1";
            button1.Size = new Size(243, 58);
            button1.TabIndex = 12;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(582, 267);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 11;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(582, 163);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 10;
            label1.Text = "Adı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(582, 302);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 46);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(582, 198);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 46);
            textBox1.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.BackgroundImageTiled = true;
            listView1.Columns.AddRange(new ColumnHeader[] { Adi, soyad });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(39, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(499, 637);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Adi
            // 
            Adi.Text = "Adi";
            Adi.Width = 250;
            // 
            // soyad
            // 
            soyad.Text = "Soyad";
            soyad.Width = 250;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(575, 67);
            label3.Name = "label3";
            label3.Size = new Size(253, 57);
            label3.TabIndex = 14;
            label3.Text = "Editorlar:";
            // 
            // Editorlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 693);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Name = "Editorlar";
            Text = "Editorlar";
            Load += Edıtorlar_Load;
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
        private ColumnHeader soyad;
        private Label label3;
    }
}