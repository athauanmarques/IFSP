package ArtiumSys.DAO;

import ArtiumSys.Model.Vendas; // listar
import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Estoque;


public interface VendasDAO {
	
	public void EfetuarCompra(Usuario usuario,Estoque estoque, Vendas venda);
	//GerarRelat�rio de vendas
}
