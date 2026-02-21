# 📋 Sistema de Avaliação de Serviços - Windows Forms (C#)

Este é um projeto desenvolvido em **C# utilizando Windows Forms**, com o objetivo de criar um sistema simples de **avaliação de serviços**, permitindo que o usuário informe seu nome, selecione um tipo de serviço e atribua uma avaliação.

## 🧠 Objetivo do Projeto

O sistema foi criado como parte de uma atividade prática com foco em:

* Manipulação de componentes do Windows Forms
* Uso de eventos
* Validação de dados
* Manipulação de ListBox e ListView
* Organização de interface gráfica

---

## 🖥️ Funcionalidades

✔ Inserir nome do usuário
✔ Selecionar o tipo de serviço avaliado:

* Atendimento
* Produto
* Ambiente

✔ Escolher uma avaliação:

* Excelente
* Bom
* Regular
* Ruim
* Péssimo

✔ Registrar automaticamente a data e hora da avaliação

✔ Exibir todas as avaliações em uma tabela (ListView)

✔ Limpar os campos após o envio

✔ Validação para evitar envio com campos vazios

---

## 🧩 Componentes Utilizados

* `TextBox` → Entrada do nome
* `ListBox` → Seleção do tipo de serviço
* `RadioButton` → Seleção da avaliação
* `Button` → Enviar avaliação
* `ListView` → Exibir os dados cadastrados
* `MessageBox` → Exibir mensagens de validação

---

## 🏗️ Estrutura do Projeto

```
Atividade_Pratica_AP1/
│
├── Ap2.cs
├── Ap2.Designer.cs
├── Program.cs
└── README.md
```

---

## ⚙️ Como Funciona

Quando o usuário clica no botão **Enviar Avaliação**:

1. O sistema captura:

   * Nome
   * Serviço selecionado
   * Avaliação escolhida
   * Data e hora atual

2. Valida os dados

3. Se estiver tudo correto:

   * Adiciona ao ListView
   * Limpa os campos

4. Caso contrário:

   * Exibe mensagem de erro

---

## 💻 Tecnologias Utilizadas

* C#
* .NET Framework
* Windows Forms
* Visual Studio

---

## 📷 Exemplo de Funcionamento

| Nome | Serviço     | Avaliação | Data e Hora      |
| ---- | ----------- | --------- | ---------------- |
| João | Atendimento | Excelente | 21/02/2026 14:35 |

---

## 🎯 Aprendizados

Este projeto permitiu praticar:

* Programação orientada a eventos
* Interface gráfica com Windows Forms
* Manipulação de listas e tabelas
* Validação de formulários

---

## 🚀 Como Executar

1. Abra o projeto no **Visual Studio**
2. Compile o projeto
3. Execute pressionando:

```
F5
```

---

## 👨‍💻 Autor

Weberson Oliveira
Estudante de Análise e Desenvolvimento de Sistemas

Desenvolvedor C# | Suporte Técnico | Infraestrutura de Redes

---

## 📄 Licença

Este projeto é para fins educacionais.
