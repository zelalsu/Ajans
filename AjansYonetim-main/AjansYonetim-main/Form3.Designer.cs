
namespace NesneProjeOdevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblListView = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofisÇalışanlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teknikEkipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evrakEkibiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEkIzın = new System.Windows.Forms.TextBox();
            this.txtIzınGunu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.inputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListView
            // 
            this.lblListView.AutoSize = true;
            this.lblListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListView.Location = new System.Drawing.Point(12, 45);
            this.lblListView.Name = "lblListView";
            this.lblListView.Size = new System.Drawing.Size(0, 25);
            this.lblListView.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(692, 320);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.firmalarToolStripMenuItem,
            this.oyuncularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ofisÇalışanlarıToolStripMenuItem});
            this.çalışanlarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.çalışanlarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // ofisÇalışanlarıToolStripMenuItem
            // 
            this.ofisÇalışanlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teknikEkipToolStripMenuItem,
            this.evrakEkibiToolStripMenuItem});
            this.ofisÇalışanlarıToolStripMenuItem.Name = "ofisÇalışanlarıToolStripMenuItem";
            this.ofisÇalışanlarıToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.ofisÇalışanlarıToolStripMenuItem.Text = "Ofis Çalışanları";
            // 
            // teknikEkipToolStripMenuItem
            // 
            this.teknikEkipToolStripMenuItem.Name = "teknikEkipToolStripMenuItem";
            this.teknikEkipToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.teknikEkipToolStripMenuItem.Text = "Teknik Ekip";
            this.teknikEkipToolStripMenuItem.Click += new System.EventHandler(this.teknikEkipToolStripMenuItem_Click);
            // 
            // evrakEkibiToolStripMenuItem
            // 
            this.evrakEkibiToolStripMenuItem.Name = "evrakEkibiToolStripMenuItem";
            this.evrakEkibiToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.evrakEkibiToolStripMenuItem.Text = "Evrak Ekibi";
            this.evrakEkibiToolStripMenuItem.Click += new System.EventHandler(this.evrakEkibiToolStripMenuItem_Click);
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmalarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.firmalarToolStripMenuItem.Text = "Firmalar";
            this.firmalarToolStripMenuItem.Click += new System.EventHandler(this.firmalarToolStripMenuItem_Click);
            // 
            // oyuncularToolStripMenuItem
            // 
            this.oyuncularToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyuncularToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oyuncularToolStripMenuItem.Name = "oyuncularToolStripMenuItem";
            this.oyuncularToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.oyuncularToolStripMenuItem.Text = "Oyuncular";
            this.oyuncularToolStripMenuItem.Click += new System.EventHandler(this.oyuncularToolStripMenuItem_Click);
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.btnGuncelle);
            this.inputGroup.Controls.Add(this.label4);
            this.inputGroup.Controls.Add(this.txtEkIzın);
            this.inputGroup.Controls.Add(this.txtIzınGunu);
            this.inputGroup.Controls.Add(this.label5);
            this.inputGroup.Location = new System.Drawing.Point(714, 73);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(200, 142);
            this.inputGroup.TabIndex = 20;
            this.inputGroup.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(20, 90);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(172, 28);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ek İzin Sayısı:";
            // 
            // txtEkIzın
            // 
            this.txtEkIzın.Location = new System.Drawing.Point(92, 54);
            this.txtEkIzın.Name = "txtEkIzın";
            this.txtEkIzın.Size = new System.Drawing.Size(100, 20);
            this.txtEkIzın.TabIndex = 7;
            // 
            // txtIzınGunu
            // 
            this.txtIzınGunu.Location = new System.Drawing.Point(92, 19);
            this.txtIzınGunu.Name = "txtIzınGunu";
            this.txtIzınGunu.Size = new System.Drawing.Size(100, 20);
            this.txtIzınGunu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(17, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "İzin Günü:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 404);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblListView);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müdür Yardımcısı Paneli";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofisÇalışanlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teknikEkipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evrakEkibiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncularToolStripMenuItem;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEkIzın;
        private System.Windows.Forms.TextBox txtIzınGunu;
        private System.Windows.Forms.Label label5;
    }
}