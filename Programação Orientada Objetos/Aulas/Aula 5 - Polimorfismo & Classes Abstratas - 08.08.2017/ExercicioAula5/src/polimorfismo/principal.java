package polimorfismo;

public class principal {

	public static void main(String[] args) {
		poupanca pc = new poupanca();
		corrente cc = new corrente();

		pc.setSaldo(500);
		cc.setSaldo(100);
		
		gerarSaldos g = new gerarSaldos();
		g.imprimirSaldo(pc); // passando objeto como se fosse da classe principal (super classe)
		g.imprimirSaldo(cc);

	}

}
