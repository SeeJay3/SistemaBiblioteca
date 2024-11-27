using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public class Emprestimo : User
    {
        public Emprestimo(string nome, string cpf, string livro, string data) : base(nome, cpf)
        {
            Livro = livro;
            Data = data;
        }
        public string Livro { get; private set; }
        public string Data { get; private set; }

        public override string ToString()
        {
            return Usuario + " - " + CPF + " - " + Livro + " - " + Data;
        }
        
    }
}
