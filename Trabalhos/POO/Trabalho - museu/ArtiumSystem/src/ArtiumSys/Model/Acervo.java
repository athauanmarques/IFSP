package ArtiumSys.Model;


public class Acervo {
	private int idAcevo;
	private String titulo;
	private String descricao;
	private String periodo;
  	private String dataInicio;
  	private String dataFinal;
  	private String cidade;
  	private String endereco;
  	private String estado;
  	private String cep;
  	private String responsavel;
  	private String telResponvel;
  	private int limiteReserva;
  	private int maxVisitante;
  	private boolean enviarConvites;
	public int getIdAcevo() {
		return idAcevo;
	}
	public void setIdAcevo(int idAcevo) {
		this.idAcevo = idAcevo;
	}
	public String getTitulo() {
		return titulo;
	}
	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}
	public String getDescricao() {
		return descricao;
	}
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	public String getPeriodo() {
		return periodo;
	}
	public void setPeriodo(String periodo) {
		this.periodo = periodo;
	}
	public String getDataInicio() {
		return dataInicio;
	}
	public void setDataInicio(String dataInicio) {
		this.dataInicio = dataInicio;
	}
	public String getDataFinal() {
		return dataFinal;
	}
	public void setDataFinal(String dataFinal) {
		this.dataFinal = dataFinal;
	}
	public String getCidade() {
		return cidade;
	}
	public void setCidade(String cidade) {
		this.cidade = cidade;
	}
	public String getEndereco() {
		return endereco;
	}
	public void setEndereco(String endereco) {
		this.endereco = endereco;
	}
	public String getEstado() {
		return estado;
	}
	public void setEstado(String estado) {
		this.estado = estado;
	}
	public String getCep() {
		return cep;
	}
	public void setCep(String cep) {
		this.cep = cep;
	}
	public String getResponsavel() {
		return responsavel;
	}
	public void setResponsavel(String responsavel) {
		this.responsavel = responsavel;
	}
	public String getTelResponvel() {
		return telResponvel;
	}
	public void setTelResponvel(String telResponvel) {
		this.telResponvel = telResponvel;
	}
	public int getLimiteReserva() {
		return limiteReserva;
	}
	public void setLimiteReserva(int limiteReserva) {
		this.limiteReserva = limiteReserva;
	}
	public int getMaxVisitante() {
		return maxVisitante;
	}
	public void setMaxVisitante(int maxVisitante) {
		this.maxVisitante = maxVisitante;
	}
	public boolean isEnviarConvites() {
		return enviarConvites;
	}
	public void setEnviarConvites(boolean enviarConvites) {
		this.enviarConvites = enviarConvites;
	}
	@Override
	public String toString() {
		return "Acervo [idAcevo=" + idAcevo + ", titulo=" + titulo + ", descricao=" + descricao + ", periodo=" + periodo
				+ ", dataInicio=" + dataInicio + ", dataFinal=" + dataFinal + ", cidade=" + cidade + ", endereco="
				+ endereco + ", estado=" + estado + ", cep=" + cep + ", responsavel=" + responsavel + ", telResponvel="
				+ telResponvel + ", limiteReserva=" + limiteReserva + ", maxVisitante=" + maxVisitante
				+ ", enviarConvites=" + enviarConvites + "]";
	}
	
	
  	
  	
  	

}
