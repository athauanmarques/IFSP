package ArtiumSys.DAO;

import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Login;

public interface UsuarioDAO {
	public String CadastrarVistante(Usuario usuario, Login login);
	public String CadastrarFuncionario(Usuario usuario, Login login);
	public String ExcluirConta(Usuario usuario);
	

}
