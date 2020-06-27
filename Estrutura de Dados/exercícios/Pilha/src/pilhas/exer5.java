package pilhas;

import java.util.ArrayDeque;
import java.util.Deque;

import javax.swing.JOptionPane;

public class exer5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Deque<String> estacionamento = new ArrayDeque<String>();
		
		estacionamento.push("carro1 - ferrari");
		estacionamento.push("carro2 - porche");
		estacionamento.push("carro3 - bmw");
		estacionamento.push("carro4 - fusca");
		
		String esquema1 = estacionamento.pop();
	
		String escolha = JOptionPane.showInputDialog("qual carro quer retirar: \n1 - ferrari \n2 - porche \n3 - bmw \n4 - fusca");
		
		if(escolha == "1")
		{
			
			
			
		}
		
		
		
		
		
		
	}

}
