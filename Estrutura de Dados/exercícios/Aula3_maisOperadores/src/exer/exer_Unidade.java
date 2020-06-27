package exer;

import javax.swing.JOptionPane;

public class exer_Unidade {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		double total, uni;
		
		JOptionPane.showMessageDialog(null, "Tabela de unidade & preço \n10 - R$ 358.000,00"+ "\n15 - R$ 350.000,00" +
		"\n20 - R$ 340.000,00" + "\n25 - R$ 325.000,00" + "\n30 - R$ 295.000,00");
		
		int qts = Integer.parseInt(JOptionPane.showInputDialog("informe a quantidade exibida: "));
		
		switch (qts)
		{
		
		case 10:
		total = 10 *  358.000;
		JOptionPane.showMessageDialog(null, "Total: R$" + total); 
		break;
		
		case 15:
			total = 15 *  350.000;
			JOptionPane.showMessageDialog(null, "Total: R$" + total); 
			break;
			
		case 20:
			total = 20 *  340.000;
			JOptionPane.showMessageDialog(null, "Total: R$" + total); 
			break;
		
		case 25:
			total = 25 *  325.000;
			JOptionPane.showMessageDialog(null, "Total: R$" + total); 
			break;
			
		case 30:
			total = 30*  259.000;
			JOptionPane.showMessageDialog(null, "Total: R$" + total); 
			break;
		
		default:
			JOptionPane.showMessageDialog(null, "Unidade inválido!"); 
			break;
		}
		
		

	}

}
