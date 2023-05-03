// criando elemento
const div = document.createElement('div');
div.innerText = "Olá Devs!" //valor

// adicionando o local onde colocar o elemento criado com js
const body = document.querySelector('body')
const script = body.querySelector('script')
const header = header.querySelector('header')
body.append(div) // append adiciona o elemento depois da tag de referencia
body.prepend(div) // prepend adiciona o elemento antes da tag de referencia

// adicionando uma div no centro
body.insertBefore(div, script) // insertBefore adiciona antes(valor, referencia), essa referncia também deve ser referenciada, nesse caso foi 'script'
body.insertBefore(div, header.nextElementSibling) // insere o valor depois da referencia, neste caso 'header', que também deve ser referenciada