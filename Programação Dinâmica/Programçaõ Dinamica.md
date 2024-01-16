# Programação dinâmica

A programação dinâmica é uma técnica de otimização que envolve a resolução de subproblemas sobrepostos para alcançar uma solução ótima. É amplamente utilizada quando se busca otimizar algo em relação a um limite.

## Características:

- Toda solução de programação dinâmica envolve uma tabela
- Os valores nas células são, geralmente, o que você esta tentando otimizar. Para o problema da mochila, os valores nas células eram os valores dos itens
- Cada célula é um subproblema, portanto pense em como você pode dividi-lo em outros subproblemas, pois isso lhe ajudara a descobrir quais são seus eixos
- A programação dinâmica é muito útil quando você esta tentando otimizar algo em relação a um limite
- Você pode utilizar a programação dinâmica quando o problema puder ser divido em subproblemas discretos
- Não existe formula única para calcular uma solução em programação dinâmica

## Exemplo:

Um exemplo clássico de programação dinâmica é o problema da sequência de Fibonacci. A sequência de Fibonacci é uma série de números em que cada número é a soma dos dois anteriores: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...

Podemos resolver esse problema de forma eficiente utilizando programação dinâmica. Podemos criar uma função recursiva que calcula cada número da sequência, mas isso resultaria em muitos cálculos repetidos. Em vez disso, podemos usar uma tabela para armazenar os valores já calculados e reutilizá-los conforme necessário.

Veja o código abaixo para implementar a sequência de Fibonacci usando programação dinâmica:

```python
def fibonacci(n):
    fib = [0, 1] # Inicializa os primeiros dois números da sequência
    for i in range(2, n+1):
        fib.append(fib[i-1] + fib[i-2]) # Calcula o próximo número da sequência
    return fib[n] # Retorna o número desejado

print(fibonacci(10)) # Exemplo de uso: imprime o décimo número da sequência de Fibonacci

```

Neste exemplo, a programação dinâmica nos permite calcular rapidamente qualquer número da sequência de Fibonacci, evitando cálculos repetidos e melhorando a eficiência do algoritmo.

## Exercicios:

1. https://leetcode.com/problems/counting-bits/description/

2. https://leetcode.com/problems/pascals-triangle/description/

3. https://leetcode.com/problems/fibonacci-number/
