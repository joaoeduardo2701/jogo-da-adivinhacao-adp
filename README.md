# Jogo da Adivinhacao

Esse projeto foi um dos projetos que realizei na Academia do Programador. O programa consiste em um mini game onde o usuário deve adivinha o número em que o computador esta pensando, tentando assim conseguir a maior pontuação possível.

# Enunciado do exercício

Desenvolva um jogo de adivinhação. O computador pensará em um número, e você, jogador, precisará adivinhá-lo. A cada erro, a máquina lhe dirá se o número chutado foi maior ou menor do que o pensado. Você também poderá escolher o nível de dificuldade do jogo, e isso lhe dará mais ou menos oportunidades de chutar um número. Ao final, se você ganhar, o computador lhe dirá quantos pontos você fez, baseando-se em quão bons eram seus chutes. 
Pesquise sobre a geração de números randômicos em C#. 
O jogador deverá adivinhar um número entre 1 e 20. 
Os níveis de dificuldade serão: 
Fácil = 15 chances 
Médio = 10 chances 
Difícil = 5 chances 

A pontuação do usuário começará em 1000, caso o usuário erre, será subtraído um valor da pontuação com a seguinte fórmula: 
(numero chutado – numero aleatório) / 2 

Caso o resultado seja negativo, deverá ser extraído o valor absoluto. 
