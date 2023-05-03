// parentNode pega o pai da tag
const element = document.querySelector('h1') // pegando um elemento
console.log(element.parentNode) 


// childNodes pega TODOS os elementos filhos
const el = documento.querySelector('body')
console.log(el.childNodes) // pega com espaços vazios
console.log(el.children)// pega sem espaços vazios
// firstChild pega o primeiro elemento filho
console.log(el.firstChild)
// lastChild pega o ultimo elemento filho
console.log(el.lastChild)

// buscando irmãos
const el = document.querySelector('body script')
    //nextSibling próximo irmao considerando espaços vazios
    const log(el.nextElement)
    // nextElement\sibling proximo irmao sem considerar espaços vazios, ou seja, a proxima tag
    console.log(el.nextElementSibling)
    // previous pega o anterior sem considerar espaços vazios, ou seja, a proxima tag
    console.log(el.previousElementSibling)
    // previous pega o anterior sem considerando espaços vazios
    console.log(el.previousSibling)

