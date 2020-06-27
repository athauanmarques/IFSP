package LIsta1;

import javax.swing.JOptionPane;

public class exer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Double qts1 = Double.parseDouble(JOptionPane.showInputDialog("informe quantidade 1: "));
		Double qts2 = Double.parseDouble(JOptionPane.showInputDialog("Informe quantidade 2: "));
		Double qts3 = Double.parseDouble(JOptionPane.showInputDialog("Informe quantidade 3: "));
		Double vl1 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 1: "));
		Double vl2 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 2: "));
		Double vl3 = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor 3: "));
		
		Double total = qts1 * vl1 + qts2 * vl2 + qts3 * vl3;
		
		JOptionPane.showMessageDialog(null, "Total: " + total);
		

	}

}
