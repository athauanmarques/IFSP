package LIsta1;

import javax.swing.JOptionPane;

public class exer1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String Nome1 = JOptionPane.showInputDialog("Informe o seu 1� nome: ");
		String Nome2 = JOptionPane.showInputDialog("Infome o seu 2� nome: ");
		String Nome3 = JOptionPane.showInputDialog(null, "Informe o seu 3�: ");
		
		JOptionPane.showMessageDialog(null, "o seu nome �: " + Nome1 + " " + Nome3);
		JOptionPane.showMessageDialog(null, "Seu nome no meio: " + Nome2);
	}

}
