package Lista2;

import javax.swing.JOptionPane;

public class l2_exe1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Double vl = Double.parseDouble(JOptionPane.showInputDialog("Informe valor "));
		Double p1 = vl*1.15;
		Double p2 = vl*1.2;
		Double p3 = vl*1.35;
		Double p4 = vl*1.4;
		
		int op = Integer.parseInt(JOptionPane.showInputDialog("informe o codigo (1,2,3 ou 4): "));
	
		if (op == 1 || op == 2 || op == 3 || op == 4)
		{
			JOptionPane.showMessageDialog(null, "Voce escolheu a opção : " + op);
			
			swtich(op)
			
		           
			case 1:
				
				JOptionPane.showMessageDialog(null, "15% de aumento foi: " + p1);
				break;
				
			case 2:
				OptionPane.showMessageDialog(null, "20% de aumento foi: " + p2);
				break;
				
			case 3:
					OptionPane.showMessageDialog(null, "35% de aumento foi: " + p3);
					break;
			case 4:
						OptionPane.showMessageDialog(null, "40% de aumento foi: " + p4);
						break;
						
					default:
						OptionPane.showMessageDialog(null, "Erro");
						break
				
			
		}
		else
		{
			JOptionPane.showMessageDialog(null, "codigo infalido ");
			
		}
		
	}

}
