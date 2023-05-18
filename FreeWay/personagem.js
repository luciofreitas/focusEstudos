let xPersonagem = 100;
let yPersonagem = 375;
let comprimentoPersonagem = 30;
let alturaPersonagem = 30;
let totalJogadas = 0;
let colisao = false;


function mostraPersonagem(){
  image(imagemPersonagem, xPersonagem, yPersonagem, comprimentoPersonagem, alturaPersonagem);
}

function movimentaPersonagem(){
  if(keyIsDown(UP_ARROW)){
    if(podeSeMoverCima()){
      yPersonagem -= 3;
    }    
  }
  if(keyIsDown(DOWN_ARROW)){
    if(podeSeMoverBaixo()){
      yPersonagem += 3;
    }   
  }
  if(keyIsDown(LEFT_ARROW)){
    if(podeSeMoverEsquerda()){
      xPersonagem -= 3;
    }   
  }
    if(keyIsDown(RIGHT_ARROW)){
      if(podeSeMoverDireita()){
      xPersonagem += 3;
    }   
  }
}

function verificaColisao(){
  //collideRectCircle(x1,y1,width1,height1,cx,cy,diameter);
  for(let i = 0;i < imagemCarros.length; i++){
    colisao = collideRectCircle(xCarros[i],  yCarros[i], comprimentoCarro, alturaCarro, xPersonagem, yPersonagem, comprimentoPersonagem,alturaPersonagem,50);
    if(colisao){
      colidiu();
    }else{
      naoColidiu();
    }
  }
}

function colidiu(){
  somDaColisao.play();
  if(meusPontos > 0){    
    meusPontos  -=1;    
  } 
  inicio();
}

function naoColidiu(){
  if(yPersonagem < 5){
    somDoPonto.play();
     meusPontos +=1;
inicio();
  }  
}

function inicio(){
    yPersonagem = 375;
    xPersonagem = 100;
}

function podeSeMoverBaixo(){
  return yPersonagem < 375;
}

function podeSeMoverCima(){
  return yPersonagem > 5;
}

function podeSeMoverEsquerda(){
  return xPersonagem > 5;
}

function podeSeMoverDireita(){
  return xPersonagem < 470;
}