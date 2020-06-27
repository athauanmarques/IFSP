package ArtiumSys.DAO;
import ArtiumSys.Model.Estoque;

public interface EstoqueDAO {
	public void EntradaProduto(Estoque estoque);
	public void EditarProduto(Estoque estoque);
	public void DeletarProduto(Estoque estoque);

}
