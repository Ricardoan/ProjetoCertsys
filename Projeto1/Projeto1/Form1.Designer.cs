namespace Projeto1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoDataSet = new Projeto1.BancoDataSet();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fornecedoressTableAdapter = new Projeto1.BancoDataSetTableAdapters.FornecedoressTableAdapter();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.CadastroPanel.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).BeginInit();
          // ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CadastroPanel);
            this.tabControl1.Controls.Add(this.Consulta);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
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
            resources.ApplyResources(this.CadastroPanel, "CadastroPanel");
            this.CadastroPanel.Name = "CadastroPanel";
            this.CadastroPanel.UseVisualStyleBackColor = true;
            this.CadastroPanel.Click += new System.EventHandler(this.CadastroPanel_Click);
            // 
            // checkAtivo
            // 
            resources.ApplyResources(this.checkAtivo, "checkAtivo");
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.UseVisualStyleBackColor = true;
            this.checkAtivo.CheckedChanged += new System.EventHandler(this.checkAtivo_CheckedChanged);
            // 
            // btExcluir
            // 
            resources.ApplyResources(this.btExcluir, "btExcluir");
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            resources.ApplyResources(this.btSalvar, "btSalvar");
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // textEndereco
            // 
            resources.ApplyResources(this.textEndereco, "textEndereco");
            this.textEndereco.Name = "textEndereco";
            // 
            // textCNPJ
            // 
            resources.ApplyResources(this.textCNPJ, "textCNPJ");
            this.textCNPJ.Name = "textCNPJ";
            // 
            // textNome
            // 
            resources.ApplyResources(this.textNome, "textNome");
            this.textNome.Name = "textNome";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.button1);
            this.Consulta.Controls.Add(this.GridViewConsulta);
            this.Consulta.Controls.Add(this.btnPesquisar);
            this.Consulta.Controls.Add(this.textBox1);
            this.Consulta.Controls.Add(this.label4);
            resources.ApplyResources(this.Consulta, "Consulta");
            this.Consulta.Name = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GridViewConsulta
            // 
            this.GridViewConsulta.AutoGenerateColumns = false;
            this.GridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn});
            this.GridViewConsulta.DataSource = this.fornecedoressBindingSource;
            resources.ApplyResources(this.GridViewConsulta, "GridViewConsulta");
            this.GridViewConsulta.Name = "GridViewConsulta";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            resources.ApplyResources(this.nomeDataGridViewTextBoxColumn, "nomeDataGridViewTextBoxColumn");
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            resources.ApplyResources(this.cNPJDataGridViewTextBoxColumn, "cNPJDataGridViewTextBoxColumn");
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            resources.ApplyResources(this.enderecoDataGridViewTextBoxColumn, "enderecoDataGridViewTextBoxColumn");
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "Ativo";
            resources.ApplyResources(this.ativoDataGridViewTextBoxColumn, "ativoDataGridViewTextBoxColumn");
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            // 
            // fornecedoressBindingSource
            // 
            this.fornecedoressBindingSource.DataMember = "Fornecedoress";
            this.fornecedoressBindingSource.DataSource = this.bancoDataSet;
            // 
            // bancoDataSet
            // 
            this.bancoDataSet.DataSetName = "BancoDataSet";
            this.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // fornecedoressTableAdapter
            // 
            this.fornecedoressTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            resources.ApplyResources(this.contextMenuStrip3, "contextMenuStrip3");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CadastroPanel.ResumeLayout(false);
            this.CadastroPanel.PerformLayout();
            this.Consulta.ResumeLayout(false);
            this.Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CadastroPanel;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCNPJ;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.DataGridView GridViewConsulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private BancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource fornecedoressBindingSource;
        private BancoDataSetTableAdapters.FornecedoressTableAdapter fornecedoressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
       
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    }
}

