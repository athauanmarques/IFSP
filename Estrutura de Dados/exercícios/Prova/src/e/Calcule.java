package e;

public class Calcule {

private Double n1;
private Double n2;
private Double result;

public Double getN1() {
	return n1;
}
public void setN1(Double n1) {
	this.n1 = n1;
}
public Double getN2() {
	return n2;
}
public void setN2(Double n2) {
	this.n2 = n2;
}
public Double getResult() {
	return result;
}
public void setResult(Double result) {
	this.result = result;
}

public Double Soma(Double n1, Double n2)
{
	result = n1 + n2;
	return result;
}

public Double Divisao(Double n1, Double n2)
{
	result = n1 / n2;
	return result;
}

public Double Mult(Double n1, Double n2)
{

	result = n1 * n2;
	return result;
}

public Double Sub(Double n1, Double n2)
{

	result = n1 - n2;
	return result;
}

	
}
