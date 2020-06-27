package Lista1Classes;

import javax.swing.JOptionPane;

public class exer3 {

	public static void main(String[] args) {
		
		Double comprimento = Double.parseDouble(JOptionPane.showInputDialog("report length: "));
		Double largura = Double.parseDouble(JOptionPane.showInputDialog("report width: "));

		exer3Classe obj = new exer3Classe();
		
		System.out.println("Resultado: " + obj.CalcuraArea(comprimento, largura));
		
		
	}

}
