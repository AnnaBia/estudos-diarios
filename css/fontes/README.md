## Font-family

- Tipo de fonte de um elemento
- Lista de fontes e ordem de prioridade
- Inclui _fallback_ font, ou seja, se não achei essa fonte, procure a próxima, conforme o exemplo abaixo, se não houver Time New Roman, quero Times, se não serif...

```css
p {
  font-family: "Time New Roman", Times, serif;
}
```

Alguns tipos de fonts:

serif (com serifa)
![serif](https://i.imgur.com/UB5xW6x.png "serif")


sans-serif (sem serifa)
![sans-serif](https://i.imgur.com/OKTCOXQ.png "sans-serif")


## Font Weight
Peso da fonte


Valores: normal | bold | bolder | lighter | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900


Dependendo da família da fonte não conseguimos utilizar todos os pesos de fonte
```css
p {
	font-weight: bold;
}
```


## Font Style
É o estilo da fonte
Valores: normal | italic | oblique
Os valores que podem ser aplicados dependem da fonte usada

```css
span {
	font-style: italic;
}
```


## Font-size

Tamanho da fonte

```css
p {
  font-size: 18px;
}
```


## Web-fonts

Fontes do sistema são as fontes que estão instaladas na máquina do usuário e nem sempre o cliente vai ter instalado as fontes usadas no projeto e isso pode fazer com que os estilos dos textos não sejam aplicados corretamente, mas para resolver esses casos podemos preparar nossas fonts para web ou usar fontes da web.


Como usar fontes para web?

- @font-face
- @import
- link
