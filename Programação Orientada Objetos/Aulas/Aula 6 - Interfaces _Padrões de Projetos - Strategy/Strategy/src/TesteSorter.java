import java.util.ArrayList;
import java.util.List;

public class TesteSorter {

	public static void main(String[] args) {

		// Criando uma Lista desordenada
		List<Integer> list = new ArrayList<Integer>();
		list.add(10);
		list.add(3);
		list.add(2);
		list.add(14);
		
		// Ordenando a lista utilizando o InsertionSorter
		Sorter sorter = new InsertionSorter();
		List<Integer> list2 = sorter.sort(list);
		for (Integer integer : list2) {
			System.out.println(integer);
		}
		
		// Ordenando a lista utilizando o SelectionSorter
		Sorter sorter2 = new SelectionSorter();
		List<Integer> list3 = sorter2.sort(list);
		for (Integer integer : list3) {
			System.out.println(integer);
		}
	}
}
