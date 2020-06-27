package Lista3;

import javax.swing.JOptionPane;

public class exer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double qtsVoltas = Double.parseDouble(JOptionPane.showInputDialog("informe a quantidade de volta: "));
		double diametro = Double.parseDouble(JOptionPane.showInputDialog("informe o diametro da da roda: "));
		double pi = 3.1416, c, distanciaPercorrida;
		
		c = pi * qtsVoltas * diametro/2;
		distanciaPercorrida = c*qtsVoltas;
		
		JOptionPane.showMessageDialog(null, "comprimento: " + c + "\nDistância percorrida é: "+ distanciaPercorrida); 
	}

}
