package ArtiumSys.Control;

import ArtiumSys.Model.Estoque;
import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Vendas;
import ArtiumSys.DAO.VendasDAO;
import ArtiumSys.DAO.JBDCVendasDAO;
import ArtiumSys.DAO.EstoqueDAO;
import ArtiumSys.DAO.JBDCEstoqueDAO;

public class CrudEstoqueVendasCtrl {
	public void EntradaProduto(Estoque estoque){
		EstoqueDAO cd = new JBDCEstoqueDAO();
		cd.EntradaProduto(estoque);
	}
	public void EditarProduto(Estoque estoque){
		EstoqueDAO cd = new JBDCEstoqueDAO();
		cd.EditarProduto(estoque);
		
	}
	public void DeletarProduto(Estoque estoque){
		EstoqueDAO cd = new JBDCEstoqueDAO();
		cd.DeletarProduto(estoque);
	}
	public void EfetuarCompra(Usuario usuario,Estoque estoque, Vendas venda){
		VendasDAO cd = new JBDCVendasDAO();
		cd.EfetuarCompra(usuario, estoque, venda);
		
	}

}
