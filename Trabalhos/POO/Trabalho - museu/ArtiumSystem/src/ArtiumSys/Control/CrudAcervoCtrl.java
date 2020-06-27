package ArtiumSys.Control;

import ArtiumSys.Model.Acervo;
import ArtiumSys.Model.Usuario;
import ArtiumSys.DAO.JBDCAcervoDAO;

import java.util.ArrayList;

import ArtiumSys.DAO.AcervoDAO;

public class CrudAcervoCtrl {
	
	public void ReservarEvento(Acervo acervo, Usuario usuario){
		AcervoDAO cd = new JBDCAcervoDAO();
			cd.ReservarEvento(acervo, usuario);
	}
	public void CancelarReserva(Acervo acervo,Usuario usuario){
		AcervoDAO cd = new JBDCAcervoDAO();
		cd.CancelarReserva(acervo, usuario);
	}
	public void ExcluirAcervo(Acervo acervo){
		AcervoDAO cd = new JBDCAcervoDAO();
		cd.ExcluirAcervo(acervo);
	}
	public String AdicionarAcervo(Acervo acervo){
		AcervoDAO cd = new JBDCAcervoDAO();
		return cd.AdicionarAcervo(acervo);
	}
	public ArrayList<Acervo> obterAcervo(){
		AcervoDAO cd = new JBDCAcervoDAO();
		return cd.obterAcervo();
	}
	public ArrayList<Acervo> listarTabela(){
		AcervoDAO cd = new JBDCAcervoDAO();
		 return cd.listarTabela();
	}
	public void editar(int tituloSelecionado){
		AcervoDAO cd = new JBDCAcervoDAO();
		cd.editar(tituloSelecionado);
		
	}
	public ArrayList<Acervo> read(){
		AcervoDAO cd = new JBDCAcervoDAO();
		return cd.read();
		
	}
}
