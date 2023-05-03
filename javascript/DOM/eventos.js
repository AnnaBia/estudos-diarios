// ações que na tag devem ser refenciadas com on...
// onabort = quando aborta
// onblur = quando sai do input
// oncamplay = quando tocar
// onclick = quando clicar
// ondbclick = quando der um doubleClick
// ondrag = quando arrastar
// ondragend = quando terminar de arrastar
// ondrop = quando soltar
// onerror = quando der erro
// onmouseover = para a mãozinha

// onclick="print()" - referencia na tag html
function print(){
    console.log('print')
}

// eventos de teclado
input.onkeydown = function(){
    console.log('rodei') // toda vez que clica para baixo, roda a função
}
input.onkeyup = function(){
    console.log('rodei') // toda vez que clica para cima, roda a função
}
input.onkeypress = function(){
    console.log('rodei') // não importa direção, a função acontece
}

// addEventLits = add ouvidor de eventos
const h1 = document.querySelector('h1');
h1.addEventListener('click', print) // click é a ação, print é o que será feito, se print fosse print(), a ação aconteceria sem precisar do click, sem o () ele apenas busca a função

function print(){
    console.log('print')
}

// outra forma de acionar um evento sem o add (não recomendável)
const h1 = document.querySelector('h1');
h1.onclick = print
function print(){
    console.log('print')
}
// se chamado novamente, ao rodar, ele considera o 2º valor(funciona como cascata)
h1.onclick = function(){
    console.log('outro momento')
}

// essa é uma forma dos dois valores acima serem executados
const h1 = document.querySelector('h1');
h1.addEventListener('click', print) 
function print(){
    console.log('print')
}
h1.addEventListener('click', function(){
    console.log('outro momento')
})

// pegando o valor recebido no input
const input = document.querySelector('input')
input.onkeydown = function(event){
    console.log(event.currentTarget.value)
}
