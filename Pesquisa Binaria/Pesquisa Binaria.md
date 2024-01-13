# Pesquisa binaria

É um algoritmo de busca que procura por um elemento desejado em um arranjo ordenado. O algoritmo funciona dividindo o arranjo no meio repetidamente e comprando o elemento no meio com o elemento procurado. Se o elemento procurado for menor que o elemento no meio, então uma busca recursiva é feita na metade inferior do arranjo. Se o elemento procurado for maior que o elemento no meio, então uma busca recursiva é feita na metade superior do arranjo. Esse processo continua até que o elemento desejado seja encontrado ou então não haja mais elementos para serem pesquisado

## Características:

- A pesquisa binaria é um algoritmo de divisão e conquista
- A pesquisa binaria funciona apenas em arranjos ordenados
- A pesquisa binaria não requer uma estrutura de dados auxiliar para funcionar

## Desempenho:

- Melhor caso

O melhor caso do algoritmo de pesquisa binaria ocorre quando o elemento procurado é o primeiro elemento considerado. Nesse cenário, o algoritmo tem um custo constante de comparações em função do número de elementos n no arranjo: O(1) comparações

- Pior dos casos

O pior dos casos do algoritmo de pesquisa binaria ocorre quando o elemento procurado não está presente no arranjo de entrada. Nesse cenário, o algoritmo tem um custo logarítmico de comparações, em função do número elementos n no arranjo: O(log2 n) comparações

## Exemplo:

Eis um exemplo de como a pesquisa binária funciona. Estou pensando em um número entre 1 e 100. Você deve procurar adivinhar o meu número com o menor número de tentativas possível. A cada tentativa, digo se você chutou muito para cima, muito para baixo ou corretamente. Digamos que começou tentando assim: 1, 2, 3, 4… Isso se chama pesquisa simples. A cada tentativa, você está eliminando apenas um número. Se o meu número fosse o 99, você precisaria de 99 chances para acertá-lo!

Aqui está uma técnica melhor. Comece com 50. Muito baixo, mas você eliminou metade dos números! Agora, você sabe que os números de 1 a 50 são muito baixos. Próximo chute: 75. Muito alto, mas novamente você pode cortar metade dos números restantes! Com a pesquisa binária, você chuta um número intermediário e elimina a metade dos números restantes a cada vez. O próximo número é o 63 (entre 50 e 75). Isso é a pesquisa binária. Você acaba de aprender um algoritmo! Aqui está a quantidade de números que você pode eliminar a cada tentativa.

## Exercicios:

1. https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/description/

2. https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/description/
