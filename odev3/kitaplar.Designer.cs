namespace odev3
{
    partial class YayinevKitaplar
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
            listView1 = new ListView();
            Adi = new ColumnHeader();
            yazar = new ColumnHeader();
            Edit = new ColumnHeader();
            Acik = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.BackgroundImageTiled = true;
            listView1.Columns.AddRange(new ColumnHeader[] { Adi, yazar, Edit, Acik });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(49, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(930, 707);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            Acik.Text = "Durum";
            Acik.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic Fixed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(440, 8);
            label1.Name = "label1";
            label1.Size = new Size(145, 43);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // YayinevKitaplar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 760);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "YayinevKitaplar";
            Text = "kitaplar";
            Load += YayinevKitaplar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Adi;
        private ColumnHeader yazar;
        private ColumnHeader Edit;
        private ColumnHeader Acik;
        private Label label1;
    }
}