
function buscarCep(){
    let inputCep = document.getElementById("idCep");
    const cep = inputCep.value;

    const requisicaoHttp = new XMLHttpRequest()
    requisicaoHttp.open("GET", `https://viacep.com.br/ws/${cep}/json/`, false)
    requisicaoHttp.send()

    const resposta = JSON.parse(requisicaoHttp.responseText)

    const divElemento = document.getElementById("divLogradouro")
    divElemento.innerHTML = '';
    for (let data in resposta) {
        console.log(data + ": " + resposta[data]);
        atualizarPagina(data, resposta[data])
    }
}   

function atualizarPagina(name, data){
    const rowData = document.createElement("p")
    
    rowData.setAttribute("src", data)
    
    rowData.textContent= `${name}: ${data}`;
    
    const divElemento = document.getElementById("divLogradouro")
    divElemento.appendChild(rowData) 
}