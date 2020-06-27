package ArtiumSys.DAO;


import ArtiumSys.Model.Login;

public interface LoginDAO {
	
	public String verificarLogin(Login login);
	public String redefinirSenha(Login login);
	

}
