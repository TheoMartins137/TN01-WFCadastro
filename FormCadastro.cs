using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastrar
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            cbx_escolaridade.SelectedIndex = 0;
        }

        private void limpar()
        {
            txt_nome.Clear();
            mkd_telefone.Clear();
            dtp_datanasc.Value = DateTime.Now;
            cbx_escolaridade.SelectedIndex = 0;
            rdb_masculino.Checked = false;
            rdb_feminino.Checked = false;
            rdb_naoinformado.Checked = false;
            nup_renda.Value = 0;
            chk_filhos.CheckState = CheckState.Indeterminate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            p1.NomeCompleto = txt_nome.Text;
            p1.DDDTelefone = mkd_telefone.Text;
            p1.DataNascimento = dtp_datanasc.Value;
            p1.Escolaridade = cbx_escolaridade.SelectedItem?.ToString();
            p1.RendaMensal = Convert.ToDouble(nup_renda.Value);
            
            if (rdb_masculino.Checked)
            {
                p1.Sexo = 'M';
            }
            else if (rdb_feminino.Checked)
            {
                p1.Sexo = 'F';
            }
            else if (rdb_naoinformado.Checked)
            {
                p1.Sexo = 'N';
            }
            else
            {
                MessageBox.Show("Sexo não informado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chk_filhos.CheckState == CheckState.Checked)
            {
                p1.PossuiFilhos = true;
            }
            else if (chk_filhos.CheckState == CheckState.Unchecked)
            {
                p1.PossuiFilhos = false;
            }
            else
            {
                MessageBox.Show("Faltou marcar se tem filhos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            Pessoa.ListaPessoas.Add(p1);

            MessageBox.Show("Cadastro Realizado Com Sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpar();
        }
    }
}
