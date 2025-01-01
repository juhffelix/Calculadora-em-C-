# Calculadora em C#

## 📝 Descrição
Este é um projeto simples de uma calculadora desenvolvida em **C#**, com o objetivo de relembrar conceitos básicos de lógica de programação e manipulação de dados no console.

## 🚀 Funcionalidades
A calculadora suporta as seguintes operações:
1. **Soma**
2. **Subtração**
3. **Multiplicação**
4. **Divisão**
5. **Encerrar o programa**

Cada operação é implementada de forma modular, em métodos separados.

## 📂 Estrutura do Código
- **Enum `Menu`**: Enumeração para representar as opções do menu.
- **Métodos**:
  - `Soma()`: Realiza a soma de dois números.
  - `Subtrair()`: Realiza a subtração de dois números.
  - `Multiplicar()`: Realiza a multiplicação de dois números.
  - `Dividir()`: Realiza a divisão de dois números.
- **Loop Principal (`Main`)**:
  - Exibe o menu de opções para o usuário.
  - Lê a entrada do usuário e executa a operação correspondente.
  - Oferece a opção de sair do programa.

## 💻 Como Usar
1. Clone o repositório e compile o projeto.
2. Execute o programa.
3. No menu principal:
   - Escolha uma opção digitando o número correspondente.
4. Insira os números necessários para realizar a operação.
5. Veja o resultado.
6. Pressione qualquer tecla para voltar ao menu ou escolha **Encerrar calculadora** para finalizar o programa.

## 🛠️ Tecnologias Utilizadas
- **Linguagem**: C#
- **Framework**: .NET (Console Application)

## 📚 Conceitos Relembrados
- Estruturas de controle como `while`, `switch`, e `if`.
- Leitura e escrita no console com `Console.ReadLine` e `Console.WriteLine`.
- Uso de `enum` para criar um menu de opções.
- Métodos para organizar operações matemáticas.
- Formatação de números com `ToString("F1", CultureInfo.InvariantCulture)`.

## 📦 Estrutura do Repositório
```plaintext
Calculadora/
├── Calculadora.csproj
├── Program.cs
└── README.md
