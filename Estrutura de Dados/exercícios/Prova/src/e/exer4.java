package e;

import javax.swing.JOptionPane;

public class exer4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Calcule cal = new Calcule();
		
		String op = JOptionPane.showInputDialog("Infome qual tipo de opera��o: \n (+) Soma \n(-) Subtra��o \n (/)Divis�o \n(*) multiplica��o");
		double n1 = Double.parseDouble(JOptionPane.showInputDialog("Informe 1� valor: "));
		double n2 = Double.parseDouble(JOptionPane.showInputDialog("Informe 2� valor: "));
		
		switch(op)
		{
		case "+":
			
			JOptionPane.showMessageDialog(null, "Sua soma foi: " + cal.Soma(n1,n2));
			break;
		
         case "-":
			
			JOptionPane.showMessageDialog(null, "Sua subtra��o foi: " + cal.Sub(n1,n2));
			break;
			
		case "/":
			
			JOptionPane.showMessageDialog(null, "Sua divis�o foi: " + cal.Divisao(n1,n2));
			break;
		
         case "*":
			
			JOptionPane.showMessageDialog(null, "Sua multiplica��o foi: " + cal.Mult(n1,n2));
			break;
		
		
		default:
			JOptionPane.showMessageDialog(null, "opera��o incorreta");
			break;
	}

	}

}
