package Lista2;

public class Calculo {
	
	private float hora;
	private float salarioHora;
	private float nDep;
	private float result;
	private float inss;
	
	public float getInss() {
		return inss;
	}
	public void setInss(float inss) {
		this.inss = inss;
	}
	
	public float getHora() {
		return hora;
	}
	public void setHora(float hora) {
		this.hora = hora;
	}
	public float getSalarioHora() {
		return salarioHora;
	}
	public void setSalarioHora(float salarioHora) {
		this.salarioHora = salarioHora;
	}
	public float getnDep() {
		return nDep;
	}
	public void setnDep(float nDep) {
		this.nDep = nDep;
	}
	public float getResult() {
		return result;
	}
	public void setResult(float result) {
		this.result = result;
	}
	
	
	public float SalarioBruto(float hora, float salarioHora, float nDep )
	{
		this.hora = hora;
		this.salarioHora = salarioHora;
		this.nDep = nDep;
		
		result = hora*salarioHora + (50*nDep);
		return result;
 		
	}
	



}
