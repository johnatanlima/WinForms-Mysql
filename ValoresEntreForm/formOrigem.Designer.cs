namespace ValoresEntreForm
{
    partial class frmOrigem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtOrigem1 = new System.Windows.Forms.TextBox();
            this.btnPassar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrigem2 = new System.Windows.Forms.Label();
            this.txtOrigem2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(229, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(206, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Texto a ser transportado";
            // 
            // txtOrigem1
            // 
            this.txtOrigem1.Location = new System.Drawing.Point(37, 89);
            this.txtOrigem1.Multiline = true;
            this.txtOrigem1.Name = "txtOrigem1";
            this.txtOrigem1.Size = new System.Drawing.Size(424, 40);
            this.txtOrigem1.TabIndex = 1;
            // 
            // btnPassar
            // 
            this.btnPassar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassar.Location = new System.Drawing.Point(517, 139);
            this.btnPassar.Name = "btnPassar";
            this.btnPassar.Size = new System.Drawing.Size(128, 42);
            this.btnPassar.TabIndex = 2;
            this.btnPassar.Text = "Passar conteúdo";
            this.btnPassar.UseVisualStyleBackColor = true;
            this.btnPassar.Click += new System.EventHandler(this.btnPassar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto 1º Input Origem";
            // 
            // lblOrigem2
            // 
            this.lblOrigem2.AutoSize = true;
            this.lblOrigem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem2.Location = new System.Drawing.Point(34, 165);
            this.lblOrigem2.Name = "lblOrigem2";
            this.lblOrigem2.Size = new System.Drawing.Size(135, 16);
            this.lblOrigem2.TabIndex = 3;
            this.lblOrigem2.Text = "Texto 2º Input Origem";
            // 
            // txtOrigem2
            // 
            this.txtOrigem2.Location = new System.Drawing.Point(37, 184);
            this.txtOrigem2.Multiline = true;
            this.txtOrigem2.Name = "txtOrigem2";
            this.txtOrigem2.Size = new System.Drawing.Size(424, 40);
            this.txtOrigem2.TabIndex = 1;
            // 
            // frmOrigem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 304);
            this.Controls.Add(this.lblOrigem2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassar);
            this.Controls.Add(this.txtOrigem2);
            this.Controls.Add(this.txtOrigem1);
            this.Controls.Add(this.lblDescricao);
            this.Name = "frmOrigem";
            this.Text = "Origem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtOrigem1;
        private System.Windows.Forms.Button btnPassar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrigem2;
        private System.Windows.Forms.TextBox txtOrigem2;
    }
}

