using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProvaTreino.Modelos;
using ProvaTreino.DAL;

namespace ProvaTreino.BLL
{
    public class AlunoBLL
    {
        private string mensagem;
        public string Mensagem { get { return mensagem; } set { mensagem = value; } }

        AlunoDAL objAluno = new AlunoDAL();
       
        public void IncluirAluno(ModelosAluno aluno)
        {

            if (aluno.Nome.Trim().Length == 0)
            {
                mensagem = "Informe o campo nome.";
            }
            else
            { 
            
            
            }
        }
    
    }
}
