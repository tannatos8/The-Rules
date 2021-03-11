package classes;

public class modeloNoticia {
	private String identificador;
	private String nombreUnico;
	private String titular;
	private String fechaCreacion;
	private String ultimaFechaActualizacion;
	private String autor;
	private String contenido;
	
	public String getNombreUnico() {
		return nombreUnico;
	}
	public void setNombreUnico(String nombreUnico) {
		this.nombreUnico = nombreUnico;
	}
	public String getTitular() {
		return titular;
	}
	public void setTitular(String titular) {
		this.titular = titular;
	}
	public String getFechaCreacion() {
		return fechaCreacion;
	}
	public void setFechaCreacion(String fechaCreacion) {
		this.fechaCreacion = fechaCreacion;
	}
	public String getUltimaFechaActualizacion() {
		return ultimaFechaActualizacion;
	}
	public void setUltimaFechaActualizacion(String ultimaFechaActualizacion) {
		this.ultimaFechaActualizacion = ultimaFechaActualizacion;
	}
	public String getAutor() {
		return autor;
	}
	public void setAutor(String autor) {
		this.autor = autor;
	}
	public String getContenido() {
		return contenido;
	}
	public void setContenido(String contenido) {
		this.contenido = contenido;
	}
	public String getIdentificador() {
		return identificador;
	}
	public void setIdentificador(String identificador) {
		this.identificador = identificador;
	}
}