package Lista1Classes;

public class exer5Classe {
	//atributos
	private Double comprimento;
	private Double largura;
	private Double profundidade;
	private Double result;
	//propriedades
	public Double getComprimento() {
		return comprimento;
	}
	public void setComprimento(Double comprimento) {
		this.comprimento = comprimento;
	}
	public Double getLargura() {
		return largura;
	}
	public void setLargura(Double largura) {
		this.largura = largura;
	}
	public Double getProfundidade() {
		return profundidade;
	}
	public void setProfundidade(Double profundidade) {
		this.profundidade = profundidade;
	}
	public Double getResult() {
		return result;
	}
	public void setResult(Double result) {
		this.result = result;
	}
	//Métodos
	
	public Double Fazer(Double comprimento, Double largura, Double profundidade)
	{
		Double result = (comprimento * largura * profundidade)*45;
		return result;
	}
	

}
