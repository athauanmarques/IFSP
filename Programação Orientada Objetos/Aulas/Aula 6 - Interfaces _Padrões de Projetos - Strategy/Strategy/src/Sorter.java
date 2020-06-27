import java.util.List;

public interface Sorter {
	
	<T extends Comparable <? super T>> List<T> sort (List<T> list);
	//objetos que receber classes Comparable
	//<?(ou) super T> que é uma condição

}
