package classes_abstratas;

abstract public class Conta {
	//da erro se estancia como abstract o objeto, pois é uma classe modelo para outras classes
	private double saldo;

	public double getsaldo() { return saldo;}

	public void setConta(double saldo) {this.saldo = saldo;}
	
	
	public abstract void taxaConta(); //apenas assisnatura
	

}
