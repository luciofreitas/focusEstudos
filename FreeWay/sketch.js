function setup() {
 somDaTrilha.loop(); 
  createCanvas(500, 400);
  
}

function draw() {
  
  mostraEstrada();
  mostraPersonagem();
  mostraCarro();
  movimentaCarro();
  movimentaPersonagem();
  voltaPosicaoInicialCarro();
  verificaColisao();
  incluiPlacar(); 
  podeSeMoverCima();
  podeSeMoverBaixo();
  podeSeMoverEsquerda();
  podeSeMoverDireita();
  
  //popularTotalJogadas();
  //mostraUltimaPontuacao();
}








