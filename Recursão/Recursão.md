# Recursão

Um Objeto é denominado recursivo quando sua definição é parcialmente feita em termos dele mesmo. Em programação, a recursividade é um mecanismo útil e poderoso que permite a uma função chamar a si mesmo direta ou indiretamente, ou seja, uma função é dita recursiva se ela contém pelo menos uma chamada explicita ou implícita a si própria

## Característica:

- Recursão é quando uma função chama a si mesma
- Toda função recursiva tem dois caso, case - base e o caso recursivo
- Toda as chamada de função vão para a pilha de chamada

## Vantagens:

- Algoritmos recursivos normalmente são mais compactos, mais legíveis e mais fáceis de serem compreendidos. Algoritmo para resolver problemas de natureza recursiva são fácies de serem implementados em linguagem de programação de alto nível

## Desvantagens

- Por usarem intensivamente a pilha, o que requer alocações de memoria, os algoritmos recursivos tendem a ser mais lentos que os equivalentes iterativos, podem pode valar a pena sacrificar a eficiência em beneficio da clareza. Também se tornam mais difícil de serem depurados na fase de desenvolvimento

## Caso base e caso recursiva

- Quando você escreve uma função recursiva, deve informar quando a recursão deve parar. É por isso que toda função recursiva tem duas partes: o caso-base e o caso recursivo. O caso recursivo é quando a função chama a si mesma. O caso-base é quando a função não chama a si mesma. O caso-base é quando a função não chama a si mesma novamente, de forma que o programa não se torne um loop infinito

## Exemplos:

- O problema ou quebra-cabeça conhecido como torre de Hanói foi publicado em 1883 pelo matemático francês Edouard Lucas, também conhecido por seus estudos com a série Fibonacci. Consiste em transferir, com o menor número de movimentos, a torre composta por N discos do pino A (origem) para o pino C (destino), utilizando o pino B como auxiliar. Somente um disco pode ser movimentado de cada vez e um disco não pode ser colocado sobre outro disco de menor diâmetro.
- Solução: Transferir a torre com N-1 discos de A para B, mover o maior disco de A para C e transferir a torre com N-1 de B para C. Embora não seja possível transferir a torre com N-1 de uma só vez, o
  problema torna-se mais simples: mover um disco e transferir duas torres com N-2 discos. Assim, cada transferência de torre implica em mover um disco e transferir de duas torres com um disco a menos e
  isso deve ser feito até que torre consista de um único disco.
