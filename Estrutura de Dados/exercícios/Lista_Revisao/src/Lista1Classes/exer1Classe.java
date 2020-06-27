package Lista1Classes;

import javax.swing.JOptionPane;

public class exer1Classe {
	
	private String n1;
	private String n3;
	private String n2;
	private String status;
	private String status1;
	
	public String getStatus1() {
		return status1;
	}
	public void setStatus1(String status1) {
		this.status1 = status1;
	}
	public String getStatus() {
		return status;
	}
	public void setStatus(String status) {
		this.status = status;
	}
	public String getN1() {
		return n1;
	}
	public void setN1(String n1) {
		this.n1 = n1;
	}
	public String getN3() {
		return n3;
	}
	public void setN3(String n3) {
		this.n3 = n3;
	}
	public String getN2() {
		return n2;
	}
	public void setN2(String n2) {
		this.n2 = n2;
	}
	
	public void Ordenar(String n1, String n2, String n3)
	{
		status = n1 + " " + n3;
		status1 = n2;
		System.out.println(status);
		System.out.println("Nome do meio: " + status1);
	}

}
