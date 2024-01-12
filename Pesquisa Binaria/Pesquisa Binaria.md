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
