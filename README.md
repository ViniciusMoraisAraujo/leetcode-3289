3289. The Two Sneaky Numbers of Digitville (LeetCode)
Este repositório contém a minha solução para o problema 3289 do LeetCode, "The Two Sneaky Numbers of Digitville".

📜 Descrição do Problema
Na cidade de Digitville, havia uma lista de números chamada nums contendo inteiros de 0 a n - 1. Cada número deveria aparecer exatamente uma vez na lista, no entanto, dois números travessos entraram uma vez adicional, tornando a lista maior do que o normal.

Como detetive da cidade, sua tarefa é encontrar esses dois números travessos. Retorne um array de tamanho dois contendo os dois números (em qualquer ordem), para que a paz possa retornar a Digitville.

Exemplos
Exemplo 1:

Input: nums = [0,1,1,0]
Output: [0,1]
Explicação: Os números 0 e 1 aparecem duas vezes no array.
Exemplo 2:

Input: nums = [0,3,2,1,3,2]
Output: [2,3]
Explicação: Os números 2 e 3 aparecem duas vezes no array.
Exemplo 3:

Input: nums = [7,1,5,4,3,4,6,0,9,5,8,2]
Output: [4,5]
Explicação: Os números 4 e 5 aparecem duas vezes no array.
Restrições
2 <= n <= 100

nums.length == n + 2

0 <= nums[i] < n

A entrada é gerada de forma que nums contém exatamente dois elementos repetidos.