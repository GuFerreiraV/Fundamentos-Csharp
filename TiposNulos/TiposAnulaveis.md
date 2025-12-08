## Nullable Types
- A partir do C# 8.0, foi introduzido o conceito de tipos anuláveis (nullable types) para tipos de referência.
- Os nullabele types permitem atribuir o valor a um tipo de valor.

```csharp
Nullable <T> <nome> = null;
```
- Os nullable types suportam os valores do tipo + null.
- Ex: ```Nullable <boolean> isActive = null```; // suporta true, false e null

- Sintaxe simplificada:
```csharp
int? idade = null; // equivalente a Nullable<int>
double? salario = null; 
float? altura = 1.75f;
bool? isActive = null;
```