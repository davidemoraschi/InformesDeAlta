namespace InformesDeAlta
{
    partial class InformesDeAlta
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
            this.rTxt_Informe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTxt_Informe
            // 
            this.rTxt_Informe.Location = new System.Drawing.Point(12, 12);
            this.rTxt_Informe.Name = "rTxt_Informe";
            this.rTxt_Informe.Size = new System.Drawing.Size(884, 303);
            this.rTxt_Informe.TabIndex = 0;
            this.rTxt_Informe.Text = "";
            // 
            // InformesDeAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 396);
            this.Controls.Add(this.rTxt_Informe);
            this.Name = "InformesDeAlta";
            this.Text = "Informes de Alta";
            this.Load += new System.EventHandler(this.InformesDeAlta_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InformesDeAlta_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxt_Informe;
    }
}

