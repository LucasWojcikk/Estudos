package br.com.unicuritiba.arenaplanetaria;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.servlet.ModelAndView;

import br.com.unicuritiba.arenaplanetaria.models.Arena;
import br.com.unicuritiba.arenaplanetaria.repositories.ArenaRepository;

@Controller
public class ArenaPlanetariaController {

	@Autowired
	private ArenaRepository repositorio;

	@GetMapping("/")
	public ModelAndView home() {
		
		List<Arena> arenas = repositorio.findAll();
		
		ModelAndView view = new ModelAndView("index");
		view.addObject("arenas", arenas);
		
		return view;	
	}
	
	@PostMapping("/cadastro")
	public String registerArena(
		Arena arena,
		Model model,
		BindingResult result) {
		repositorio.save(arena);
		return "redirect:/";
	}
	
	@GetMapping("/cadastro")
	public ModelAndView create() {
		ModelAndView view = new ModelAndView("create");
		view.addObject("arena", new Arena());
		return view;
	}
}	




