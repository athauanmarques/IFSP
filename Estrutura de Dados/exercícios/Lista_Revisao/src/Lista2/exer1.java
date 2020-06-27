package Lista2;

import javax.swing.JOptionPane;

public class exer1 {

	public static void main(String[] args) {
		
		
			int op = Integer.parseInt(JOptionPane.showInputDialog("Informe o código: "));
			Double produto = Double.parseDouble(JOptionPane.showInputDialog("Informe o valor do produto: "));

			Tabela obj = new Tabela();
			
			do{
			switch (op)
			
			{
			case 1: 
				 JOptionPane.showMessageDialog(null, "Sua opção foi (1), seu resultado é: " + obj.Cal1(produto) + 
						 "\n sua porcentagem é: 15%");
				 op= 0; // para zera a op e continuar a execursão 
				  break;
			case 3: 
				JOptionPane.showMessageDialog(null, "Sua opção foi (3), seu resultado é: " + obj.Cal3(produto) + 
						 "\n sua porcentagem é: 20%");
				op= 0;
				  break;
			case 4: 
				JOptionPane.showMessageDialog(null, "Sua opção foi (4), seu resultado é: " + obj.Cal4(produto) + 
						 "\n sua porcentagem é: 35%");
				op= 0;
				  break;
			case 8: 
				JOptionPane.showMessageDialog(null, "Sua opção foi (8), seu resultado é: " + obj.Cal8(produto) + 
						 "\n sua porcentagem é: 40%");
				op= 0;
				  break;	
			default:
				op = Integer.parseInt(JOptionPane.showInputDialog("por favor informe código novamente: \nou digite 10 para sair;")); 
				  break;
	
			}
				
			}while(op == 0 || op == 1 || op == 3 || op == 4 || op == 8);
			
			
			
			
			
			
			
			
		
		

	}

}
