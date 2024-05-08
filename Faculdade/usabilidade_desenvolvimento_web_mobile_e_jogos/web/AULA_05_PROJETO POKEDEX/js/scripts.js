
const grupoGrama = ["bulbasaur", "ivysaur", "venusaur"]

const grupoFogo = ["charmander", "charmeleon","charizard", "pidgey", "pidgeotto", "pidgeot"]

const grupoAgua = ["squirtle", "wartortle", "blastoise"]

const grupoTerra = ["caterpie", "metapod", "butterfree", "weedle", "kakuna", "beedrill", "rattata", "raticate"]


function carregarPokemons(){

    const requisicaoHttp = new XMLHttpRequest()
    requisicaoHttp.open("GET", "https://pokeapi.co/api/v2/pokemon", false)
    requisicaoHttp.send()

    const resposta = JSON.parse(requisicaoHttp.responseText)
    
    const pokemons = resposta.results
    // console.log(resposta.results)


    for(let index = 0; index < pokemons.length; index++){
        const pokemon = pokemons[index]
        const id = index + 1
        pokemon.imagem = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/" + id + ".png"
        addCardPokemon(pokemon)
    }
}


function addCardPokemon(pokemon){
    const imagemElemento = document.createElement("img")
    const nomeElemento = document.createElement("h1")
    
    imagemElemento.setAttribute("src", pokemon.imagem)
    nomeElemento.setAttribute("src", pokemon.name)
    // nomeElemento.classList.add("terra")
    
    // nomeElemento.textContent=pokemon.name;
    nomeElemento.innerHTML = pokemon.name

    if(grupoGrama.includes(pokemon.name)){
        nomeElemento.classList.add("grama")
        const divElemento = document.getElementById("div-grama")
        divElemento.classList.add("card")
        divElemento.appendChild(nomeElemento)
        divElemento.appendChild(imagemElemento)
    }
    else if(grupoFogo.includes(pokemon.name)){
        nomeElemento.classList.add("fogo")
        const divElemento = document.getElementById("div-fogo")
        divElemento.classList.add("card")
        divElemento.appendChild(nomeElemento)
        divElemento.appendChild(imagemElemento)
    }
    else if(grupoTerra.includes(pokemon.name)){
        nomeElemento.classList.add("terra")
        const divElemento = document.getElementById("div-terra")
        divElemento.classList.add("card")
        divElemento.appendChild(nomeElemento)
        divElemento.appendChild(imagemElemento)
    }
    else if(grupoAgua.includes(pokemon.name)){
        nomeElemento.classList.add("agua")
        const divElemento = document.getElementById("div-agua")
        divElemento.classList.add("card")
        divElemento.appendChild(nomeElemento)
        divElemento.appendChild(imagemElemento)
    }
    
    
    // const divElemento = document.getElementById("conteudo-pokemon")
    // divElemento.appendChild(nomeElemento)
    // divElemento.appendChild(imagemElemento)
    // console.log(pokemon)
}
