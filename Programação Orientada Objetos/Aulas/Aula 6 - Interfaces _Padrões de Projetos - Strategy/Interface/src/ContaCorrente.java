
public class ContaCorrente implements Conta {

	private float saldo;
	
	
	public float getSaldo() {
		return saldo;
	}

	public void setSaldo(float saldo) {
		this.saldo = saldo;
	}

	@Override
	public void deposita(float valor) {
		this.saldo += valor;
		
	}

	@Override
	public void saca(float valor) {
		this.saldo -= valor;
		
	}

	@Override
	public float getSalto() {
		
		return this.saldo;
	}
	
	

	
}
