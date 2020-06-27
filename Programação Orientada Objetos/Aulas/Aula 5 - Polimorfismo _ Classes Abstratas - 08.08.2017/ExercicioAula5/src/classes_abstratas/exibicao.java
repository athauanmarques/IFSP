package classes_abstratas;

public class exibicao {

	public static void main(String[] args) {
		//Conta c = new Conta(); // não estanciar pois esta com abstrato
		
		Conta c = new Poupanca(); //usando o Polimorfismo
		
		c.setConta(1000);
		c.taxaConta();

	}
	

}
