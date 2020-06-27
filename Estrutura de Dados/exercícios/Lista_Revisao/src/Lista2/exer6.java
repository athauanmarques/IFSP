package Lista2;

import javax.swing.JOptionPane;

public class exer6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub=
		
		float hora = Float.parseFloat(JOptionPane.showInputDialog("Informe a hora: "));
		float salarioHora = Float.parseFloat(JOptionPane.showInputDialog("Informe a salário-hora: "));
		float nDep = Float.parseFloat(JOptionPane.showInputDialog("Informe números Depedentes: "));
		float inss;
		float ir = 0;
		float liquido;
	
		Calculo cal = new Calculo();
		
		 cal.SalarioBruto(hora,salarioHora,nDep);
		 
		if (cal.SalarioBruto(hora, salarioHora, nDep) <= 1000)
		{
			 inss = (float) (cal.SalarioBruto(hora, salarioHora, nDep) * 8.5/100);
		}
		else
		{
			 inss = cal.SalarioBruto(hora, salarioHora, nDep) * 9/100;
		}
	
		//-------------------------- Desconto IR ---------------------------------------
		
		if (cal.SalarioBruto(hora, salarioHora, nDep) <= 500)
		{
			ir = 0;
		}
		else if (cal.SalarioBruto(hora, salarioHora, nDep) > 500 && cal.SalarioBruto(hora, salarioHora, nDep) <=1000)
		{
			ir = cal.SalarioBruto(hora, salarioHora, nDep) * 5/100;
		}
		else if (cal.SalarioBruto(hora, salarioHora, nDep) > 1000)
		{
			ir = cal.SalarioBruto(hora, salarioHora, nDep) * 7/100;
			
		}
		
		//--------------------------- liquido
		liquido = cal.SalarioBruto(hora, salarioHora, nDep) - inss - ir;
		
		JOptionPane.showMessageDialog(null, "Salário Bruto: " + cal.SalarioBruto(hora, salarioHora, nDep) +
											"\nDesconto Inss: " + inss +
											"\nDesconto IR: " + ir);
		
		

	}

}
