
# 📱 Desafio de Projeto: Abstração de um Celular em C#

[![C#](https://img.shields.io/badge/C%23-11.0-512BD4?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/dotnet/csharp/) 
[![.NET 6](https://img.shields.io/badge/.NET-6.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/) 
[![MIT License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)](https://opensource.org/licenses/MIT) 
[![Status Concluído](https://img.shields.io/badge/Status-Conclu%C3%ADdo-brightgreen?style=for-the-badge)](https://github.com/digitalinnovationone/trilha-net-ego-desafio)

**Repositório do Desafio:** [trilha-net-ego-desafio](https://github.com/digitalinnovationone/trilha-net-ego-desafio)  
**Canal Youtube:** Leonardo Buta  
**GitHub do Mentor:** [leonardo-buta](https://github.com/leonardo-buta)  
**LinkedIn do Mentor:** [Leonardo Buta](https://www.linkedin.com/in/leonardo-buta)  
**Instagram do Mentor:** @libuta  

---

## 📝 Introdução

Este projeto foi desenvolvido para atender ao desafio de Programação Orientada a Objetos (POO) da Digital Innovation One. O objetivo principal é criar um sistema em **C# .NET 6** que modele um **smartphone genérico**, e a partir dele, implementar modelos específicos como **Nokia** e **iPhone**.  

O foco da solução foi aplicar os **pilares da POO**:

- **Abstração:** Criar um modelo genérico de smartphone que define propriedades e comportamentos essenciais.  
- **Herança:** Reutilizar código comum em classes específicas (Nokia e iPhone).  
- **Polimorfismo:** Permitir que cada classe filha tenha comportamentos específicos para métodos compartilhados.  

O projeto inclui **diagrama UML**, badges visuais e documentação detalhada sobre a arquitetura do sistema.

---

## 🏗️ Estrutura do Projeto

trilha-net-ego-desafio/ ├── README.md ├── Program.cs ├── Models/ │   ├── Smartphone.cs │   ├── Nokia.cs │   └── Iphone.cs └── ...

---

## 💡 Conceitos Aplicados

### 1. Abstração
- **Classe abstrata `Smartphone`**: define propriedades e métodos essenciais que todas as subclasses devem implementar.
- **Método `InstalarAplicativo()`** declarado como `abstract`, obrigando cada celular a ter sua própria implementação.

### 2. Herança
- **Classes `Nokia` e `Iphone`**: herdam de `Smartphone`, reutilizando métodos comuns e propriedades.

### 3. Polimorfismo
- **Método `InstalarAplicativo()` sobrescrito** em cada modelo, permitindo comportamentos distintos.

---

## 📊 Diagrama de Classes (UML)

```mermaid
classDiagram
    class Smartphone {
        <<abstract>>
        +string Numero
        +Ligar()
        +ReceberLigacao()
        +InstalarAplicativo(string nomeApp)*
    }

    class Nokia {
        +InstalarAplicativo(string nomeApp)
    }

    class Iphone {
        +InstalarAplicativo(string nomeApp)
    }

    Smartphone <|-- Nokia
    Smartphone <|-- Iphone


---

👨‍💻 Sobre o Desenvolvedor

Lucas Gabriel de Morais
📞 (62) 98245‑6245 | 📧 lucasescobarmorais@gmail.com
🌍 Goiânia – GO | Disponível para trabalho remoto, híbrido ou presencial
🔗 LinkedIn
📅 Nasc.: 22/04/1996 | 💼 Solteiro, sem filhos
✈️ Disponível para viagens a trabalho

♿ Neurodiversidade como Força

Como neurodivergente (Síndrome de Asperger), possuo hiperfoco, atenção aos detalhes e resiliência, atuando com excelência em ambientes técnicos sensíveis e de alta complexidade.

📂 Portfólio e Contato

    


---

🤝 Considerações Finais

Sou impulsionado por desafios reais e soluções técnicas eficientes. Valorizo ambientes que prezam por integridade, autonomia e impacto positivo. Estou à disposição para entrevistas, desafios técnicos ou envio de projetos práticos.

Atenciosamente,
Lucas Gabriel de Morais
Especialista em Cibersegurança | Engenheiro de Software | Bug Bounty Hunter
