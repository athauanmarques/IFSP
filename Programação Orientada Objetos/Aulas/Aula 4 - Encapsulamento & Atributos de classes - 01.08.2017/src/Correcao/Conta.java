package Correcao;

public class Conta {

	static int numero;
	int numContas;
	
	Conta()
	{
		Conta.numero ++; 
		// contador de objetos
		
		this.numContas = Conta.numero;
	}
	//Construtor para acessar o atributo static da classe;
	
	static void zerarContador() {
		System.out.println("Quantidade de contas anterior " + Conta.numero);
		Conta.numero = 0;
		System.out.println("Quantidade de contas atual " + Conta.numero);
	}
}
