package Lista1Classes;

public class exer2Classe {
	
	

	private Double vlr1;
	private Double vlr2;
	private Double vlr3;
	private Double qts1;
	private Double qts2;
	private Double qts3;
	
	private Double total;
	
	public Double getTotal() {
		return total;
	}
	public void setTotal(Double total) {
		this.total = total;
	}	
	
	public Double getVlr1() {
		return vlr1;
	}
	public void setVlr1(Double vlr1) {
		this.vlr1 = vlr1;
	}
	public Double getVlr2() {
		return vlr2;
	}
	public void setVlr2(Double vlr2) {
		this.vlr2 = vlr2;
	}
	public Double getVlr3() {
		return vlr3;
	}
	public void setVlr3(Double vlr3) {
		this.vlr3 = vlr3;
	}
	public Double getQts1() {
		return qts1;
	}
	public void setQts1(Double qts1) {
		this.qts1 = qts1;
	}
	public Double getQts2() {
		return qts2;
	}
	public void setQts2(Double qts2) {
		this.qts2 = qts2;
	}
	public Double getQts3() {
		return qts3;
	}
	public void setQts3(Double qts3) {
		this.qts3 = qts3;
	}

	
	public Double Calcular(Double vlr1,Double vlr2,Double vlr3,Double qts1,Double qts2,Double qts3)
	{
		
		Double total = (vlr1 * qts1) + (vlr2 * qts2) + (vlr3 * qts3);
		return total;
		
	}
	
	
}
