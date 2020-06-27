package LIsta1;

import javax.swing.JOptionPane;

public class exer3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Double comprimento = Double.parseDouble(JOptionPane.showInputDialog("Informe o comprimento: "));
		Double largura = Double.parseDouble(JOptionPane.showInputDialog("Informe o largura: "));
		
		Double areaTotal = comprimento * largura;
		
		JOptionPane.showMessageDialog(null, "Area total: " + areaTotal);
		

	}

}
