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

- serif (com serifa)

![serif](https://i.imgur.com/UB5xW6x.png "serif")

- sans-serif (sem serifa)

![sans-serif](https://i.imgur.com/OKTCOXQ.png "sans-serif")

## Font Weight

- Peso da fonte

- Valores: normal | bold | bolder | lighter | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900

- Dependendo da família da fonte não conseguimos utilizar todos os pesos de fonte

```css
p {
  font-weight: bold;
}
```

## Font Style

- É o estilo da fonte
- Valores: normal | italic | oblique
- Os valores que podem ser aplicados dependem da fonte usada

```css
span {
  font-style: italic;
}
```

## Font-size

- Tamanho da fonte

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

## Font Variant

Faz variações na apresentação da fonte

```css
p {
  font-variant: small-caps;
}
```

![font-variant](https://imgur.com/04Y4ElO "font-variant")

## Font Stretch

- Alargamento ou encolhimento da fonte
- Aceita palavras-chaves como: expanded, condensed, normal
- Aceita porcentagens de 50% a 200%
- Essa propriedade não vai funcionar em todas as fontes

```css
p {
  font-stretch: expanded;
}
```

## Letter spacing

Define o espaçamento entre os caracteres

```css
p {
  letter-spacing: 4px;
}
```

## Word spacing

Define o espaçamento entre palavras

```css
p {
  word-spacing: 1em;
}
```

## Line height

- Define os espaços entre linhas
- Pode ser com unidades ou sem unidades de medida
- Valores comuns: 1.5 ou 2

```css
p {
  line-height: 1.5;
}
```

## Text transform

- Transformação do texto
- Valores podem ser: none | capitalize | uppercase | lowercase | full-width | full-size-kana

```css
p {
  text-transform: uppercase;
}
```

## Text decoration

- Aparência decorativa de um texto
- line: underline | overline | line-through
- podemos aplicar mais de 1 valor
- style: wavy | dotted | double | dashed | solid
- color: <color> values

```css
h1 {
  text-decoration: underline; /* shorthand */
}

p {
  text-decoration: wavy overline blue; /* shorthand */
}
```

## Text-align

- Alinhamento de um texto
- Valores:
  - start
  - end
  - left
  - right
  - center
  - justify
  - match-parent

```css
p {
  text-align: center;
}
```

## Text shadow

- Sombra aplicada a um texto
- Permite múltiplos valores

```css
p {
  text-shadow: 1px 1px 1px red, 2px 2px 1px green; /* offset-x | offset-y | blur-radius | color */
}
```

## Shorthand

Podemos usar o shorthand font para determinar os seguintes valores: font-style, font-variant, font-weight, font-stretch, font-size, line-height e font-family

```css
p {
  font: italic normal bold normal 3em/1.5 Helvetica, Arial, sans-serif;
}
```
