# 🍍 Virtual Pineapple

**Virtual Pineapple** é um jogo de plataforma 2D desenvolvido na *engine* Unity. Ambientado em um universo com estética cyberpunk e luzes neon, o jogador controla um sapo aventureiro em uma jornada que exige reflexos rápidos, domínio de parkour e exploração.

Este projeto foi desenvolvido como trabalho acadêmico para demonstrar a aplicação prática de conceitos de Game Design, Lógica de Programação em C# e Level Design.

---

## 📸 Imagens do Jogo
*(Observação para o aluno: após subir seus prints para o GitHub, você pode arrastar as imagens diretamente para esta linha do editor de texto para elas aparecerem aqui!)*

---

## ⚙️ Mecânicas do Jogo

O jogo foi construído focado em precisão e coleta, implementando as seguintes mecânicas principais:

* **Movimentação e Física 2D:** Uso de `Rigidbody2D` para gravidade simulada e movimentação fluida.
* **Pulo Duplo (*Double Jump*):** Habilidade essencial liberada para o jogador alcançar plataformas distantes e planejar aterrissagens.
* **Sistema de Coleta Dinâmico:** O jogador precisa coletar 100% dos abacaxis da fase para avançar. O sistema (`GameManager`) detecta a quantidade de itens automaticamente independente da fase.
* **Zonas de Perigo (*Killzones*):** Espinhos estrategicamente posicionados que testam a habilidade do jogador de usar o pulo duplo com precisão.
* **Transição de Níveis:** Progressão automática ao cumprir os objetivos, navegando desde o Menu Principal, passando por 3 Fases de dificuldade crescente, até a Tela de Vitória.

---

## 🎮 Controles

Os controles foram mapeados para serem simples e intuitivos, seguindo o padrão de jogos de plataforma no PC:

* **A / Seta para Esquerda:** Move o personagem para a esquerda.
* **D / Seta para Direita:** Move o personagem para a direita.
* **Espaço (*Space*):** Pula (pressione novamente no ar para executar o Pulo Duplo).
* **Mouse:** Interação com os botões das interfaces de Menu e Tela Final.

---

## 🚀 Instruções de Execução

Existem duas formas de avaliar este projeto:

### 1. Jogando a versão exportada (Build)
1. Faça o download da pasta compactada contendo a *Build* do jogo (se disponibilizada pelo autor).
2. Extraia os arquivos em uma pasta no seu computador.
3. Dê um duplo-clique no arquivo executável `Virtual Pineapple.exe`.
4. O jogo abrirá em tela cheia. Utilize os botões interativos do menu para começar!

### 2. Abrindo o projeto na Unity (Para avaliação de código/cenas)
1. Clone este repositório para o seu computador:
```bash
   git clone [https://github.com/SEU-USUARIO-AQUI/virtual-pineapple-2d.git](https://github.com/SEU-USUARIO-AQUI/virtual-pineapple-2d.git)
