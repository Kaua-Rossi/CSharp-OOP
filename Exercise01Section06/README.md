# Exercício 01 - Seção 06

## Descrição / Description
**[PT]** A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.

Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9).

Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.

**[EN]** The owner of a boarding house has ten rooms to rent to students,
with these rooms identified by numbers 0 to 9.

When a student wants to rent a room, the student's name and email must be registered.

Create a program that starts with all ten rooms empty, and then
reads a quantity N representing the number of students who will
rent rooms (N can be from 1 to 10). Then, register the rental of
the N students. For each rental registration, provide the student's name and email,
as well as which room they chose (from 0 to 9).

Assume that an empty room is chosen. At the end, your program should print
a report of all occupancies of the boarding house, sorted by room number,
as shown in the example.

## Exemplo de Entrada / Input Example

```text
3
Maria Green
maria@gmail.com
5
Marco Antonio
marco@gmail.com
1
Alex Brown
alex@gmail.com
8
```

## Saída / Output

```text
Quantos quartos serão alugados? 3

Aluguel #1:
Nome: Maria Green
Email: maria@gmail.com
Quarto: 5

Aluguel #2:
Nome: Marco Antonio
Email: marco@gmail.com
Quarto: 1

Aluguel #3:
Nome: Alex Brown
Email: alex@gmail.com
Quarto: 8

Quartos ocupados:
1: Marco Antonio, marco@gmail.com
5: Maria Green, maria@gmail.com
8: Alex Brown, alex@gmail.com
```