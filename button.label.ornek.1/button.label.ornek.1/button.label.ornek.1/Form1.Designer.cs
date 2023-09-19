namespace button.label.ornek._1
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
            this.btnferner = new System.Windows.Forms.Button();
            this.btnbesiktas = new System.Windows.Forms.Button();
            this.btngalatasaray = new System.Windows.Forms.Button();
            this.btntrabzonspor = new System.Windows.Forms.Button();
            this.lblTakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnferner
            // 
            this.btnferner.Location = new System.Drawing.Point(24, 12);
            this.btnferner.Name = "btnferner";
            this.btnferner.Size = new System.Drawing.Size(92, 94);
            this.btnferner.TabIndex = 0;
            this.btnferner.Text = "FENERBAHÇE";
            this.btnferner.UseVisualStyleBackColor = true;
            this.btnferner.Click += new System.EventHandler(this.btnfenerbahce_Click);
            // 
            // btnbesiktas
            // 
            this.btnbesiktas.Location = new System.Drawing.Point(137, 12);
            this.btnbesiktas.Name = "btnbesiktas";
            this.btnbesiktas.Size = new System.Drawing.Size(86, 94);
            this.btnbesiktas.TabIndex = 1;
            this.btnbesiktas.Text = "BEŞİKTAŞ";
            this.btnbesiktas.UseVisualStyleBackColor = true;
            this.btnbesiktas.Click += new System.EventHandler(this.btnbesiktas_Click);
            // 
            // btngalatasaray
            // 
            this.btngalatasaray.Location = new System.Drawing.Point(238, 12);
            this.btngalatasaray.Name = "btngalatasaray";
            this.btngalatasaray.Size = new System.Drawing.Size(98, 94);
            this.btngalatasaray.TabIndex = 2;
            this.btngalatasaray.Text = "GALATASARAY";
            this.btngalatasaray.UseVisualStyleBackColor = true;
            this.btngalatasaray.Click += new System.EventHandler(this.btngalatasaray_Click);
            // 
            // btntrabzonspor
            // 
            this.btntrabzonspor.Location = new System.Drawing.Point(368, 12);
            this.btntrabzonspor.Name = "btntrabzonspor";
            this.btntrabzonspor.Size = new System.Drawing.Size(97, 94);
            this.btntrabzonspor.TabIndex = 3;
            this.btntrabzonspor.Text = "TRABZONSPOR";
            this.btntrabzonspor.UseVisualStyleBackColor = true;
            this.btntrabzonspor.Click += new System.EventHandler(this.btntrabzonspor_Click);
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakim.Location = new System.Drawing.Point(30, 181);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(207, 33);
            this.lblTakim.TabIndex = 4;
            this.lblTakim.Text = "TAKIMCIKLAR";
            this.lblTakim.Click += new System.EventHandler(this.lblTakim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 378);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.btntrabzonspor);
            this.Controls.Add(this.btngalatasaray);
            this.Controls.Add(this.btnbesiktas);
            this.Controls.Add(this.btnferner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnferner;
        private System.Windows.Forms.Button btnbesiktas;
        private System.Windows.Forms.Button btngalatasaray;
        private System.Windows.Forms.Button btntrabzonspor;
        private System.Windows.Forms.Label lblTakim;
    }
}

