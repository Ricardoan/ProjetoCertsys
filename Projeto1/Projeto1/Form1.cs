using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model1Container(); // prorpiedade da classe Model1.edmx
                Fornecedores lFornecedor = new Fornecedores();
                lFornecedor.Nome = textNome.Text;
                lFornecedor.CNPJ = textCNPJ.Text;
                lFornecedor.Endereco = textEndereco.Text;
                if (chkBox == "1")
                    lFornecedor.Ativo = chkBox; // checkAtivo.Text;
                else
                    lFornecedor.Ativo = "0";
             db.Fornecedoress.Add(lFornecedor);
                db.SaveChanges();
                MessageBox.Show("Cadastrado com sucesso");

            }
            catch (Exception )
            {
                MessageBox.Show("Não Cadastrado com sucesso");
                throw;
            }
            
        }

        
        private void checkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            Fornecedores lFornecedor = new Fornecedores();
            if (checkAtivo.Checked == true)
                chkBox = "1";
            else
                chkBox = "0";

        }
        public string chkBox { get; set; }

        private void Consulta_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.Fornecedoress' table. You can move, or remove it, as needed.
            this.fornecedoressTableAdapter.Fill(this.bancoDataSet.Fornecedoress);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var db = new Model1Container();
            GridViewConsulta.DataSource = db.Fornecedoress.ToList();
         
        }
        
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CadastroPanel_Click(object sender, EventArgs e)
        {

        }
    }

   
}
