package br.com.unicuritiba.arenaplanetaria.models;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;


@Entity
public class Arena {

	@Id 
	@GeneratedValue(strategy = GenerationType.SEQUENCE)
	private long id;
	
	private String nomeArena;
	private String nomePlaneta;
	private String ultimoCampeao;
	
	public String getUltimoCampeao() {
		return ultimoCampeao;
	}
	public void setUltimoCampeao(String ultimoCampeao) {
		this.ultimoCampeao = ultimoCampeao;
	}
	public long getId() {
		return id;
	}
	public void setId(long id) {
		this.id = id;
	}
	public String getNomeArena() {
		return nomeArena;
	}
	public void setNomeArena(String nomeArena) {
		this.nomeArena = nomeArena;
	}
	public String getNomePlaneta() {
		return nomePlaneta;
	}
	public void setNomePlaneta(String nomePlaneta) {
		this.nomePlaneta = nomePlaneta;
	}

}



	