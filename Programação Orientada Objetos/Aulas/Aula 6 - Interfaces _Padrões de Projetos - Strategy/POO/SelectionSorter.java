import java.util.ArrayList;
import java.util.List;

public class SelectionSorter implements Sorter {
	
	/*
	 * A ordena��o por sele��o � um algoritmo de ordena��o baseado em se passar sempre o menor valor 
	 * do vetor para a primeira posi��o (ou o maior dependendo da ordem requerida), depois o de 
	 * segundo menor valor para a segunda posi��o, e assim � feito sucessivamente com os n-1 elementos 
	 * restantes, at� os �ltimos dois elementos.
	 */

	@Override
	public <T extends Comparable<? super T>> List<T> sort(List<T> list) {

		int index_min;
		T aux;
		list = new ArrayList<T>(list);
		
		for (int i = 0; i < list.size(); i++) {
			index_min = i;
			
			for (int j = i + 1; j < list.size(); j++) {
				if (list.get(j).compareTo(list.get(index_min)) < 0) {
					index_min = j;
				}
			}
			
			if (index_min != i) {
				aux = list.get(index_min);
				list.remove(index_min);
				list.add(index_min, list.get(i));
				list.remove(i);
				list.add(i, aux);
			}
		}
		return list;
	}
}
