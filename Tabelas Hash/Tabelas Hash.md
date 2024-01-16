# Tabelas Hash

Tabelas Hash é uma estrutura de dados especial, que associa chaves de pesquisa(Hash) a valores. Seu objetivo é, a partir de uma chave simples, fazer uma busca rápida e obter o valor desejado.

Tabelas Hash são tipicamente usadas para implementar vetores associativos, sets e caches. O ganho com relação a outras estruturas associativas(como vetor simples) passa a ser maior conforme a quantidades de dados aumenta

## Função Hash:

A função Hash é a responsável por gerar um índice a partir de determinada chave. Caso a função seja mal escolhida, toda a tabela terá um mau desempenho. A ideia é que sejam sempre fornecidos índices únicos para as chaves de entrada, A função perfeita seria a que, quaisquer entrada A e B, sendo A diferente de B, fornecesse saídas diferentes. Quando a entrada A e B são diferentes e, passando pela função de espelhamento, geram a mesma saída, acontecendo o que chamamos colisão

## Característica :

- Modelar relações entre dois itens
- Filtrar por duplicatas
- Caching/memorização de dados, em vez de solicitar estes dados do servidor
- Você pode fazer uma tabela Hash ao combinar uma função Hash com um array
- Colisões são problemas. É necessário haver uma função hash que minimize colisões
- As tabelas hash são extremamente rápidas para pesquisar, inserir e remover itens
- Tabelas hash são boas para modelar relações entre dois itens
- As tabela hash são utilizadas como cache de dados(como em um servidor web)
- Tabelas Hash são ótimas para localizar duplicatas

## Exemplo:

O seu celular tem uma agenda telefônica integrada. Cada nome está associado a um número telefônico.

Imagine que você queira construir uma lista telefônica como esta. Será
necessário mapear o nome das pessoas e associá-los a números telefônicos. Dessa forma, a sua lista telefônica deverá ter estas funcionalidades:
• Adicionar o nome de uma pessoa e o número de telefone associado a este nome.
• Inserir o nome de uma pessoa e receber o número telefônico associado a ela.

Este é um exemplo perfeito de situações em que tabelas hash podem ser
usadas! As tabelas hash são ótimas opções quando
• Você deseja mapear algum item com relação a outro
• Você precisa pesquisar algo
