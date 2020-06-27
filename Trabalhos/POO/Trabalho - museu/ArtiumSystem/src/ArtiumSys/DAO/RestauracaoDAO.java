package ArtiumSys.DAO;

import ArtiumSys.Model.Restauracao;
import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Acervo;;

public interface RestauracaoDAO {
	public String SolicitarRestauracao(Acervo acervo, Usuario usuario, Restauracao restauracao);
	public void AlterarStatus(Acervo acervo, Usuario usuario,Restauracao restauracao);
	//listar Restauracao

}
