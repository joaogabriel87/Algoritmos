# QuickSort

QuickSort é um algoritmo eficiente de ordenação por divisão e conquista. O funcionamento do QuickSort baseia-se em uma rotina fundamental cujo nome é particionamento. Particionar significa escolher um numero qualquer presente no array, chamado de pivô, e colocar em na posição tal que todos os elementos á esquerda são menores ou iguais e todos os elementos a direita são maiores

## Particionamento

- Escolha um elemento do array, denominado de pivô
- Particiona: rearranje o array de forma que todos os elementos anteriores ao pivô seja menores que ele, e todos os elementos posteriores ao pivô sejam maiores que ele. Ao fim do processo o pivô estará em sua posição final e haverá duas sub lista não ordenadas. Essa operação é chamada de partição
- Recursivamente ordene a sub lista dos elementos menores e a dos maiores
- O caso base da recursão são lista de tamanho zero ou um, que estão sempre ordenadas. O processo é finito, pois a cada iteração pelo menos um elemento é posto em sua posição final e não será mais manipulado na iteração seguinte

## Características

- A estratégia DC funciona por meio de divisão do problema em problema menores. Se você estiver utilizando DC em uma lista, o caso-base provavelmente será um array vazio ou array com apenas um elemento
- Se você estiver implementando o QuickSort, escolha um elemento aleatório como pivô. O tempo de execução médio do QuickSort é O(n log n)!
- A constante, na notação Big O, pode ser relevante em alguns casos, Esta é a razão pela qual o QuickSort é mais rápido do que o merge sort
- A constante dificilmente será relevante na comparação entre pesquisa simples e pesquisa binaria, pois O(log n) é muito mais rápido do que o O(n) quando sua lista é grande
