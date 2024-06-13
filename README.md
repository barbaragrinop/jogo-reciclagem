# Reciclando

## Sobre
Jogo 2D, coletar itens espalhos pelo cenário e leva-los ao cesto de lixo da cor correta, seguindo os princípios da reciclagem.

## Progresso
Imagens definidas, no processo de estruturação dos componentes internos.

29/05
- Criação dos Sprites: Player, Background e Lixeiras.
- Movimentação do Player: O jogador pode se mover em quatro direções (cima, baixo, esquerda e direita).
- Camera: Script que faz a câmera da cena acompanhar suavemente a movimentação do jogador.
- Limites do Cenário: Definição dos colliders que limitam o cenário.

05/06
- Sprites de Lixo Coletáveis: Criação dos sprites dos itens que podem ser coletados.
- Barreiras do Limite do Mapa: Implementação das barreiras que limitam o mapa.
- Ajustes na Camera: Melhorias no script que faz a câmera acompanhar o jogador.
- Coleta de Itens: Script que permite a coleta de itens e os armazena na interface do jogador.

10/06
- Coleta de Elementos Lixo: Script que permite ao jogador coletar elementos lixo.
- Verificação de Lixeira: Script que verifica se o lixo coletado corresponde à lixeira selecionada.
- Animações do Player: Implementação das animações do jogador.
- Contador de Pontos: Implementação de um contador que rastreia os pontos do jogador.
- Feedback de Lixeira: Mensagem de feedback que informa se o tipo de lixo coletado está sendo colocado na lixeira correta.
- Novos Sprites: Adição de novos sprites ao jogo.

12/06
- Página Inicial: Criação da página inicial com o botão jogar e o título do jogo.
- Trilha sonora: Implementado trilha sonora em loop para o jogo.
- Tela de Vitória: Implementação da tela de vitória.
- Tela de Derrota: Implementação da tela de derrota.
- Gerenciador de Tela de Vitória: Script que ativa a tela de vitória caso o jogador limpe a cena fazendo 20 pontos.
- Timer: Inserção de um temporizador.
- Gerenciador de Tela de Derrota: Script que ativa a tela de derrota se o jogador não completar o objetivo no tempo estipulado de 1:30.
- Tela de Tutorial "Como Jogar": Implementação da tela de tutorial e função de pause.
- Polimento e Balanceamento: Ajustes finais na mecânica e balanceamento do jogo.

## Tecnologias e IDEs utilizadas  
  - Unity
  - C#
  - Visual Studio

## Controles do Jogo
  - <b>Seta pra cima</b> ou <b>W</b>: Move para cima
  - <b>Seta pra baixo</b> ou <b>S</b>: Move para baixo
  - <b>Seta pra esquerda</b> ou <b>A</b>: Move para esquerda
  - <b>Seta pra direita</b> ou <b>D</b>: Move para direita
  - <b>Espaço</b>: Joga o lixo na lixeira
  - <b>P</b>: Pausa o jogo

## Jogue on-line
  - https://gradilone.itch.io/reciclagem-the-game

## Funcionalidades Finais

Objetivo: Limpar o cenário utilizando os princípios da reciclagem.

- Movimentação: Utilize as setas do teclado ou as teclas WASD para movimentar o personagem.
- Coleta de Lixo: Colete os lixos espalhados pelo cenário passando por cima deles.
- Descarte de Lixo: Com um lixo no inventário, pressione a tecla ESPAÇO quando próximo a uma lixeira para despejar o lixo de forma adequada.
- Pausa: Pressione a tecla P para pausar o jogo e exibir a tela "como jogar?".
- Condições de Vitória: Recicle todos os lixos do cenário, acumulando 20 pontos.
- Condição de Derrota: Não consiga limpar o cenário dentro do tempo limite.

## Feedbacks e Teste

Foram realizados testes com 3 voluntários e foi constado certa dificuldade para ler as informações da tela tutorial e o tempo da fase era curto demais tornando a gameplay complicada.

Implementações: Alterado a cor da fonte para cinza escuro oferecendo maior contraste e

    
## Autores do Projeto  
  - Barbara Hellen da Silva Pereira
  - Bruna Costa Pinheiro de Souza
  - Lucas Valias Gradilone
  - Nathalia Regina Vieira Teixeira

