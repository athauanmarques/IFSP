package exe;

public class VariaveisInteiras {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		byte idade = 127;
		byte incredimento = 5;
		
		// casting (cast)
		/*
		 * A soma de duas variaveis inteiras, independente do tipo,
		 * fornece como resultado um inteiro. Se for necessário
		 * atribuir-la a uma variável  cujo tipo seja menor que
		 * um int é necessário realizar a operação de cast
		 */
		
		byte soma = (byte)(idade + incredimento); // vai soma e vai forçar o limiti para caber no váriavel, (byte) é um cast
		//cast é compactar para armazenar no variável
		
		System.out.println(idade);
		System.out.println("Eu tenho " + (idade + incredimento) + " anos");
		System.out.println("Eu tenho " + soma + " anos");
		
		// cast é atribuir tipo seja menor que um int
		 
	}

}
