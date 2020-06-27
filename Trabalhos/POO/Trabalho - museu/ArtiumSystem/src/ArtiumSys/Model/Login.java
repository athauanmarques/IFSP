package ArtiumSys.Model;

public class Login {
	
	private int idLogin;
	private String nome;
	private String codCartao;
	private String senha;
	private String tipoAcesso;
	 
	public int getIdLogin() {
		return idLogin;
	}
	public void setIdLogin(int idLogin) {
		this.idLogin = idLogin;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getCodCartao() {
		return codCartao;
	}
	public void setCodCartao(String codCartao) {
		this.codCartao = codCartao;
	}
	public String getSenha() {
		return senha;
	}
	public void setSenha(String senha) {
		this.senha = senha;
	}
	public String getTipoAcesso() {
		return tipoAcesso;
	}
	public void setTipoAcesso(String tipoAcesso) {
		this.tipoAcesso = tipoAcesso;
	}

	 
}
