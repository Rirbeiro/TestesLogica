# Projeto de lógica para processo seletivo - FIT

O App consiste em uma tela principal, onde pode-se escolher as opções: 1,2,3 ou sair.

## Opção 1: Verifica se o número digitado é primo.

Explicação: 
Número primo pode ser dividido por ele mesmo ou por um. A lógica verifica se houve mais de duas divisões com resto =0, neste caso não sendo número primo. 
Também foi criado duas validações simples:
1 - verifica se o valor de entrada é maior que int64.Max.
2 - verifica se a entrada é um número inteiro

## Opção 2: Movimento do bot

Explicação: 
Verifica se um ponto com coordenadas (xStart, yStart) atingiu um ponto com coordenadas (xEnd, yEnd) usando recursão. 
A função primeiro verifica se os pontos inicial e final são válidos (se um não pode ter uma coordenada x ou y negativa 
e se o ponto inicial não pode ter um x ou y maior que o ponto final). Se forem válidos, o código retornará true se as coordenadas iniciais forem 
iguais às coordenadas finais e, caso contrário, retornará o resultado de uma chamada recursiva da mesma função com vários pontos iniciais modificados. 
As chamadas recursivas são variações de (xStart + yStart, yStart) ou (xStart, yStart + xStart) como ponto inicial, até que os pontos inicial e final 
correspondam. O código também inclui um bloco try/catch para lidar com quaisquer erros que possam surgir de uma chamada recursiva com falha.

## Opção 3: Palíndromo

Explicação: 
Analisado que um palíndromo é toda palavra ou frase que quando lida ao contrário, desconsiderando espaços e pontuações, possui o mesmo sentido, eu quebrei o texto e um array de char (removendo espaços e pontos), dessa forma, criei um laço (for), onde no mesmo eu leio o texto do inicio e do fim, comparando cada caracter entre eles. Se encontrar algum diferente, não é um palíndro.
