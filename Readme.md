# Projeto de lógica para processo seletivo - FIT

O App consiste em uma tela principal, onde pode-se escolher as opções: 1,2,3 ou sair.

## Opção 1: Verifica se o número digitado é primo.

Explicação: 
Número pode ser dividido por ele mesmo ou por um. A lógica verifica se houve mais de duas divisões com resto =0, neste caso não sendo número primo. 
Também foi criado duas validações simples:
1 - verifica se o valor de entrada é maior que int64.Max.
2 - verifica se a entrada é um número inteiro

## Opção 2: Movimento do bot

Explicação: 
Analisando que se a coordenada inicialX == finalX e inicialY == finalY, é verificado que as coordenadas finais foram alcançadas. E se as coordenadaas inicias foram maiores que as finais, não é possível alcançar a mesmas.
O problema foi resolvido usando recursão simples. O caso base seria verificar se a coordenada x ou y atual é maior que a de destino, nesse caso retorna false. Se ainda não for o ponto de destino, fiz duas chamadas para ambos os movimentos válidos a partir desse ponto. Se algum deles produzir um caminho, retorna true, caso contrário, retorna false.

## Opção 2: Palíndromo

Explicação: 
Analisado que um palíndromo é toda palavra ou frase que quando lida ao contrário, desconsiderando espaços e pontuações, possui o mesmo sentido, eu quebrei o texto e um array de char (removendo espaços e pontos), dessa forma, criei um laço (for), onde no mesmo eu leio o texto do inicio e do fim, comparando cada caracter entre eles. Se encontrar algum diferente, não é um palíndro.
