namespace Projeto1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CadastroPanel = new System.Windows.Forms.TabPage();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textCNPJ = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.GridViewConsulta = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CadastroPanel.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CadastroPanel);
            this.tabControl1.Controls.Add(this.Consulta);
            this.tabControl1.Location = new System.Drawing.Point(100, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 323);
            this.tabControl1.TabIndex = 1;
            // 
            // CadastroPanel
            // 
            this.CadastroPanel.Controls.Add(this.checkAtivo);
            this.CadastroPanel.Controls.Add(this.btExcluir);
            this.CadastroPanel.Controls.Add(this.btSalvar);
            this.CadastroPanel.Controls.Add(this.textEndereco);
            this.CadastroPanel.Controls.Add(this.textCNPJ);
            this.CadastroPanel.Controls.Add(this.textNome);
            this.CadastroPanel.Controls.Add(this.label3);
            this.CadastroPanel.Controls.Add(this.label2);
            this.CadastroPanel.Controls.Add(this.label1);
            this.CadastroPanel.Location = new System.Drawing.Point(4, 22);
            this.CadastroPanel.Name = "CadastroPanel";
            this.CadastroPanel.Padding = new System.Windows.Forms.Padding(3);
            this.CadastroPanel.Size = new System.Drawing.Size(593, 297);
            this.CadastroPanel.TabIndex = 0;
            this.CadastroPanel.Text = "Cadastro";
            this.CadastroPanel.UseVisualStyleBackColor = true;
            // 
            // checkAtivo
            // 
            this.checkAtivo.AutoSize = true;
            this.checkAtivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkAtivo.Location = new System.Drawing.Point(94, 152);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkAtivo.TabIndex = 9;
            this.checkAtivo.Text = "Ativo";
            this.checkAtivo.UseVisualStyleBackColor = true;
            this.checkAtivo.CheckedChanged += new System.EventHandler(this.checkAtivo_CheckedChanged);
            // 
            // btExcluir
            // 
            this.btExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btExcluir.Location = new System.Drawing.Point(94, 205);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalvar.Location = new System.Drawing.Point(346, 205);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(94, 116);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(327, 20);
            this.textEndereco.TabIndex = 5;
            // 
            // textCNPJ
            // 
            this.textCNPJ.Location = new System.Drawing.Point(94, 87);
            this.textCNPJ.Name = "textCNPJ";
            this.textCNPJ.Size = new System.Drawing.Size(327, 20);
            this.textCNPJ.TabIndex = 4;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(94, 54);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(327, 20);
            this.textNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.button1);
            this.Consulta.Controls.Add(this.GridViewConsulta);
            this.Consulta.Controls.Add(this.btnPesquisar);
            this.Consulta.Controls.Add(this.textBox1);
            this.Consulta.Controls.Add(this.label4);
            this.Consulta.Location = new System.Drawing.Point(4, 22);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(593, 297);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(28, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GridViewConsulta
            // 
            this.GridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewConsulta.Location = new System.Drawing.Point(28, 87);
            this.GridViewConsulta.Name = "GridViewConsulta";
            this.GridViewConsulta.Size = new System.Drawing.Size(552, 150);
            this.GridViewConsulta.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(434, 256);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(146, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(25, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pesquisar";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.CadastroPanel.ResumeLayout(false);
            this.CadastroPanel.PerformLayout();
            this.Consulta.ResumeLayout(false);
            this.Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CadastroPanel;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textCNPJ;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridViewConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}