# 🏨 Sistema de Reserva de Hotel em C#

*Um projeto de console desenvolvido como parte do desafio "Explorando C# na Prática" da Digital Innovation One. O objetivo é aplicar os conceitos de Programação Orientada a Objetos (POO) para criar um sistema funcional de reserva de hotel.*

<p align="center">
  <img src="https://img.shields.io/badge/C%23-11.0-512BD4?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C# 11">
  <img src="https://img.shields.io/badge/.NET-6.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 6">
  <img src="https://img.shields.io/badge/licen%C3%A7a-MIT-green?style=for-the-badge" alt="Licença MIT">
  <img src="https://img.shields.io/badge/status-Conclu%C3%ADdo-brightgreen?style=for-the-badge" alt="Status Concluído">
</p>

---

## 📜 Sobre o Projeto

Este projeto é uma aplicação de console que simula as operações básicas de um sistema de reservas de hotel. Ele permite cadastrar suítes com diferentes capacidades e valores, adicionar hóspedes a uma reserva e calcular o custo total da estadia, aplicando descontos para períodos mais longos. A arquitetura foi pensada para ser simples, clara e demonstrar a utilização de classes, encapsulamento, abstração e composição.

---

## ✨ Funcionalidades Principais

*   **Modelagem de Entidades**: Classes bem definidas para `Pessoa`, `Suite` e `Reserva`.
*   **Gerenciamento de Suítes**: Capacidade de definir diferentes tipos de suítes, com controle de capacidade e valor de diária.
*   **Sistema de Reserva**: Mecanismo para criar uma reserva, associando hóspedes a uma suíte por um período determinado.
*   **Cálculo de Diárias**: Lógica para calcular o valor total da hospedagem, aplicando um desconto de 10% para estadias superiores a 10 dias.
*   **Controle de Capacidade**: Validação que impede a adição de hóspedes além da capacidade permitida pela suíte.

---

## 🏗️ Diagrama de Classes (UML)

O diagrama abaixo ilustra a relação entre as principais classes do sistema. Uma `Reserva` é composta por uma `Suite` e uma lista de `Hospedes` (que são `Pessoa`).

```mermaid
classDiagram
    class Pessoa {
        +string Nome
        +int Idade
    }

    class Suite {
        +string Tipo
        +decimal ValorDiaria
        +int Capacidade
    }

    class Reserva {
        +List~Pessoa~ Hospedes
        +Suite Suite
        +int DiasReservados
        +AdicionarHospede(Pessoa hospede) void
        +ObterQuantidadeHospedes() int
        +CalcularValorTotal() decimal
    }

    Reserva "1" -- "1" Suite : Possui
    Reserva "1" -- "0..*" Pessoa : Hospeda