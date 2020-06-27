package Lista2;

import javax.swing.JOptionPane;

public class exer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		

 
		int num1= Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		int num2= Integer.parseInt(JOptionPane.showInputDialog("Digite um segundo número"));
		int num3= Integer.parseInt(JOptionPane.showInputDialog("Digite um terceiro número"));
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
