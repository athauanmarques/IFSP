package ArtiumSys.Control;

import ArtiumSys.Model.Acervo;
import ArtiumSys.Model.Restauracao;
import ArtiumSys.Model.Usuario;
import ArtiumSys.DAO.RestauracaoDAO;
import ArtiumSys.DAO.JDBCRestauracaoDAO;

public class ProcessoRestauracaoCtrl {
	public String SolicitarRestauracao(Acervo acervo, Usuario usuario, Restauracao restauracao){
		RestauracaoDAO cd = new JDBCRestauracaoDAO();
		return cd.SolicitarRestauracao(acervo, usuario, restauracao);
		
	}
	public void AlterarStatus(Acervo acervo, Usuario usuario,Restauracao restauracao){
		RestauracaoDAO cd = new JDBCRestauracaoDAO();
		cd.AlterarStatus(acervo, usuario, restauracao);
	}

}
