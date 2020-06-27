package Execicio;

public class gerentes  extends funcionario{
	private String nomeGerente ;
	private String senhaGerente;

	public String getNomeGerente() {
		return nomeGerente;
	}
	public void setNomeGerente(String nomeGerente) {
		this.nomeGerente = nomeGerente;
	}
	public String getSenhaGerente() {
		return senhaGerente;
	}
	public void setSenhaGerente(String senhaGerente) {
		this.senhaGerente = senhaGerente;
	}
	
	public double CalcularBonificacao()
	{
		return super.getSalario() * 0.2;
		//fez a sub-escrita do método(CalcularBonificacao()) da classe funcionário
	}
}
