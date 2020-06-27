package Lista1Classes;

import javax.swing.JOptionPane;

public class exer4 {

	public static void main(String[] args) {
 		
		Double n1 = Double.parseDouble(JOptionPane.showInputDialog(null, "Informe valor 1: "));
		Double n2 = Double.parseDouble(JOptionPane.showInputDialog(null, "Informe valor 2: "));
		Double n3 = Double.parseDouble(JOptionPane.showInputDialog(null, "Informe valor 3: "));
		Double n4 = Double.parseDouble(JOptionPane.showInputDialog(null, "Informe valor 4: "));
		
		exer4Classe obj = new exer4Classe();
		JOptionPane.showMessageDialog(null, "Seu resultado foi: " + obj.Calcurar(n1, n2, n3, n4));

	}

}
