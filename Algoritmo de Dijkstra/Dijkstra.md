# Algoritmo de Dijkstra

O algoritmo de Dijkstra é um algoritmo de caminho mínimo usado em grafos. Ele é usado para encontrar o caminho mais curto entre dois vértices em um grafo ponderado, onde os pesos são associado ás arestas.

O gráfico funciona através da construção de uma arvore de caminho mínimo. Ele começa com uma vértice inicial, e, em seguida, explora todos os seus vizinhos, atualizando o custo para alcançar cada um deles. Em seguida, o algoritmo seleciona o vértice com o custo mais baixo e repete o processo

## Terminologia:

Quando você trabalha com o algoritmo de Dijkstra, cada aresta do grafo tem um número associado a ele. Eles são chamado de pesos.

Um grafo com pesos é chamado de grafos ponderados. Um grafo sem peso é chamado de grafo não ponderado

## Características:

- A pesquisa em largura é usada para calcular o caminho mínimo para um grafo não ponderado
- O algoritmo de Dijkstra é usado para calcular o caminho mínimo para um grafo ponderado
- O algoritmo de Dijkstra funciona quando todos os pesos são positivos
- Se o seu grafo tiver pesos negativos, use o algoritmo de Bellman-Ford

## Exemplo:

Rama está tentando trocar um livro de música por um piano.
“Eu troco este pôster pelo seu livro”, diz Alex. “É um pôster da minha banda favorita, Destroyer. Ou então darei este LP raro do Rick Astley pelo seu livro e mais 5 reais.” “Ooh, ouvi dizer que esse LP tem músicas muito boas”, diz
Amy. “Trocarei com você meu baixo ou minha bateria pelo pôster ou pelo
LP.”

“Eu estava com vontade de aprender baixo!”, exclamou Beethoven. “Ei, troco meu piano por qualquer uma das coisas da Amy.” Perfeito! Com um pouco de dinheiro, Rama consegue trocar seu livro de piano por um piano de verdade. Agora ele só precisa descobrir como gastar a menor quantia ao fazer essas trocas. Vamos fazer um grafo do que foi
oferecido.

![AlgoritmoDijkstra](./Algoritmo%20Dijstra.png)

Neste grafo, os vértices são todos os itens que Rama pode trocar. Analisando a imagem, é possível observar que ele pode trocar o pôster pelo baixo por R$ 30, ou trocar o LP pelo baixo por R$ 15. Como Rama descobrirá o caminho do livro até o piano por meio do qual ele gasta a menor quantia? Este é o papel do algoritmo de Dijkstra! Lembre-se de que o algoritmo de Dijkstra é separado em quatro passos. Assim, neste exemplo, você executará estes quatro passos e, ao fim, conseguirá calcular o caminho final.
