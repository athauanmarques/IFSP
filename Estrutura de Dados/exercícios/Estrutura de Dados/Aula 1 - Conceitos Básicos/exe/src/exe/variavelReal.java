package exe;

public class variavelReal {

	public static void main(String[] args) {

		double d1 = 1.2;
		float f1 = (float)1.2;	//1.2 por padrão é double - necessita cast
		float f2 = 1.4f; // outra forma de cast para float: f ou F
		
		//contra-exemplo
		long x1 = 2147483650L; // L representa um cast para long
		
		System.out.println("d1 = " + d1);
		System.out.println("f1 = " + f1);
		System.out.println("f2 = " + f2);
		System.out.println("x1 = " + x1);
		
		double d2 = 100;
		float f3 = 100;
		System.out.println("d2 = " + d2);
		
		

	}

}
