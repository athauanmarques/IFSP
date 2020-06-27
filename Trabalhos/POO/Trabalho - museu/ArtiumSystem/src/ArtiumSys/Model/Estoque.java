package ArtiumSys.Model;

public class Estoque {
	private int idEstoque;
	private String codProduto;
	private String produto;
	private String marca;
	private String descricaoProduto;
	private float preco;
	private int qtsEstoque;
	  
	public int getIdEstoque() {
		return idEstoque;
	}
	public void setIdEstoque(int idEstoque) {
		this.idEstoque = idEstoque;
	}
	public String getCodProduto() {
		return codProduto;
	}
	public void setCodProduto(String codProduto) {
		this.codProduto = codProduto;
	}
	public String getProduto() {
		return produto;
	}
	public void setProduto(String produto) {
		this.produto = produto;
	}
	public String getMarca() {
		return marca;
	}
	public void setMarca(String marca) {
		this.marca = marca;
	}
	public String getDescricaoProduto() {
		return descricaoProduto;
	}
	public void setDescricaoProduto(String descricaoProduto) {
		this.descricaoProduto = descricaoProduto;
	}
	public float getPreco() {
		return preco;
	}
	public void setPreco(float preco) {
		this.preco = preco;
	}
	public int getQtsEstoque() {
		return qtsEstoque;
	}
	public void setQtsEstoque(int qtsEstoque) {
		this.qtsEstoque = qtsEstoque;
	}
	  
	  

}
