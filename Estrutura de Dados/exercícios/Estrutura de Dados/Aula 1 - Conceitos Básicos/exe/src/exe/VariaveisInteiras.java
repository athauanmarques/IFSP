package exe;

public class VariaveisInteiras {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		byte idade = 127;
		byte incredimento = 5;
		
		// casting (cast)
		/*
		 * A soma de duas variaveis inteiras, independente do tipo,
		 * fornece como resultado um inteiro. Se for necess�rio
		 * atribuir-la a uma vari�vel  cujo tipo seja menor que
		 * um int � necess�rio realizar a opera��o de cast
		 */
		
		byte soma = (byte)(idade + incredimento); // vai soma e vai for�ar o limiti para caber no v�riavel, (byte) � um cast
		//cast � compactar para armazenar no vari�vel
		
		System.out.println(idade);
		System.out.println("Eu tenho " + (idade + incredimento) + " anos");
		System.out.println("Eu tenho " + soma + " anos");
		
		// cast � atribuir tipo seja menor que um int
		 
	}

}
