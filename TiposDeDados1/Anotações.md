# Tipos de Dados

> C# é uma linguagem de programação fortemente tipada, o que significa que cada variável deve ter um tipo de dado específico. 

## Tipos de Dados

####  Tipos de Referência
- Não armazenam os dados diretamente e cada variável contém uma referência ao local da memória onde os dados estão armazenados
- Os tipos de referência são armazenados na memória Heap.
- Exemplo: **Objetos, Class, Strings, Dynamic.**
	- ``string`` -> Representa uma sequência de caracteres Unicode.
	- ``object`` -> Tipo base de todos os tipos em C#.
	- ``dynamic`` -> Permite a atribuição de qualquer tipo de dado em tempo de execução.

#### Tipos de Valor
- Armazenam diretamente sesus dados e cada variável tem sua própria cópia dos dados.
- Os tipos de valor são armazenados na memória Stack (LIFO - Last In, First Out).
- Exemplos:
- Não númericos: 
	- **bool** (Boolean)
	- **char** (Caractere Unicode de 16 bits)
	- **enum** (Enumeração)
	- **Datetime** (Data e Hora)
- Númericos:
	- *Inteiros*
		- **sbyte** (Inteiro com sinal de 8 bits) /  **byte** (Inteiro sem sinal de 8 bits)
		- **short** (Inteiro com sinal de 16 bits) / **ushort** (Inteiro sem sinal de 16 bits)
		- **int** (Inteiro com sinal de 32 bits) / **uint** (Inteiro sem sinal de 32 bits)
		- **long** (Inteiro com sinal de 64 bits) / **ulong** (Inteiro sem sinal de 64 bits)
		- **nint** (Inteiro com sinal do tamanho da plataforma) / **nuint** (Inteiro sem sinal do tamanho da plataforma)
	- *Ponto Flutuante*
		- **float** (Ponto flutuante de precisão simples de 32 bits)
		- **double** (Ponto flutuante de precisão dupla de 64 bits)
		- **decimal** (Número decimal de alta precisão de 128 bits, usado principalmente para cálculos financeiros)
---
## Variáveis e Constantes

- Uma ``variável`` é um nome que representa a informação armazenada na memória durante a execução da aplicação.
- Uma ``constante`` é uma variável cujo valor não pode ser alterado durante o tempo de vida do programa.