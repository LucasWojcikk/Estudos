package br.com.unicuritiba.arenaplanetaria.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import br.com.unicuritiba.arenaplanetaria.models.Arena;


public interface ArenaRepository extends JpaRepository<Arena, Long> {

}
