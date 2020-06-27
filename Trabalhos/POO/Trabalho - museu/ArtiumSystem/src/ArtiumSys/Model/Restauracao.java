package ArtiumSys.Model;

import java.util.Date;

public class Restauracao {
	
	private int idRestauracao;
	private String statusRestaurar;
	private Date prazoInicio;
	private Date prazoFinal;
	private int vezesRestaurado;
	private int idAcervo_tbAcervo;
	private int idUsuario_tbUsuario;
	 
	public int getIdRestauracao() {
		return idRestauracao;
	}
	public void setIdRestauracao(int idRestauracao) {
		this.idRestauracao = idRestauracao;
	}
	public String getStatusRestaurar() {
		return statusRestaurar;
	}
	public void setStatusRestaurar(String statusRestaurar) {
		this.statusRestaurar = statusRestaurar;
	}
	public Date getPrazoInicio() {
		return prazoInicio;
	}
	public void setPrazoInicio(Date prazoInicio) {
		this.prazoInicio = prazoInicio;
	}
	public Date getPrazoFinal() {
		return prazoFinal;
	}
	public void setPrazoFinal(Date prazoFinal) {
		this.prazoFinal = prazoFinal;
	}
	public int getVezesRestaurado() {
		return vezesRestaurado;
	}
	public void setVezesRestaurado(int vezesRestaurado) {
		this.vezesRestaurado = vezesRestaurado;
	}
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
	 
	 

}
