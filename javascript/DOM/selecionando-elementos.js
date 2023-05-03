// getElementById pega o elemento pelo nome do 'id'
const element = document.getElementById('blog-title')
console.log(element)

// getEelementsByClassName pega o elemento pelo nome da 'class'
const element = document.getElementsByClassName('one');
console.log(element)

// getElementsByTaagName pega  elemento pelo nome da tag
const element = document.getElementsByTagName('h1')
console.log(element)

// querySelector pega qualquer elemento
const element = document.quertSelector('meta')
console.log(element)

// querySelector pega os elementos e apresenta como lista

const element = document.querySelectorAll('#one')
console.log(element)
    // outro detalhe é que aceita foreach dentro 
const element = document.querySelectorAll('#one')
element.forEach => console.log(element)