package ArtiumSys.Model;


public class Usuario {
	
	  private int idUsuario;
	  private String telefone;
	  private String dataNascimento;
	  private String sexo;
	  private String email;
	  private boolean receberConvite;
	  private String cargo;
	  private String numeroRA;
	  private int idLogin_tbLogin;
	public int getIdUsuario() {
		return idUsuario;
	}
	public void setIdUsuario(int idUsuario) {
		this.idUsuario = idUsuario;
	}
	public String getTelefone() {
		return telefone;
	}
	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}
	public String getDataNascimento() {
		return dataNascimento;
	}
	public void setDataNascimento(String string) {
		this.dataNascimento = string;
	}
	public String getSexo() {
		return sexo;
	}
	public void setSexo(String sexo) {
		this.sexo = sexo;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public boolean isReceberConvite() {
		return receberConvite;
	}
	public void setReceberConvite(boolean receberConvite) {
		this.receberConvite = receberConvite;
	}
	public String getCargo() {
		return cargo;
	}
	public void setCargo(String cargo) {
		this.cargo = cargo;
	}
	public String getNumeroRA() {
		return numeroRA;
	}
	public void setNumeroRA(String numeroRA) {
		this.numeroRA = numeroRA;
	}
	public int getIdLogin_tbLogin() {
		return idLogin_tbLogin;
	}
	public void setIdLogin_tbLogin(int idLogin_tbLogin) {
		this.idLogin_tbLogin = idLogin_tbLogin;
	}
	  
	  

}
