package ArtiumSys.Model;

public class Reservas_convites {
	private int idAcervo_tbAcervo;
	private int idUsuario_tbUsuario;
	private int reservar;
	private boolean convidado;
	
	public int getIdAcervo_tbAcervo() {
		return idAcervo_tbAcervo;
	}
	public void setIdAcervo_tbAcervo(int idAcervo_tbAcervo) {
		this.idAcervo_tbAcervo = idAcervo_tbAcervo;
	}
	public int getIdUsuario_tbUsuario() {
		return idUsuario_tbUsuario;
	}
	public void setIdUsuario_tbUsuario(int idUsuario_tbUsuario) {
		this.idUsuario_tbUsuario = idUsuario_tbUsuario;
	}
	public int getReservar() {
		return reservar;
	}
	public void setReservar(int reservar) {
		this.reservar = reservar;
	}
	public boolean isConvidado() {
		return convidado;
	}
	public void setConvidado(boolean convidado) {
		this.convidado = convidado;
	}
	 
	 
	 

}
