using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    //não esqueça de fazer a referencia antes de 
    //usar no form do projeto Loja

    // adicione a palavra chave "public" antes da classe
    public class NotasFiscais: INotaFiscal
    {
        //criada todas as propriedades do formulario vendas
       private string razao = "";        
       private DateTime data;
       private string endereco = "";
       private string cidade = "";
       private int cnpj= 0;
       private double valor = 0;
       private int cep = 0;
       private string estado = "";
       private string status = "";

       public string Razao
        {
            get {return razao;}
            set { razao = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void Gerar()
        {
            status = "Nota Fiscal Gerada: " + razao + " "
                + data + " "
                + endereco + " "
                + cidade + " "
                + cnpj + " "
                + valor + " "
                + cep + " "
                + estado;
        }
    }
}
