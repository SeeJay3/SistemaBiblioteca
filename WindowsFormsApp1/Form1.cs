using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string cpf = txtCPF.Text;
            string livro = txtBook.Text;
            string data = txtDate.Text;
            Emprestimo emp = new Emprestimo(usuario, cpf, livro, data);

            lstEmp.Items.Add(emp.ToString());
            

            LimparCaixas();
        }
        private void LimparCaixas()
        {
            txtCPF.Clear();
            txtUser.Clear();
            txtBook.Clear();
            txtDate.Clear();
        }
        private void VerificarCaixasPreenchidas()
        {
            if (txtUser.Text != "" && txtCPF.Text != "" && txtBook.Text != "" && txtDate.Text != "")
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void txtBook_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void lstEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmp.SelectedIndex != -1)
                btnDevolver.Enabled = true;
            else btnDevolver.Enabled = false;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstEmp.SelectedIndex;
            if (selectedIndex != -1)
            {
                lstEmp.Items.RemoveAt(selectedIndex);
            }
        }
        
    }
}
