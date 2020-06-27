
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.ArrayList;

public class exemplo1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Set<String> conjunto = new HashSet<String>();
		
		conjunto.add("Vodka");
		conjunto.add("Limão");
		
		List<String> lista = new ArrayList<String>();
		
		lista.add("Batata");
		lista.add("Banana");
		lista.add("Limão");
		
		for(int i = 0; i < lista.size(); i++)
		{
			String elemento = lista.get(i);
			System.out.println(elemento);
		}
		//para cada "String" em "Lista"
		//"elemento" é apenas um nome para a variavel local
		for(String elemento : lista)
		{
			System.out.println(elemento);
		}
		
		
	}

}
