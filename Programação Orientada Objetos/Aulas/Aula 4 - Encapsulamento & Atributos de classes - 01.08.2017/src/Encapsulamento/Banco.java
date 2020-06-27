package Encapsulamento;

public class Banco {

	public static void main(String[] args) {
		Funcionario f = new Funcionario();
/*
		f.nome ="Athauan";
		f.salario = 2000;
	*/
		/*
		f.alterarNome("Athauan");
		f.alterarSalario(2000.25);
		System.out.println("O funcionario " + f.consultaNome() + " recebe r$ " + f.consultaSalario());
*/
		
		f.setNome("Athauan");
		f.setSalario(2000.25);
		System.out.println("O funcionario " + f.getNome() + " recebe r$ " + f.getSalario());
		
		
	}

}
