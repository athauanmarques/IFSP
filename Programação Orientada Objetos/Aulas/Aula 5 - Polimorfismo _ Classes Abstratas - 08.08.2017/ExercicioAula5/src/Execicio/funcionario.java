package Execicio;

public class funcionario {
private  String nome;
public String getNome() {
	return nome;
}
public void setNome(String nome) {
	this.nome = nome;
}
public float getSalario() {
	return salario;
}
public void setSalario(float salario) {
	this.salario = salario;
}
private float salario ;


public double CalcularBonificacao()
{
	return this.salario * 0.1;
}
}


