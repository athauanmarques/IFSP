import java.util.ArrayList;
import java.util.List;

public class InsertionSorter implements Sorter {
	
	/*
	 * Insertion sort, ou ordenação por inserção, é um simples algoritmo de ordenação, 
	 * eficiente quando aplicado a um pequeno número de elementos. 
	 * Em termos gerais, ele percorre um vetor de elementos da esquerda para a direita 
	 * e à medida que avança vai deixando os elementos mais à esquerda ordenados. 
	 * O algoritmo de inserção funciona da mesma maneira com que muitas pessoas ordenam cartas 
	 * em um jogo de baralho como o pôquer.
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
