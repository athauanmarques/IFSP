package e;

import javax.swing.JOptionPane;

public class exer4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Calcule cal = new Calcule();
		
		String op = JOptionPane.showInputDialog("Infome qual tipo de operação: \n (+) Soma \n(-) Subtração \n (/)Divisão \n(*) multiplicação");
		double n1 = Double.parseDouble(JOptionPane.showInputDialog("Informe 1º valor: "));
		double n2 = Double.parseDouble(JOptionPane.showInputDialog("Informe 2º valor: "));
		
		switch(op)
		{
		case "+":
			
			JOptionPane.showMessageDialog(null, "Sua soma foi: " + cal.Soma(n1,n2));
			break;
		
         case "-":
			
			JOptionPane.showMessageDialog(null, "Sua subtração foi: " + cal.Sub(n1,n2));
			break;
			
		case "/":
			
			JOptionPane.showMessageDialog(null, "Sua divisão foi: " + cal.Divisao(n1,n2));
			break;
		
         case "*":
			
			JOptionPane.showMessageDialog(null, "Sua multiplicação foi: " + cal.Mult(n1,n2));
			break;
		
		
		default:
			JOptionPane.showMessageDialog(null, "operação incorreta");
			break;
	}

	}

}
