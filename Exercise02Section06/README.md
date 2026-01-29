# Exercício 02 - Seção 06

## Descrição / Description
**[PT]** Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.

**[EN]** Write a program to read an integer N and then the data (id, name, and salary) of
N employees. There should be no duplicate ids.

Then, perform an increase of X percent in the salary of a specific employee.
For this, the program should read an id and the value X. If the informed id does not exist, show a
message and abort the operation. At the end, show the updated list of employees,
as per the examples.

Remember to apply the encapsulation technique to not allow the salary to be
changed freely. A salary can only be increased based on a percentage increase operation.

## Exemplo de Entrada 1 / Input Example 1

```text
3
333
Maria Brown
4000.00
536
Alex Grey
3000.00
772
Bob Green
5000.00
536
10.0
```

## Saída 1 / Output 1

```text
How many employees will be registered? 3
Employee #1:
Id: 333
Name: Maria Brown
Salary: 4000.00
Employee #2:
Id: 536
Name: Alex Grey
Salary: 3000.00
Employee #3:
Id: 772
Name: Bob Green
Salary: 5000.00
Enter the employee id that will have salary increase: 536
Enter the percentage: 10.0
Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3300.00
772, Bob Green, 5000.00
```

## Exemplo de Entrada 2 / Input Example 2

```text
2
333
Maria Brown
4000.00
536
Alex Grey
3000.00
776
```

## Saída 2 / Output 2

```text
How many employees will be registered? 2
Emplyoee #1:
Id: 333
Name: Maria Brown
Salary: 4000.00
Emplyoee #2:
Id: 536
Name: Alex Grey
Salary: 3000.00
Enter the employee id that will have salary increase: 776
This id does not exist!
Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3000.00
```