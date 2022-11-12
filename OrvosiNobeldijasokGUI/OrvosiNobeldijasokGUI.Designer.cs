namespace OrvosiNobeldijasokGUI
{
    partial class OrvosiNobeldijasokGUI
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
            this.Evlabel = new System.Windows.Forms.Label();
            this.Nevlabel = new System.Windows.Forms.Label();
            this.SzHlabel = new System.Windows.Forms.Label();
            this.Orszaglabel = new System.Windows.Forms.Label();
            this.NevText = new System.Windows.Forms.TextBox();
            this.SzHText = new System.Windows.Forms.TextBox();
            this.OrszagText = new System.Windows.Forms.TextBox();
            this.adatmentbutton = new System.Windows.Forms.Button();
            this.EvNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EvNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Evlabel
            // 
            this.Evlabel.AutoSize = true;
            this.Evlabel.Location = new System.Drawing.Point(21, 18);
            this.Evlabel.Name = "Evlabel";
            this.Evlabel.Size = new System.Drawing.Size(23, 13);
            this.Evlabel.TabIndex = 0;
            this.Evlabel.Text = "Év:";
            // 
            // Nevlabel
            // 
            this.Nevlabel.AutoSize = true;
            this.Nevlabel.Location = new System.Drawing.Point(14, 47);
            this.Nevlabel.Name = "Nevlabel";
            this.Nevlabel.Size = new System.Drawing.Size(30, 13);
            this.Nevlabel.TabIndex = 1;
            this.Nevlabel.Text = "Név:";
            // 
            // SzHlabel
            // 
            this.SzHlabel.AutoSize = true;
            this.SzHlabel.Location = new System.Drawing.Point(9, 75);
            this.SzHlabel.Name = "SzHlabel";
            this.SzHlabel.Size = new System.Drawing.Size(35, 13);
            this.SzHlabel.TabIndex = 2;
            this.SzHlabel.Text = "Sz/H:";
            // 
            // Orszaglabel
            // 
            this.Orszaglabel.AutoSize = true;
            this.Orszaglabel.Location = new System.Drawing.Point(9, 105);
            this.Orszaglabel.Name = "Orszaglabel";
            this.Orszaglabel.Size = new System.Drawing.Size(43, 13);
            this.Orszaglabel.TabIndex = 3;
            this.Orszaglabel.Text = "Ország:";
            // 
            // NevText
            // 
            this.NevText.Location = new System.Drawing.Point(70, 40);
            this.NevText.Name = "NevText";
            this.NevText.Size = new System.Drawing.Size(223, 20);
            this.NevText.TabIndex = 5;
            this.NevText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NevText_KeyPress);
            // 
            // SzHText
            // 
            this.SzHText.Location = new System.Drawing.Point(70, 68);
            this.SzHText.Name = "SzHText";
            this.SzHText.Size = new System.Drawing.Size(100, 20);
            this.SzHText.TabIndex = 6;
            this.SzHText.Text = "-";
            this.SzHText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SzHText_KeyPress);
            // 
            // OrszagText
            // 
            this.OrszagText.Location = new System.Drawing.Point(70, 98);
            this.OrszagText.Name = "OrszagText";
            this.OrszagText.Size = new System.Drawing.Size(51, 20);
            this.OrszagText.TabIndex = 7;
            this.OrszagText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrszagText_KeyPress);
            // 
            // adatmentbutton
            // 
            this.adatmentbutton.Location = new System.Drawing.Point(104, 151);
            this.adatmentbutton.Name = "adatmentbutton";
            this.adatmentbutton.Size = new System.Drawing.Size(102, 23);
            this.adatmentbutton.TabIndex = 8;
            this.adatmentbutton.Text = "Adatok mentése";
            this.adatmentbutton.UseVisualStyleBackColor = true;
            this.adatmentbutton.Click += new System.EventHandler(this.adatmentbutton_Click);
            // 
            // EvNum
            // 
            this.EvNum.Location = new System.Drawing.Point(70, 14);
            this.EvNum.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.EvNum.Minimum = new decimal(new int[] {
            1989,
            0,
            0,
            0});
            this.EvNum.Name = "EvNum";
            this.EvNum.Size = new System.Drawing.Size(51, 20);
            this.EvNum.TabIndex = 9;
            this.EvNum.Value = new decimal(new int[] {
            1989,
            0,
            0,
            0});
            // 
            // OrvosiNobeldijasokGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 208);
            this.Controls.Add(this.EvNum);
            this.Controls.Add(this.adatmentbutton);
            this.Controls.Add(this.OrszagText);
            this.Controls.Add(this.SzHText);
            this.Controls.Add(this.NevText);
            this.Controls.Add(this.Orszaglabel);
            this.Controls.Add(this.SzHlabel);
            this.Controls.Add(this.Nevlabel);
            this.Controls.Add(this.Evlabel);
            this.Name = "OrvosiNobeldijasokGUI";
            this.Text = "Orvosi Nobel-díjasok";
            ((System.ComponentModel.ISupportInitialize)(this.EvNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Evlabel;
        private System.Windows.Forms.Label Nevlabel;
        private System.Windows.Forms.Label SzHlabel;
        private System.Windows.Forms.Label Orszaglabel;
        private System.Windows.Forms.TextBox NevText;
        private System.Windows.Forms.TextBox SzHText;
        private System.Windows.Forms.TextBox OrszagText;
        private System.Windows.Forms.Button adatmentbutton;
        private System.Windows.Forms.NumericUpDown EvNum;
    }
}

