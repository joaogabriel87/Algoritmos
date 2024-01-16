# Algoritmo dos K-vizinhos

O algoritmo dos K-vizinhos mais próximos, também conhecido como KNN (do inglês K-Nearest Neighbors), é utilizado tanto para classificação quanto para regressão. Ele envolve observar os K-vizinhos mais próximos a um determinado item e tomar uma decisão com base na maioria ou na média das respostas desses vizinhos.

Na classificação, o algoritmo é utilizado para classificar itens em grupos ou categorias. Já na regressão, o objetivo é adivinhar uma resposta numérica.

Antes de aplicar o algoritmo, é necessário extrair características dos itens, convertendo-os em uma lista de números que possam ser comparados. A escolha de boas características é fundamental para o bom funcionamento do algoritmo dos K-vizinhos mais próximos.

## Características:

- O algoritmo dos K-vizinhos mais próximos é utilizado na classificação e também na regressão. Ela envolve observar os K-vizinhos mais próximos
- Classificação = Classificar em grupos
- Regressão = Adivinhar uma respostas(Como um número)
- Extrair características significa converter um item (Como uma fruta ou um usuário) em uma lista de números que podem ser comparados
- Escolher boas característica é uma parte importante para que um algoritmo dos K-vizinhos mais próximo opere corretamente

## Exemplo:

Suponha que estamos trabalhando em um problema de classificação de flores com base em suas características. A seguir, mostraremos um exemplo de aplicação do algoritmo dos K-vizinhos mais próximos.

1. Coletar dados: Medir a largura e o comprimento das pétalas e sépalas de várias flores.
2. Escolher o valor de K: Decidir o número de vizinhos mais próximos a serem considerados para a classificação. Por exemplo, K = 3.
3. Calcular distâncias: Calcular a distância entre a nova flor que queremos classificar e todas as outras flores disponíveis nos dados de treinamento. Normalmente, a distância euclidiana é utilizada para esse cálculo.
4. Selecionar os K-vizinhos mais próximos: Identificar as K flores com as menores distâncias em relação à nova flor.
5. Realizar votação: Determinar a classe da nova flor com base na maioria das classes dos K-vizinhos mais próximos. Por exemplo, se 2 das K flores são da classe "rosa" e 1 é da classe "tulipa", a nova flor será classificada como "rosa".

Esse é um exemplo básico de como o algoritmo dos K-vizinhos mais próximos pode ser aplicado na classificação de flores.
