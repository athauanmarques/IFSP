package Execicio;

public class exibicao {

	public static void main(String[] args) {
		gerentes g = new gerentes();
		secretarias s = new secretarias();
		telefonista t = new telefonista();
		
		g.setNome("athauan");
		g.setSalario(105200f);
		g.setNomeGerente("Marques");
		g.setSenhaGerente("sds1245");
		
		
		s.setNome("Maria");
		s.setSalario(1000f);
		s.setNumRamal(102452);
		
		t.setNome("ana");
		t.setSalario(7821f);
		t.setCodEstacao("12441551");
		
		
		System.out.println(g.getNome() + " o seu valor: " + g.CalcularBonificacao());
		System.out.println(s.getNome() + " o seu valor: " + s.CalcularBonificacao());
		System.out.println(t.getNome() + " o seu valor: " + t.CalcularBonificacao());

	}

}
