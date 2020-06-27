package Lista1Classes;

import javax.swing.JOptionPane;

public class exer1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String nome1 = JOptionPane.showInputDialog("First report name: ");
		String nome2 = JOptionPane.showInputDialog("Second report name: ");
		String nome3 = JOptionPane.showInputDialog("Third report name: ");
		
		exer1Classe exe = new exer1Classe();
		
		exe.Ordenar(nome1,nome2,nome3);

	}

}
