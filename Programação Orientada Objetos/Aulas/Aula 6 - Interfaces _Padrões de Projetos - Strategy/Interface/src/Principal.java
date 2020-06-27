
public class Principal {

	public static void main(String[] args) {
		ContaCorrente cc = new ContaCorrente();
		ContaPoupanca cp = new ContaPoupanca();
		//Poliforfismo
	    GerarExtratos g = new GerarExtratos(); 
		g.extratos(cc); //metodo do interface utilizado paramentro da classe para classe extratos
		
		cc.deposita(100f);
		cc.saca(50f);
		cc.getSalto();
		
		cp.deposita(200f);
		cp.saca(50f);
		cp.getSalto();
		
		System.out.println("poupança: " + cp.getSalto());
		System.out.println("Corrente: " + cc.getSalto());
	}

}
