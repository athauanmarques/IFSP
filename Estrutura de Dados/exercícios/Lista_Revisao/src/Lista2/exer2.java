package Lista2;

import javax.swing.JOptionPane;

public class exer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		

 
		int num1= Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		int num2= Integer.parseInt(JOptionPane.showInputDialog("Digite um segundo n�mero"));
		int num3= Integer.parseInt(JOptionPane.showInputDialog("Digite um terceiro n�mero"));
		int maior=num1;
		
		if(num2>maior){
			maior=num2;
		}
		if(num3>maior){
			maior=num3;
		}
		JOptionPane.showMessageDialog(null,"Maior ="+maior);

	}
		
}
