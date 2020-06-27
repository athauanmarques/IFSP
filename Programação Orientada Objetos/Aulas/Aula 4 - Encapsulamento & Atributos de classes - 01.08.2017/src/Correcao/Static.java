package Correcao;

public class Static {

	public static void main(String[] args) {
		
		System.out.print("" + Conta.numero);
		
		Conta c1 = new Conta();
		System.out.println(""+c1.numContas);
		
		System.out.print("" + Conta.numero);
		
		Conta c2 = new Conta();
		System.out.println(""+c2.numContas);
		
		System.out.print("" + Conta.numero);
		
		Conta.zerarContador();
		

	}

}
