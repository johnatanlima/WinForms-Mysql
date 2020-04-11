namespace ValoresEntreForm
{
    partial class formDestino
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
            this.txtDestino1 = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.txtDestino2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDestino1
            // 
            this.txtDestino1.Location = new System.Drawing.Point(38, 86);
            this.txtDestino1.Multiline = true;
            this.txtDestino1.Name = "txtDestino1";
            this.txtDestino1.Size = new System.Drawing.Size(265, 31);
            this.txtDestino1.TabIndex = 0;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(103, 28);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(174, 21);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Dados do Form Destino";
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.Location = new System.Drawing.Point(35, 67);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(91, 16);
            this.lblInput1.TabIndex = 2;
            this.lblInput1.Text = "Texto 1º  input";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput2.Location = new System.Drawing.Point(35, 149);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(91, 16);
            this.lblInput2.TabIndex = 2;
            this.lblInput2.Text = "Texto 2º  input";
            // 
            // txtDestino2
            // 
            this.txtDestino2.Location = new System.Drawing.Point(38, 168);
            this.txtDestino2.Multiline = true;
            this.txtDestino2.Name = "txtDestino2";
            this.txtDestino2.Size = new System.Drawing.Size(265, 31);
            this.txtDestino2.TabIndex = 0;
            // 
            // formDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 234);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino2);
            this.Controls.Add(this.txtDestino1);
            this.Name = "formDestino";
            this.Text = "Destino";
            this.Load += new System.EventHandler(this.formDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.TextBox txtDestino2;
    }
}