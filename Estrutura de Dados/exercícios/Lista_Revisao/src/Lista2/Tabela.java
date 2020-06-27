package Lista2;

public class Tabela
{

	private Double produto;
	private Double result;
	
	public Double getProduto() {
		return produto;
	}
	public void setProduto(Double produto) {
		this.produto = produto;
	}

	public Double getResult() {
		return result;
	}
	public void setResult(Double result) {
		this.result = result;
	}
	
	//Métodos
	
	public Double Cal1( Double produto)
	{
		Double result = produto * 1.15;
		return result;
	}
	
	public Double Cal3( Double produto)
	{
		Double result = produto * 1.2;
		return result;
	}
	
	public Double Cal4( Double produto)
	{
		Double result = produto * 1.35;
		return result;
	}
	
	public Double Cal8( Double produto)
	{
		Double result = produto * 1.40;
		return result;
	}
	
}
