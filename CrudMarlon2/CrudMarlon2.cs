using CrudMarlon2.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudMarlon2
{
    public partial class CrudMarlon2 : Form
    {
        Connection Con;

        public CrudMarlon2()
        {
            InitializeComponent();
        }

        public void Inserir()
        {
            PessoaPst Pessoa;


            Con = new Connection();

            try
            {
                Pessoa = new PessoaPst()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text
                };


                Con.OpenCon();
                Con.OpenAdpter(Pessoa.Inserir());
                Con.Cmd = new System.Data.SqlClient.SqlCommand(Pessoa.Inserir(), Con.Con);
                Con.Cmd.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
            finally
            {
                Con.CloseCon();
            }


        }

        public void Excluir()
        {
            PessoaPst Pessoa;

            Con = new Connection();

            try
            {
                Pessoa = new PessoaPst()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text
                };

                Con.OpenCon();
                Con.OpenAdpter(Pessoa.Excluir());
                Con.Cmd = new System.Data.SqlClient.SqlCommand(Pessoa.Excluir(), Con.Con);
                Con.Cmd.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
            finally
            {
                Con.CloseCon();
            }
        }

        public void Pesquisar()
        {
            PessoaPst Pessoa;
            DataTable Table;

            Con = new Connection();

            try
            {
                Pessoa = new PessoaPst();

                Con.OpenCon();
                Table = new DataTable();
                Con.OpenAdpter(Pessoa.Pesquisar());
                Con.Adapt.Fill(Table);
                dtgTable.DataSource = Table;
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
            finally
            {
                Con.CloseCon();
            }
        }

        public void Alterar()
        {
            PessoaPst Pessoa;

            Con = new Connection();

            try
            {
                Pessoa = new PessoaPst()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text
                };


                Con.OpenCon();
                Con.OpenAdpter(Pessoa.Alterar());
                Con.Cmd = new System.Data.SqlClient.SqlCommand(Pessoa.Alterar(), Con.Con);
                Con.Cmd.ExecuteNonQuery();
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
            finally
            {
                Con.CloseCon();
            }


        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void CrudMarlon2_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
