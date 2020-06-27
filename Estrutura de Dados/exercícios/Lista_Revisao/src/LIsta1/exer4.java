package LIsta1;

import javax.swing.JOptionPane;

public class exer4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Double n1 = Double.parseDouble(JOptionPane.showInputDialog("Informa N1: "));
		Double n2 = Double.parseDouble(JOptionPane.showInputDialog("Informa N2: "));
		Double n3 = Double.parseDouble(JOptionPane.showInputDialog("Informa N3: "));
		Double n4 = Double.parseDouble(JOptionPane.showInputDialog("Informa N4: "));

		Double result = (n1 + n2 + n3 + n4)/4;
		
		JOptionPane.showMessageDialog(null, "Sua média é: " + result );
		
	}

}
