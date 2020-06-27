
public class ContaPoupanca implements Conta{
private float saldo;
	
	
	public float getSaldo() {
		return this.saldo;
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
