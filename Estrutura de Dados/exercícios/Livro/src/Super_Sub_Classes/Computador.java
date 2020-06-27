package Super_Sub_Classes;


public class Computador {
	
	private String fabricante;
	private String processador;
	private int tamanhoDaRAM;
	private int tamanhoDoDisco;
	
	//Métodos
	/** Inicia um objeto Computador com todas as propriedades especificas
	 * @param fab
	 * @param processador O tipo de processador
	 * @param ram A capacidade de ram
	 * @param disco A capacidade do disco
	 */

	
	public Computador (String fab, String processador, int ram, int disco){
	//é uma Método que esta atribuindo atributos declarados da classe computador
	fabricante = fab; 
	this.processador = processador; // "this" - está construíndo com mesmo parâmetro do atributo processador.
	tamanhoDaRAM = ram;
	tamanhoDoDisco = disco;
	}	
	
	public int obtemTamanhoDaRam() {return tamanhoDaRAM;}
	public int ontemTamanhoDoDisco () {return tamanhoDoDisco;}
	
	//Insira outro métodos acessador e modificador aqui
	public String toString() {
		
		String resultado = "Fabricante: " + fabricante +
				"\nCPU " + processador +
				"\nRAM " + tamanhoDaRAM + "megabytes" +
				"\nDico " + tamanhoDoDisco + "gigabytes";
		
		return result;
	
		}
		
		
		
}

}
