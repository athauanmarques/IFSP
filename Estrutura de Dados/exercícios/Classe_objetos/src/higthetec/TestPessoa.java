package higthetec;

public class TestPessoa {

	/*
	 * est� classe � o principal que vai ser exibida para o usu�rio
	 * aqui vai conter as classes de v�rias pessoas
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		
		Pessoa pessoa1; //declara��o - esta criando uma variavel pessoa1 da Classe Pessoa
		pessoa1 = new Pessoa(); // instanciando o objeto, construindo um objeto de pessoa1
		pessoa1.nome="Jo�o"; // sintaxe (classe.atributoDaClasse = "valores")
		pessoa1.sexo='M'; // apostolo no 'M' para reconhecer caracter 		
		System.out.println(pessoa1.nome + " " + pessoa1.sexo);// o operador " . " serve para referenciar o atributo de uma classe
		
		Pessoa pessoa2;
		pessoa2 = new Pessoa(); 
		pessoa2.nome="Jo�o"; 
		pessoa2.sexo='M'; 		
		System.out.println(pessoa2.nome + " " + pessoa2.sexo);
		
		Pessoa pessoa3;
		pessoa3 = new Pessoa(); 
		pessoa3.nome="Maria"; 
		pessoa3.sexo='F'; 		
		System.out.println(pessoa3.nome + " " + pessoa3.sexo);

		//Continue https://www.youtube.com/watch?v=FSDtRqRcL4E&list=WL&index=36
		//14:37 min de 1:00:40
	}

}
