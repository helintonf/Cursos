
# C02 - Números e Strings

- No universo Python, os termos que são utilizados são números e strings.

## C02.1 - Números

- Python 3 possui três tipos de números `int`, `float` e `complex`.
- Números inteiros são ilimitados e podem crscer até o limite da memória.
- Ints e Longs sao unificados, um inteiro pode tornar-se um longo se ultrapassasse i limite de `sys.maxint`
    
### Exemplo
```python

#Int
    int(1.0)
    # 1
    int('9')
    # 9

#Float
    float(1)
    # 1.0
    float('9.2')
    # 9.2
    float('-inf')
    # -inf
    float('nan')
    # nan

#Complex
    complex(1,2)
    # (1+2j)

```

### Operadores aritméticos

- Adição: 
    + `x + y`.
- Subtração: 
    + `x - y`.
- Divisão em ponto flutuante com parte fracionaria:
    + `x / y`.
- Divisão sem fração e sem ponto flutuante:
    + `x // y`.
- Multiplicação:
    + `x * y`.
- Resto:
    + `x % y`.
- Negação:
    + `-x`.
- Potência:
    + `x ** y`.

### Operadores de bits

- Ou:
    - `x | y`.
- Ou exclusivo:
    - `x ^y`.
- E:
    - `x & y`.
- Inverso:
    - `~x`
- x com y btis deslocados à esquerda:
    - `x << y`.
- x com y bits deslocados à direita:
    - `x >> y`.

### Regras de Coerção    

- Existe uma política de coerção de números que define qual tipo resultante de uma operação que mistura tipos diferentes de números.
- int + float = float
- int + complex = complex
- float + complex = conplex

### Função Type()

- Retorna o tipo(ou classe) de um objeto.
- Porem é recomendado o usu da função `isinstace(obj,class)` para realizar teste em condicionas.
- Para meras verificações nos terminais u se `type()`.

## C02.2 - Como Manipular Texto

- Em Python existe apenas `strings` que é um tipo `classe`.
- Elas são sequêcias de caracteres de tamanho até o máximo suportado.

## C02.3 - Criando e Manipulando Texto

- Os formatos principais são com `'...'` e `"..."`.
- Sendo que ao usar um, o outro podeser ser usado internamente:
    - Ex01. `'-----"||||"-----'`.
    - Ex02. `"-----'||||'-----"`.

# Strings



