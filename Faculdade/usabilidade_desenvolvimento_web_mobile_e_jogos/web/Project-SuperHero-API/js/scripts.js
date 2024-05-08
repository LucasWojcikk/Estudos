function loadHeroes(){
    const HttpRequest = new XMLHttpRequest()
    HttpRequest.open("GET", "https://akabab.github.io/superhero-api/api/all.json", false)
    HttpRequest.send()

    const heroesReturn = JSON.parse(HttpRequest.responseText)
    const heroes = heroesReturn

    for(let index = 0; index < heroes.length; index++){
        const hero = heroes[index]
        const id = heroesReturn[index].slug
        hero.image =`https://cdn.jsdelivr.net/gh/akabab/superhero-api@0.3.0/api/images/lg/${id}.jpg`
        addCardHero(hero)
    }
}


function addCardHero(hero){
    const imagemElemento = document.createElement("img")
    const nomeElemento = document.createElement("h1")

    const divCardElemento = document.createElement("div")
    divCardElemento.classList.add("card")
    
    imagemElemento.setAttribute("src", hero.image)
    nomeElemento.setAttribute("src", hero.name)
    imagemElemento.style.width = "90%"
    nomeElemento.innerHTML = hero.name
    
    const divElemento = document.getElementById("hero-content")

    divCardElemento.appendChild(nomeElemento)
    divCardElemento.appendChild(imagemElemento)
    divElemento.appendChild(divCardElemento)
}
