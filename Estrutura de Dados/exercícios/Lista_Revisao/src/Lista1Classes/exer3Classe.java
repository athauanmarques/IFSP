package Lista1Classes;

import javax.swing.JOptionPane;

public class exer3Classe {
	
	private Double comprimento;
	private Double largura;
	private Double area;
	
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
	public Double getArea() {
		return area;
	}
	public void setArea(Double area) {
		this.area = area;
	}
	
	public Double CalcuraArea(Double comprimento, Double largura)
	{
		Double area = comprimento * largura;
		return area;
	}
	

}
