package Lista2;

import javax.swing.JOptionPane;

public class exer1 {

	public static void main(String[] args) {
		
		
			int op = Integer.parseInt(JOptionPane.showInputDialog("Informe o c�digo: "));
			Double produto = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor do produto: "));

			Tabela obj = new Tabela();
			
			do{
			switch (op)
			
			{
			case 1: 
				 JOptionPane.showMessageDialog(null, "Sua op��o foi (1), seu resultado �: " + obj.Cal1(produto) + 
						 "\n sua porcentagem �: 15%");
				 op= 0; // para zera a op e continuar a execurs�o 
				  break;
			case 3: 
				JOptionPane.showMessageDialog(null, "Sua op��o foi (3), seu resultado �: " + obj.Cal3(produto) + 
						 "\n sua porcentagem �: 20%");
				op= 0;
				  break;
			case 4: 
				JOptionPane.showMessageDialog(null, "Sua op��o foi (4), seu resultado �: " + obj.Cal4(produto) + 
						 "\n sua porcentagem �: 35%");
				op= 0;
				  break;
			case 8: 
				JOptionPane.showMessageDialog(null, "Sua op��o foi (8), seu resultado �: " + obj.Cal8(produto) + 
						 "\n sua porcentagem �: 40%");
				op= 0;
				  break;	
			default:
				op = Integer.parseInt(JOptionPane.showInputDialog("por favor informe c�digo novamente: \nou digite 10 para sair;")); 
				  break;
	
			}
				
			}while(op == 0 || op == 1 || op == 3 || op == 4 || op == 8);
			
			
			
			
			
			
			
			
		
		

	}

}
