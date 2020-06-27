package ArtiumSys.Control;

import ArtiumSys.DAO.LoginDAO;

import ArtiumSys.DAO.JDBCLoginDAO;
import ArtiumSys.Model.Login;

public class VerificarLoginCtrl {
	
	public String verificarLogin(Login login){
		LoginDAO cd = new JDBCLoginDAO();
		return cd.verificarLogin(login);
	}

}
