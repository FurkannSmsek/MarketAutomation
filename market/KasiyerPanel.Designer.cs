namespace market
{
    partial class KasiyerPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_legume = new System.Windows.Forms.Button();
            this.btn_fruit = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageIndex = 3;
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(59, 63);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(160, 152);
            this.btn_et.TabIndex = 0;
            this.btn_et.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "milk.ico.ico");
            this.ımageList1.Images.SetKeyName(1, "fruit.ico.ico");
            this.ımageList1.Images.SetKeyName(2, "legume.ico.ico");
            this.ımageList1.Images.SetKeyName(3, "meat.ico.ico");
            // 
            // btn_sut
            // 
            this.btn_sut.ImageIndex = 0;
            this.btn_sut.ImageList = this.ımageList1;
            this.btn_sut.Location = new System.Drawing.Point(404, 63);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(160, 152);
            this.btn_sut.TabIndex = 1;
            this.btn_sut.UseVisualStyleBackColor = true;
            // 
            // btn_legume
            // 
            this.btn_legume.ImageIndex = 2;
            this.btn_legume.ImageList = this.ımageList1;
            this.btn_legume.Location = new System.Drawing.Point(59, 269);
            this.btn_legume.Name = "btn_legume";
            this.btn_legume.Size = new System.Drawing.Size(160, 152);
            this.btn_legume.TabIndex = 2;
            this.btn_legume.UseVisualStyleBackColor = true;
            // 
            // btn_fruit
            // 
            this.btn_fruit.ImageIndex = 1;
            this.btn_fruit.ImageList = this.ımageList1;
            this.btn_fruit.Location = new System.Drawing.Point(404, 269);
            this.btn_fruit.Name = "btn_fruit";
            this.btn_fruit.Size = new System.Drawing.Size(160, 152);
            this.btn_fruit.TabIndex = 3;
            this.btn_fruit.Text = "button1";
            this.btn_fruit.UseVisualStyleBackColor = true;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(59, 470);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(160, 47);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 594);
            this.Controls.Add(this.btn_fruit);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_legume);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_legume;
        private System.Windows.Forms.Button btn_fruit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_cikis;
        
        
    }
}