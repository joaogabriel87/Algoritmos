# Pesquisa em largura

A pesquisa em largura é um algoritmo utilizados para percorrer ou buscar itens dentro das estruturas de dados grafos ou árvores. A pesquisa em largura pode ser implementada de varias formas. A mais utilizadas são através da recursão, que utiliza PILHA, ou iterativamente, através de uma fila

## Aplicações:

- Encontrar a menor rota em um grafo
- Verificar conexão em grafos
- Resolução de problemas

## Características:

- A pesquisa em larguras lhe diz se há um caminho de A para B
- Se esse caminho existir, a pesquisa em largura lhe dará o caminho mínimo
- Se você tem um problema do tipo “Encontre o menor X”, tente modelar o seu problema utilizado grafos e use a pesquisa em largura para resolvê-lo
- Grafos não direcionados não contem setas, e a relações acontece nos dois sentidos (Ross - Rachel significa ”Ross namorou Rachel e Rachel namorou Ross”)
- Fila são FIFO
- Pilha são LIFO
- Você precisa verificar as pessoas na ordem em que elas foram adicionadas a lista de pesquisa. Portanto a lista de pesquisa deve ser uma fila; caso o contrario, você não obterá o caminho mínimo
- Cada vez que você precisar verificar alguém, procure não verifica-lo novamente. Caso contrario, poderá acabar em um Loop infinito

## Exemplo:

Vamos supor que você seja o dono de uma fazenda de mangas e esteja
procurando um vendedor de mangas que possa vender a sua colheita. você conhece algum vendedor de mangas no Facebook? Bem, você pode
procurar entre seus amigos. Essa pesquisa é bem direta. Primeiro, faça uma lista de amigos para pesquisar. Agora vá até cada pessoa da lista e verifique se esta pessoa vende mangas. Imagine que nenhum de seus amigos é um vendedor de mangas. Então, será necessário pesquisar entre os amigos dos seus amigos.

Cada vez que você pesquisar uma pessoa da lista, todos os amigos dela serão adicionados à lista. Dessa maneira você não pesquisa apenas entre os seus amigos, mas também entre os amigos deles. Lembre-se de que o objetivo é encontrar um vendedor de mangas em sua rede. Então, se Alice não é uma vendedora de mangas, você adicionará também os amigos dela à lista. Isso significa que, eventualmente, pesquisará entre os amigos dela e entre os amigos dos amigos, e assim por diante. Com esse algoritmo você pesquisará toda a sua rede até que encontre um vendedor de mangas. Isto é o algoritmo da pesquisa em largura em ação.

## Exercicios:

1. https://leetcode.com/problems/range-sum-of-bst/description/

2. https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/description/

3. https://leetcode.com/problems/increasing-order-search-tree/description/
