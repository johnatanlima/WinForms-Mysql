namespace ProjetoEscola
{
    partial class FormMain
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dgPessoas = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.panelEndereco = new System.Windows.Forms.Panel();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.mkTel = new System.Windows.Forms.MaskedTextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoas)).BeginInit();
            this.panelEndereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(47, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(47, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(352, 85);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // dgPessoas
            // 
            this.dgPessoas.AllowUserToAddRows = false;
            this.dgPessoas.AllowUserToDeleteRows = false;
            this.dgPessoas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoas.Location = new System.Drawing.Point(15, 34);
            this.dgPessoas.Name = "dgPessoas";
            this.dgPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPessoas.Size = new System.Drawing.Size(453, 209);
            this.dgPessoas.TabIndex = 11;
            this.dgPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPessoas_CellDoubleClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(50, 54);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(154, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 20);
            this.txtNome.TabIndex = 1;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(355, 101);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(159, 21);
            this.cbSexo.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.Location = new System.Drawing.Point(482, 204);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 39);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(482, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 39);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(482, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 39);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(482, 148);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(106, 39);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(12, 23);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 20;
            this.lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(15, 39);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(420, 20);
            this.txtRua.TabIndex = 5;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(345, 72);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(19, 13);
            this.lblNum.TabIndex = 22;
            this.lblNum.Text = "Nº";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(348, 88);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(87, 20);
            this.txtNum.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 72);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 88);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(300, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // panelEndereco
            // 
            this.panelEndereco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelEndereco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEndereco.Controls.Add(this.cbUf);
            this.panelEndereco.Controls.Add(this.lblUf);
            this.panelEndereco.Controls.Add(this.txtCidade);
            this.panelEndereco.Controls.Add(this.lblCidade);
            this.panelEndereco.Controls.Add(this.txtRua);
            this.panelEndereco.Controls.Add(this.lblNum);
            this.panelEndereco.Controls.Add(this.txtNum);
            this.panelEndereco.Controls.Add(this.txtBairro);
            this.panelEndereco.Controls.Add(this.lblRua);
            this.panelEndereco.Controls.Add(this.lblBairro);
            this.panelEndereco.Location = new System.Drawing.Point(48, 243);
            this.panelEndereco.Name = "panelEndereco";
            this.panelEndereco.Size = new System.Drawing.Size(609, 206);
            this.panelEndereco.TabIndex = 4;
            // 
            // cbUf
            // 
            this.cbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cbUf.Location = new System.Drawing.Point(348, 148);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(87, 21);
            this.cbUf.TabIndex = 9;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(345, 132);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 28;
            this.lblUf.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(15, 148);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(300, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(12, 132);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 26;
            this.lblCidade.Text = "Cidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgPessoas);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(48, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 249);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exibir Resultados";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(47, 134);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(22, 13);
            this.lblTel.TabIndex = 28;
            this.lblTel.Text = "Tel";
            // 
            // mkTel
            // 
            this.mkTel.Location = new System.Drawing.Point(50, 150);
            this.mkTel.Mask = "(00) 00000-0000";
            this.mkTel.Name = "mkTel";
            this.mkTel.Size = new System.Drawing.Size(279, 20);
            this.mkTel.TabIndex = 3;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(259, 216);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(75, 16);
            this.lblEnd.TabIndex = 30;
            this.lblEnd.Text = "Endereço";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(691, 745);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.mkTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelEndereco);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software - Pessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoas)).EndInit();
            this.panelEndereco.ResumeLayout(false);
            this.panelEndereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DataGridView dgPessoas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Panel panelEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox mkTel;
        private System.Windows.Forms.Label lblEnd;
    }
}