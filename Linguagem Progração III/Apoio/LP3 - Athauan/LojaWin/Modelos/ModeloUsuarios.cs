using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LojaWin.Modelos //colocar o nome da solution junto com o nome do projeto (LojaWin.Modelos) de todas as camadas

    //representa uma tabela com todas as variavel do banco de dados o DLL MODELOS
 
{
    public class ModeloUsuarios
    {
        //get = leitura - set= pega dados
       // private int idUsuario {get; set;} este é o modelo mair fácil

        private int idUsuario;
        public int IdUsuario 
        {

             get{return idUsuario;}
            set { idUsuario = value; }
         
         }

        private string nome;
        public string Nome 
        {

             get{ return nome; }
            set { nome = value; }
         
         }

        private string senha;
        public string Senha 
        {

             get{return senha;}
            set { senha = value; }
         
         }

    }
}
