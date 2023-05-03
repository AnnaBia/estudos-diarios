// element.style
const element = document.querySelector('body')
// permite atribuir estilo na linha
element.style.backgroundColor = "#ffffff"
console.log(element.style.backgroundColor)

// classList
const element = document.querySelector('body')
// pega uma lista de classes
console.log(element.classList)
// pega o elemento active(css) 
element.classList.add('active', 'green')
// e aplica em todo body
console.log(element.classList)
// se a classe existir, ele tira
element.classList.remove('active')
// caso contrário, ele coloca
element.classList.toggle('active')