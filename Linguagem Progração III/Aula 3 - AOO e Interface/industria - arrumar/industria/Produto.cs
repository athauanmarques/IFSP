using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace industria
{

     class Produto
    {
        private int codigo;
        private string produtos;
        private double estoque;
        private string status;
         private int preco;
        
        public int Codigo
        {
    
        get {return codigo;}
        set {value = codigo;}
    
    
        }
        
        public string Produtos
        {
        
            get {return produtos;}
            set {value = produtos;}
        
        }

        public double Estoque
        {
    
            get {return estoque;}
            set {value = estoque;}
        }

         public int Preco
        {
    
            get {return preco;}
            set {value = preco;}
        }

         public string Status
         {
         
             get {return status;}

         }

        public void AlterarStatus()
        {


            status = "Foi alterado com sucesso os seguites dados: \n Codigo:" + codigo + 
                "\n Produto" + produtos + "\n Estoque: " + estoque + "\n Preco: " + preco;
            
        
        }

           public void ExcluirStatus()
        {
        
               status = "Foi Excluido com sucesso os seguites dados: \n Codigo:" + codigo + 
                "\n Produto" + produtos + "\n Estoque: " + estoque + "\n Preco: " + preco;
        
        }

           public void IncluirStatus()
        {
        
               status = "Foi incluido com sucesso os seguites dados: \n Codigo:" + codigo + 
                "\n Produto" + produtos + "\n Estoque: " + estoque + "\n Preco: " + preco;
        

        }


    
    }
        
    }

