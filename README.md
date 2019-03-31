# Jokenpo

A solução é composta por dois projetos que representam os jogos 'Pedra Papel Tesoura' e 'Pedra Papel Tesoura Lagarto Spock'.

## Pedra Papel Tesoura

O algoritmo deste jogo é o mais rápido e menos complexo, mas não atende quando há mais de uma regra a ser validada. É considerado o resto da divisão de uma jogada em relação a outra chegando aos seguintes cenários:

* 1 mod 3 = 1 + 1 -> 2 ---> Se jogada1 == 1 && jogada2 == 2 Então jogada2 ganha (j1 Pedra VS j2 Papel);
* 2 mod 3 = 2 + 1 -> 3 ---> Se jogada1 == 2 && jogada2 == 3 Então jogada2 ganha (j1 Papel VS j2 Tesoura);
* 3 mod 3 = 0 + 1 -> 1 ---> Se jogada1 == 3 && jogada2 == 1 Então jogada2 ganha (j1 Tesoura VS j2 Pedra);

O inverso de jogadas também é verdadeiro, por isso o algoritmo é testado nas duas situações. O empate é definido quando nenhuma das condições são satisfatórias.

Para 'Pedra Papel Tesoura' este algoritmo é suficente, mas não é extensível ao 'Pedra Papel Tesoura Lagarto Spock'.

## Pedra Papel Tesoura Lagarto Spock

O algoritmo deste jogo utiliza um laço para validar as regras definidas em um array multidimensional. É considerado que para cada índice do array estão mapeadas as possibilidades de ganho:

* Índice 0 (Pedra) ganha de { Tesoura, Lagarto };
* Índice 1 (Papel) ganha de { Pedra, Spock };
* Índice 2 (Tesoura) ganha de { Papel, Lagarto };
* Índice 3 (Lagarto) ganha de { Spock, Papel };
* Índice 4 (Spock) ganha de { Tesoura, Pedra };

Com esse algoritmo é possível aumentar indefinidamente o número de jogadas.

## Informações gerais
* Ambos os algoritmos suportam apenas dois jogadores;
* A entrada dos dois jogadores são manuais, mas o jogador 2 poderia ser automatizado com poucas alterações;
* É possível utilizar o algoritmo de 'Pedra Papel Tesoura Lagarto Spock' em 'Pedra Papel Tesoura' apenas reduzindo a dimensão do array, mas devido a simplicidade das validações do primeiro jogo, não há necessidade. Por isso, foram explorados dois algoritmos diferentes;
* Os projetos estão no framework .NET Core 2.1;
