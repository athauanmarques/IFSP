package ArtiumSys.Model;

public class Vendas {
	
	private int idEstoque_tbEstoque;
	private int idUsuario_tbUsuario;
	private int quantidadeVendas;
	private String dataVenda; //na inserção, o banco realiza o tratamento
	  
	public int getIdEstoque_tbEstoque() {
		return idEstoque_tbEstoque;
	}
	public void setIdEstoque_tbEstoque(int idEstoque_tbEstoque) {
		this.idEstoque_tbEstoque = idEstoque_tbEstoque;
	}
	public int getIdUsuario_tbUsuario() {
		return idUsuario_tbUsuario;
	}
	public void setIdUsuario_tbUsuario(int idUsuario_tbUsuario) {
		this.idUsuario_tbUsuario = idUsuario_tbUsuario;
	}
	public int getQuantidadeVendas() {
		return quantidadeVendas;
	}
	public void setQuantidadeVendas(int quantidadeVendas) {
		this.quantidadeVendas = quantidadeVendas;
	}
	public String getDataVenda() {
		return dataVenda;
	}
	public void setDataVenda(String dataVenda) {
		this.dataVenda = dataVenda;
	}
	  
	  

}
