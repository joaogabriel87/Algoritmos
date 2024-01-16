# Algoritmo Guloso

Algoritmo gulosos em geral são usados em problemas de otimização onde é interessante realizar um conjunto de melhores soluções locais, possuindo como objetivo obter uma solução ótima global, tomando como base um determinado parâmetro. Os parâmetros que definem o que será a melhor solução durante a iteração irá varia para cada problema

## Características:

- Algoritmo gulosos otimizam localmente na esperança de acabar em uma otimização global
- Problemas NP-completos não tem uma solução rápida
- Se você estiver tentando resolver um problema NP-completo, o melhor a fazer é usar um algoritmo de aproximação
- Algoritmo gulosos são fáceis de escrever e tem tempo de execução baixo, portanto eles são algoritmo de aproximação

## Exemplo:

Suponha que você tenha uma sala de aula e queira reservar o máximo de
aulas possível nela. Assim, recebe-se uma lista das aulas.

![Guloso](Algoritmo%20Guloso.png)

Você não pode reservar todas essas aulas na sala porque os horários de
algumas delas coincidem. Soa como um problema difícil, não? Na realidade, o algoritmo é tão simples
que pode surpreender. Aqui temos o funcionamento dele:

1. Pegue a aula que termina mais cedo. Esta é a primeira aula que você
   colocará nessa sala.
2. Agora você precisa pegar uma aula que comece depois da primeira aula. De novo, pegue a aula que termine mais cedo. Esta é a segunda aula que você colocará. Continue fazendo isso e no final você terá a sua resposta!
