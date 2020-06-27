package classes_abstratas;

public class Poupanca extends Conta {
	private int diaAniver;

	public int getDiaAniver() {
		return diaAniver;
	}

	public void setDiaAniver(int diaAniver) {
		this.diaAniver = diaAniver;
	}

	@Override
	public void taxaConta() {
		// override é uma subescrita
		
		System.out.println("seu saldo" + super.getsaldo());//super da classa herdando
		
	}

	

	
	
	
}
