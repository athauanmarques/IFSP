package ArtiumSys.Control;

import ArtiumSys.DAO.JDBCUsuarioDAO;
import ArtiumSys.DAO.UsuarioDAO;
import ArtiumSys.Model.Usuario;

import ArtiumSys.Model.Login;


public class ContaCtrl {
	public String CadastrarVistante(Usuario usuario, Login login){
		UsuarioDAO cd = new JDBCUsuarioDAO();
		return cd.CadastrarVistante(usuario, login);
		}
		
	public String CadastrarFuncionario(Usuario usuario, Login login){
		UsuarioDAO cd = new JDBCUsuarioDAO();
		return cd.CadastrarFuncionario(usuario, login);
		}
	public String ExcluirConta(Usuario usuario){
		UsuarioDAO cd = new JDBCUsuarioDAO();
		return cd.ExcluirConta(usuario);
		}
		
	}


