namespace pazienti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.LW_paziente2 = new System.Windows.Forms.ListView();
            this.LW_paziente1 = new System.Windows.Forms.ListView();
            this.btn_paziente1 = new System.Windows.Forms.Button();
            this.btn_paziente2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LW_paziente2
            // 
            this.LW_paziente2.HideSelection = false;
            this.LW_paziente2.Location = new System.Drawing.Point(556, 12);
            this.LW_paziente2.Name = "LW_paziente2";
            this.LW_paziente2.Size = new System.Drawing.Size(232, 217);
            this.LW_paziente2.TabIndex = 0;
            this.LW_paziente2.UseCompatibleStateImageBehavior = false;
            // 
            // LW_paziente1
            // 
            this.LW_paziente1.HideSelection = false;
            this.LW_paziente1.Location = new System.Drawing.Point(12, 12);
            this.LW_paziente1.Name = "LW_paziente1";
            this.LW_paziente1.Size = new System.Drawing.Size(231, 217);
            this.LW_paziente1.TabIndex = 1;
            this.LW_paziente1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_paziente1
            // 
            this.btn_paziente1.Location = new System.Drawing.Point(12, 252);
            this.btn_paziente1.Name = "btn_paziente1";
            this.btn_paziente1.Size = new System.Drawing.Size(231, 82);
            this.btn_paziente1.TabIndex = 2;
            this.btn_paziente1.Text = "avvia paziente 1";
            this.btn_paziente1.UseVisualStyleBackColor = true;
            this.btn_paziente1.Click += new System.EventHandler(this.btn_paziente1_Click);
            // 
            // btn_paziente2
            // 
            this.btn_paziente2.Location = new System.Drawing.Point(556, 252);
            this.btn_paziente2.Name = "btn_paziente2";
            this.btn_paziente2.Size = new System.Drawing.Size(232, 82);
            this.btn_paziente2.TabIndex = 3;
            this.btn_paziente2.Text = "avvia paziente 2 ";
            this.btn_paziente2.UseVisualStyleBackColor = true;
            this.btn_paziente2.Click += new System.EventHandler(this.btn_paziente2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero corrente";
            // 
            // lbl_numero
            // 
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(376, 121);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(81, 74);
            this.lbl_numero.TabIndex = 5;
            this.lbl_numero.Text = "lbl da inserire numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_paziente2);
            this.Controls.Add(this.btn_paziente1);
            this.Controls.Add(this.LW_paziente1);
            this.Controls.Add(this.LW_paziente2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LW_paziente2;
        private System.Windows.Forms.ListView LW_paziente1;
        private System.Windows.Forms.Button btn_paziente1;
        private System.Windows.Forms.Button btn_paziente2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_numero;
    }
}

