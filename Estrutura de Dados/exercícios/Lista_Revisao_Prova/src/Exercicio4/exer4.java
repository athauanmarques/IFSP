package Exercicio4;

import javax.swing.JOptionPane;

public class exer4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Double vl1 = Double.parseDouble(JOptionPane.showInputDialog("informe o valor 1: "));
		Double vl2 = Double.parseDouble(JOptionPane.showInputDialog("informe o valor 2: "));
		Double vl3 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 3: "));
		Double vl4 = Double.parseDouble(JOptionPane.showInputDialog("Informe o vaor 4: "));
		
		Double media = (vl1 + vl2 + vl3 + vl4)/4;
		
		JOptionPane.showMessageDialog(null, "A media é: " + media);
		
	}

}
