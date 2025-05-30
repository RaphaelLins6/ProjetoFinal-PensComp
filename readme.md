# Diagnóstico Médico Inteligente

Um sistema web interativo para simulação de diagnósticos médicos baseado em sintomas informados pelo usuário. O objetivo é auxiliar estudantes e profissionais a compreenderem a lógica de triagem clínica, utilizando conceitos de programação e integração entre frontend e backend.

---

## 💡 Valor do Projeto

Este projeto resolve o problema de triagem inicial de sintomas, permitindo que qualquer pessoa insira sintomas e obtenha uma sugestão automatizada de diagnóstico. Ele se encaixa na disciplina de Pensamento Computacional ao abordar:

- **Fundamentos do Pensamento Computacional:** aplicação prática de lógica e algoritmos para análise de sintomas.
- **Máquinas Computacionais:** uso de APIs e sistemas web para simular o raciocínio clínico.
- **Aplicações Práticas:** integração entre frontend e backend, mostrando como o pensamento computacional é utilizado em soluções reais.
- **Resolução de Problemas e Modelagem:** modelagem de regras de diagnóstico e automação da triagem.
- **Tratamento de Erros:** validação de dados e respostas apropriadas para diferentes cenários.
- **Limitações:** demonstração dos limites de diagnósticos automatizados e a importância do acompanhamento profissional.

Assim, o sistema exemplifica como o Pensamento Computacional pode ser aplicado em todas as etapas do desenvolvimento de soluções tecnológicas para problemas do cotidiano.

---

## 🛠️ Ferramentas Utilizadas

- **C#** (ASP.NET Core) — Backend da API
- **HTML5** e **CSS3** — Interface web moderna e responsiva
- **JavaScript** — Comunicação frontend-backend
- **Swagger** — Documentação e testes da API
- **Visual Studio Code** — Ambiente de desenvolvimento
- **.NET 6/7** — Plataforma de execução

---

## 👥 Equipe

Turma de Ciência da Computação - UDF

- [@RaphaelLins6](https://www.github.com/RaphaelLins6) - Raphael Lins (RGM:27797660)
- [@jotape99](https://www.github.com/jotape99) - João Pedro (RGM:28167333)
- [@joaogkt](https://www.github.com/joaogkt) - João Gabriel (RGM:28017188)

---

## 🚀 Contribuição de Cada Membro

- **Raphael Lins:** Estruturação do backend em C#, criação dos controllers, implementação da lógica de diagnóstico médico, integração da API com o frontend, configuração do Swagger e documentação técnica do projeto.
- **João Pedro:** Desenvolvimento da interface web (HTML, CSS e JavaScript), estilização moderna (preto e laranja), responsividade, experiência do usuário e integração das requisições com a API.
- **João Gabriel:** Testes de usabilidade do sistema, revisão de código, validação das regras de negócio, auxílio na documentação e suporte na integração entre frontend e backend.

---

## 🎬 Demonstração

### Tela Inicial
<img src="./DiagnosticoMedicoApi/Images/TelaInicial.png" alt="Tela Inicial" width="450" height="400" style="border: 15px solid #ccc; border-radius: 25px;" />

### Diagnóstico Gerado
<img src="./DiagnosticoMedicoApi/Images/ResultadoGerado.png" alt="Diagnóstico" width="450" height="400" style="border: 15px solid #ccc; border-radius: 25px;" />

> Vídeo da aplicação!

https://github.com/user-attachments/assets/72910f31-595b-456e-8aaf-e3db326df0e9

---

## 🚀 Como Usar

1. Execute a API com o comando:
   ```
   dotnet run --project DiagnosticoMedicoApi
   ```
2. Acesse [http://localhost:5105/index.html](http://localhost:5105/index.html) no navegador.
3. Preencha os sintomas (separados por vírgula), marque as opções desejadas e clique em **Diagnosticar** para receber o resultado de forma visual e interativa.

---

## 📄 Licença

Este projeto está licenciado sob a GNU General Public License v3.0 (GPLv3).  
Sinta-se livre para usar, modificar e compartilhar!

---

> Projeto acadêmico desenvolvido para a disciplina de Pensamento Computacional – 8º Semestre.
