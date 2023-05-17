//variaveis da bolinha
let xBolinha = 300;
let yBolinha =200;
let diametro = 13;
let raio = diametro/2;

//variaveis do retangulo e ratangulo do oponente
let xRetangulo = 5;
let yRetangulo = 150;
let comprimentoRetangulo = 10;
let alturaRetangulo = 90;

//variaveis do retangulo do oponente
let xRetanguloOponente = 585;
let yRetanguloOponente = 150;
let chanceDeErrar = 0;

let colidiu = false;

//variaveis da velocidade da bolinha
let xVelocidadeBolinha = 6;
let yVelocidadeBolinha = 6;

//variaveis da velocidade do retangulo e retangulo do oponente
let xVelocidadeRetangulo = 5;
let yVelocidadeRetangulo = 5;

//variaveis da velocidade do retangulo do oponente
let xVelocidadeRetanguloOponente = 5;
let yVelocidadeRetanguloOponente = 5;

//placar do jogo
let meusPontos = 0;
let pontosOponente = 0;

//variaveis sons do jogo
let raquetada;
let ponto;
let trilha;

function preload(){
  trilha = loadSound("trilha.mp3");
  ponto = loadSound("ponto.mp3");
  raquetada = loadSound("raquetada.mp3");
}

function setup() {
  createCanvas(600, 400);
  trilha.loop();
}

function draw() {
  campo();
  circuloCentral();
  mostraBolinha();
  movimentaBolinha();
  verificaColisao();
  mostraRetangulo(xRetangulo,yRetangulo);
  mostraRetangulo(xRetanguloOponente,yRetanguloOponente);
  movimentaRetangulo();
  verificaColisaoRetanguloBiblioteca(xRetangulo,yRetangulo);
  movimentaRetanguloOponente();
  verificaColisaoRetanguloBiblioteca(xRetanguloOponente,yRetanguloOponente);
  incluiPlacar();
  marcaPonto();
  bolinhaNaoFicaPresa();
}
function circuloCentral(){
  fill('green');
  circle(300,200,90);
}
function campo(){
  background(color(34,139,34)); 
  rect(300,0,5,400);
  ellipse(300,200,100,100);
  
  
}
function mostraBolinha(){
  fill('white');
  circle(xBolinha, yBolinha, diametro);
  
}
function bolinhaNaoFicaPresa(){
  if(xBolinha - raio < 0){
    xBolinha = 300;
    yBolinha = 200;
  }
  if(xBolinha + raio > 600){
    xBolinha = 300;
    yBolinha = 200;
  }
}

function mostraRetangulo(x,y){
  rect(x, y, comprimentoRetangulo, alturaRetangulo);
}


function movimentaBolinha(){
  xBolinha += xVelocidadeBolinha;
  yBolinha += yVelocidadeBolinha;  
}
function movimentaRetangulo(){
    if(keyIsDown(87)){//87 é o codigo que representa a tecla w
    yRetangulo -= 10;
  }
    if(keyIsDown(83)){//83 é o codigo que representa a tecla s
    yRetangulo += 10;
  } 
}
function movimentaRetanguloOponente(){
  if(keyIsDown(UP_ARROW)){
    yRetanguloOponente -= 10;
  }
    if(keyIsDown(DOWN_ARROW)){
    yRetanguloOponente += 10;
  }
/*  yVelocidadeRetanguloOponente = yBolinha - yRetanguloOponente - comprimentoRetangulo/2-30;
  yRetanguloOponente += yVelocidadeRetanguloOponente;*/
  calcularChanceDeErrar();
}
function calcularChanceDeErrar(){
  if(pontosOponente >= meusPontos){
    chanceDeErrar +=1;
    if(chanceDeErrar >=39){
      chanceDeErrar = 40;
    }
  }else{
    chanceDeErrar -= 1;
    if(chanceDeErrar <= 35){
      chanceDeErrar = 35
    }
  }
}

function verificaColisao(){
  if(xBolinha + raio > width || xBolinha - raio < 0){
     xVelocidadeBolinha *= -1;
     }
  if(yBolinha + raio > height || yBolinha - raio < 0){
    yVelocidadeBolinha *= -1;
  }
}

function verificaColisaoRetanguloBiblioteca(x,y){
  colidiu = collideRectCircle(x, y, comprimentoRetangulo, alturaRetangulo, xBolinha, yBolinha, raio);
  if(colidiu){
    xVelocidadeBolinha *= -1;
    raquetada.play();
  }
}


function tituloJogo(){
  stroke(0);
  fill(0);
  text("PongBall - The Best Pong Game",299,26); 
}
function incluiPlacar(){
  //tituloJogo();
  stroke(255);
  textAlign(CENTER);  
  textSize(16); 
  fill(color(255,140,0));
  rect(130,35,40,20);
  fill(255);  
  text(meusPontos,150,50);
  fill(color(255,140,0));
  rect(430,35,40,20);
  fill(255);
  text(pontosOponente,450,50)  
}
function marcaPonto(){
  if(xBolinha > 590){
    meusPontos += 1;
    ponto.play();
    
  }
    if(xBolinha < 10){
    pontosOponente += 1;
    ponto.play();
  }
}