# Exercício 01 - Seção 05

## Descrição / Description
**[PT]** Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.

Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).

Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.

Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação.

**[EN]** In a bank, to register a bank account, it is necessary to provide the account number, the account holder's name, and the initial deposit amount that the holder deposited when opening the account. However, this initial deposit amount is optional, meaning: if the holder does not have money to deposit at the moment of opening the account, the initial deposit will not be made, and the initial balance will naturally be zero.

Important: Once a bank account is opened, the account number can never be changed. On the other hand, the holder's name can be changed (since a person can change their name due to marriage, for example).

Finally, the account balance cannot be changed freely. There must be a mechanism to protect this. The balance only increases through deposits and only decreases through withdrawals. For every withdrawal made, the bank charges a fee of $ 5.00.
Note: The account may have a negative balance if the funds are insufficient to perform the withdrawal and/or pay the fee.

The Task: You must write a program that registers an account, providing the option to enter an initial deposit value or not. Then, perform a deposit and then a withdrawal, always displaying the account data after each operation.

## Exemplo de Entrada / Input Example
```text
8532
Alex Green
s
500.00
200.00
300.00
```

## Saída / Output
```text
Entre o número da conta: 8532
Entre o titular da conta: Alex Green
Haverá depósito inicial (s/n)? s
Entre o valor de depósito inicial: 500.00

Dados da conta:
Conta 8532, Titular: Alex Green, Saldo: $ 500.00

Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 700.00

Entre um valor para saque: 300.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 395.00
```

## Exemplo de Entrada 2 / Input Example 2
```text
7801
Maria Brown
n
200.00
198.00
```

## Saída 2 / Output 2
```text
Entre o número da conta: 7801
Entre o titular da conta: Maria Brown
Haverá depósito inicial (s/n)? n

Dados da conta:
Conta 7801, Titular: Maria Brown, Saldo: $ 0.00

Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 7801, Titular: Maria Brown, Saldo: $ 200.00

Entre um valor para saque: 198.00
Dados da conta atualizados:
Conta 7801, Titular: Maria Brown, Saldo: $ -3.00
```