import java.util.ArrayList;
import java.util.List;

public class InsertionSorter implements Sorter {
	
	/*
	 * Insertion sort, ou ordena��o por inser��o, � um simples algoritmo de ordena��o, 
	 * eficiente quando aplicado a um pequeno n�mero de elementos. 
	 * Em termos gerais, ele percorre um vetor de elementos da esquerda para a direita 
	 * e � medida que avan�a vai deixando os elementos mais � esquerda ordenados. 
	 * O algoritmo de inser��o funciona da mesma maneira com que muitas pessoas ordenam cartas 
	 * em um jogo de baralho como o p�quer.
	 */

	@Override
	public <T extends Comparable<? super T>> List<T> sort(List<T> list) {

		list = new ArrayList<T>(list);
		
		for (int i = 1; i < list.size(); i++) {
			
			T a = list.get(i);
			int j;
			
			for (j = i - 1; j >= 0 && list.get(j).compareTo(a) > 0; j--) {
				list.remove(j + 1);
				list.add(j + 1, list.get(j));
				list.remove(j);
				list.add(j, a);
			}
		}
		return list;
	}
}
