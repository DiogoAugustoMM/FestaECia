# 🎉 Festa & Cia - Sistema de Gerenciamento de Festas (POO)

Este projeto foi desenvolvido como parte do trabalho em grupo da disciplina de **Programação Orientada a Objetos**. O sistema simula o funcionamento da empresa *Festa & Cia*, especializada na organização e agendamento de eventos como casamentos, formaturas e festas corporativas.

## 🧩 Funcionalidades

- 📅 Agendamento de festas conforme disponibilidade e capacidade dos espaços
- 🏛️ Cadastro de espaços com diferentes capacidades
- 💍 Organização de casamentos com escolha de itens por categoria (Premier, Luxo, Standard)
- 🧾 Cálculo de preços com base nos serviços escolhidos
- 🍢 Escolha personalizada de comidas e bebidas
- 📊 Geração de resumo dos serviços contratados
- 🗓️ Exibição de calendário com festas agendadas
- 💾 Persistência dos dados em arquivos
- ⚠️ Tratamento de exceções para entradas inválidas

## 🏗️ Tecnologias Utilizadas

- Linguagem: **C#**
- Paradigmas: Programação Orientada a Objetos (POO)
- Armazenamento: Arquivos (txt/json/csv)
- Ferramentas: Visual Studio


## 📌 Tipos de Festa Suportados

| Tipo de Festa       | Serviços Fornecidos                                              |
|---------------------|------------------------------------------------------------------|
| Casamento           | Todos os serviços                                                |
| Formatura           | Todos exceto bolo                                                |
| Festa de Empresa    | Apenas espaço e bebidas                                          |
| Festa de Aniversário| Apenas itens padrão (Standard)                                   |
| Livre               | Apenas locação de espaço                                         |

## 💰 Cálculo de Preço

O preço da festa é composto por:

- Aluguel do espaço (preço fixo por tipo)
- Itens do casamento (preço por tipo e quantidade)
- Comidas (preço por convidado)
- Bebidas (preço unitário por item)

## 💾 Persistência

Todos os dados de festas realizadas são salvos automaticamente e recuperados ao iniciar o sistema.

## 🚫 Tratamento de Exceções

- Entradas inválidas (como números negativos)
- Datas indisponíveis
- Restrições de tipo de festa x itens disponíveis

## 📚 Requisitos do Projeto

O sistema foi desenvolvido em 4 sprints:
- **Sprint 1**: Agendamento de casamentos e definição de espaços
- **Sprint 2**: Cálculo de preços e inclusão de itens personalizados
- **Sprint 3**: Suporte a diferentes tipos de festas
- **Sprint 4**: Persistência de dados, geração de resumo e tratamento de erros


