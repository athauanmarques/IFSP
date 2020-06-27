package Oi;

public class Modifica {
	
	
	//Atributo
	private String status = "Camaro com ";
	;
	
	//Propriedades Get & Set
	
	public String getStatus() {
		return status;
	}

	public void setStatus(String nome) {
		this.status = nome;
	}

	public String Mudar (String nome)
	{
		
		status = "Camaro com " + nome;
		return status;
		
	}
	
	//This acessa o atributo dessa classe (status)
	//variavel nome pegando da outra classe
}
	

}
