package ArtiumSys.DAO;

import java.util.ArrayList;

import ArtiumSys.Model.Acervo;
//import ArtiumSys.Model.Reservas_convites; // so exibir
import ArtiumSys.Model.Usuario;

public interface AcervoDAO {
	//public void QtsReservados(Acervo acervo);
	public void ReservarEvento(Acervo acervo, Usuario usuario);
	public void CancelarReserva(Acervo acervo,Usuario usuario);
	public void ExcluirAcervo(Acervo acervo);
	public String AdicionarAcervo(Acervo acervo);
	public ArrayList<Acervo> obterAcervo();
	public ArrayList<Acervo> listarTabela();
	public void editar(int tituloSelecionado) ;

	public ArrayList<Acervo> read();
	
}
