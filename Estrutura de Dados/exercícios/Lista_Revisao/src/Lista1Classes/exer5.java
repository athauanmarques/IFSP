package Lista1Classes;

import javax.swing.JOptionPane;

public class exer5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Double comprimento = Double.parseDouble(JOptionPane.showInputDialog("Informe o comprimento: "));
		Double largura = Double.parseDouble(JOptionPane.showInputDialog("Informe o largura: "));
		Double profundidade = Double.parseDouble(JOptionPane.showInputDialog("Informe o profundidade: "));
		
		exer5Classe obj = new exer5Classe();
		
		System.out.println("Resultado final foi: " + obj.Fazer(comprimento, largura, profundidade));
		
	}

}
