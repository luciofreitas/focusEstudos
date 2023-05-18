let xCarros = [600, 600, 600,600,600,600];
let yCarros = [40,100, 150, 210, 260, 310];
let carroVelocidades = [5,6,4,7,3,8];
let comprimentoCarro = 50;
let alturaCarro = 40;

function mostraCarro(){
  for(let i =0; i< imagemCarros.length; i++){
    image(imagemCarros[i], xCarros[i], yCarros[i], comprimentoCarro, alturaCarro);
  }
}
function movimentaCarro(){
  for(let i=0; i < xCarros.length;i++){
    xCarros[i] -= carroVelocidades[i];
  }
}
function voltaPosicaoInicialCarro(){
  for(let i =0;i < xCarros.length;i++){
    if(passouTodaTela(xCarros[i])){
    xCarros[i] = 600;
    }
  }   
}
function passouTodaTela(xCarros){
  return xCarros < -50;
}
