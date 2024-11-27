using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    public abstract class User
    {
        public string Usuario { get; set; }
        public string CPF { get; protected set; }
        public List<Emprestimo> Emprestimos { get; set; }
        public User(string nome, string cpf)
        {
            Usuario = nome;
            CPF = cpf;
        }
        public abstract string ToString();
        
      
        
    }
}
