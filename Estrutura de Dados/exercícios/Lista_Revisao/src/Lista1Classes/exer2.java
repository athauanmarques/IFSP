package Lista1Classes;

import javax.swing.JOptionPane;

public class exer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Double qts1 = Double.parseDouble(JOptionPane.showInputDialog("Informe quantidade 1: "));
		Double qts2 = Double.parseDouble(JOptionPane.showInputDialog("Informe quantidade 2: "));
		Double qts3 = Double.parseDouble(JOptionPane.showInputDialog("Informe quantidade 3: "));
		Double vlr1 = Double.parseDouble(JOptionPane.showInputDialog("Informe valor 1: "));
		Double vlr2 = Double.parseDouble(JOptionPane.showInputDialog("Informe valor 2: "));
		Double vlr3 = Double.parseDouble(JOptionPane.showInputDialog("Informe valor 3: "));
		
		exer2Classe obj = new exer2Classe();
		
		System.out.println(obj.Calcular(vlr1, vlr2, vlr3, qts1, qts2, qts3));
		

	}

}
