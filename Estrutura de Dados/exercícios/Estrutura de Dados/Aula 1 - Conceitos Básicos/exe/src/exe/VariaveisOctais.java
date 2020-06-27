package exe;

public class VariaveisOctais {

	public static void main(String[] args) {
		
		final int x1 = 200;  			// base decimal
		final int x2 = 0150;			// base octal
		int x3 = 0xffcca;	    // base hexadecimal
		
		// final esta obrigando atribuir um valor diferente que esta inicializado 
		//ex: final int x1 = 200; 
		// então x1 tem ser diferente do numero 200
		
		x1 = 200;
		
		System.out.println("x1 = " + x1);
		System.out.println("x2 = " + x2);
		System.out.println("x3 = " + x3);

		
	}

}
