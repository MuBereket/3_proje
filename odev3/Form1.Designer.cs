namespace odev3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            yayinEviToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            yazarToolStripMenuItem = new ToolStripMenuItem();
            arayüzYazarlarToolStripMenuItem = new ToolStripMenuItem();
            editorToolStripMenuItem = new ToolStripMenuItem();
            addEditorToolStripMenuItem = new ToolStripMenuItem();
            yazarToolStripMenuItem1 = new ToolStripMenuItem();
            arayüzToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yayinEviToolStripMenuItem, yazarToolStripMenuItem, editorToolStripMenuItem, yazarToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(925, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // yayinEviToolStripMenuItem
            // 
            yayinEviToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            yayinEviToolStripMenuItem.Name = "yayinEviToolStripMenuItem";
            yayinEviToolStripMenuItem.Size = new Size(86, 29);
            yayinEviToolStripMenuItem.Text = "YayinEvi";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(118, 30);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // yazarToolStripMenuItem
            // 
            yazarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arayüzYazarlarToolStripMenuItem });
            yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            yazarToolStripMenuItem.Size = new Size(64, 29);
            yazarToolStripMenuItem.Text = "Kitap";
            yazarToolStripMenuItem.Click += yazarToolStripMenuItem_Click;
            // 
            // arayüzYazarlarToolStripMenuItem
            // 
            arayüzYazarlarToolStripMenuItem.Name = "arayüzYazarlarToolStripMenuItem";
            arayüzYazarlarToolStripMenuItem.Size = new Size(189, 30);
            arayüzYazarlarToolStripMenuItem.Text = "Add/Remove";
            arayüzYazarlarToolStripMenuItem.Click += arayüzYazarlarToolStripMenuItem_Click;
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addEditorToolStripMenuItem });
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new Size(71, 29);
            editorToolStripMenuItem.Text = "Editor";
            // 
            // addEditorToolStripMenuItem
            // 
            addEditorToolStripMenuItem.Name = "addEditorToolStripMenuItem";
            addEditorToolStripMenuItem.Size = new Size(209, 30);
            addEditorToolStripMenuItem.Text = "Arayüz Editorlar";
            addEditorToolStripMenuItem.Click += addEditorToolStripMenuItem_Click;
            // 
            // yazarToolStripMenuItem1
            // 
            yazarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { arayüzToolStripMenuItem });
            yazarToolStripMenuItem1.Name = "yazarToolStripMenuItem1";
            yazarToolStripMenuItem1.Size = new Size(64, 29);
            yazarToolStripMenuItem1.Text = "Yazar";
            // 
            // arayüzToolStripMenuItem
            // 
            arayüzToolStripMenuItem.Name = "arayüzToolStripMenuItem";
            arayüzToolStripMenuItem.Size = new Size(202, 30);
            arayüzToolStripMenuItem.Text = "Arayüz Yazarlar";
            arayüzToolStripMenuItem.Click += arayüzToolStripMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(542, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 33);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(398, 102);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 2;
            label1.Text = "Yayın Evler";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(768, 101);
            button1.Name = "button1";
            button1.Size = new Size(123, 33);
            button1.TabIndex = 3;
            button1.Text = "Goster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(542, 51);
            button2.Name = "button2";
            button2.Size = new Size(220, 44);
            button2.TabIndex = 4;
            button2.Text = "Reload";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(925, 630);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Arayüz Yayın Evler: Muhammed Bereket 205260602";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem yayinEviToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editorToolStripMenuItem;
        private ToolStripMenuItem addEditorToolStripMenuItem;
        private ToolStripMenuItem yazarToolStripMenuItem;
        private ToolStripMenuItem arayüzYazarlarToolStripMenuItem;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem yazarToolStripMenuItem1;
        private ToolStripMenuItem arayüzToolStripMenuItem;
    }
}