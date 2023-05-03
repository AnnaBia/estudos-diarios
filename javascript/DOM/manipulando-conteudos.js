// textContent altera conteúdo de texto
const element = document.querySelector('h1')
element.texContext += 'Olá Devs!'
console.log(element.textContent)

// innerText altera o conteúdo
const element = document.querySelector(h1)
element.innerText = 'Olá Devs!'

// innerHtml altera o conteúdo e possibilita implementar uma tag dentro da tag
const element = document.querySelector('h1')
element.innerHtml = 'olá Devs! <small>!!!</small>'

// value altera o valor dentro do input
const element = document.querySelector('input')
console.log(element.value)
element.value = 'outro valor'
// ou adiciona valor
console.value[element.value]
element.value = 'outro valor'

// adicionando um atributo a tag (tipo, valor)
const header = document.querySelector('header')
header.setAttribute('id', 'header')
// pesquisando o atributo adicionado
const headerID = document.querySelector('#header')
// pegando valor
console.log(headerID)
// pegar atributo dentro da tag do atributo criado
console.log(headerID.getAttribute('class'))
// removendo o atributo criado da tag
header.removeAttribute('id')
// adicionando outro atributo - class
header.setAttribute('class', 'bg header')
