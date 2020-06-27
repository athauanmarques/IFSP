package exe;

public class escopoVariaveis {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int x1 = 100;
		
		{
			int x2 =200;
			System.out.println("x1 = " + x1);
			System.out.println("x2 = " + x2);
		
		}
		
		
		
		System.out.println("x1 = " + x1);
		//System.out.println("x2 = " + x2);
		//A variável x2 é acessível apenas no bloco
		//anônimo onde ela foi definido
	}

}
