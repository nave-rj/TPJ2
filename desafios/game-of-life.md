# Implementar Game of Life
(com Unity ou w/e)

[Artigo no Wikipedia](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)

## Game of Life

![](https://upload.wikimedia.org/wikipedia/commons/e/e5/Gospers_glider_gun.gif)

[Exemplo de implementação](http://arr.gr/playground/life/)

Grid (tamanho que quiser) de células que possuem dois estados: aceso ou apagado.

Células podem ser qualquer coisa:
- cubo na unity
- pixel numa imagem
- etc.

Os estados podem ser representados da maneira mais conveniente:
- cor
- altura
- etc.

**Lembre de ter um estado inicial (algumas células vivas) pra ter o que simular!**

### Regras
- Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
- Any live cell with two or three live neighbours lives on to the next generation.
- Any live cell with more than three live neighbours dies, as if by overpopulation.
- Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

Obs: cada célula tem **8 vizinhos**.

### Extras
- Velocidade de simulação variável
- Implementar lógica de tórus (lado esquerdo tá conectado com o direito e cima tá conectado com o de baixo)
- Poder criar/matar células durante a simulação (clique do mouse)
- Animação quando as células nascem/morrem
- Inventar outras regras

## Logística

Em grupo

Se ficar direitin, substitui a menor nota

Enviar para: mlr@cesar.org.br

Assunto: "Desafio 3003 - Game of Life"
