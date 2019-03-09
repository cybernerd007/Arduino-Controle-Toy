  // Carrega a biblioteca
  #include <IRremote.h>// incluindo a biblioteca do infravermelho    
  #include <EEPROM.h>

  int valor;
  const int RECEBE_PINO = 11; // pino 11 no arduino   
  boolean botao = 8; 
  IRrecv ir_recebe(RECEBE_PINO); // declarando a variável do sensor    
  decode_results codigo_recebido; // resultado 
     
  void setup()    
  {    
    Serial.begin(9600); //mostra o resultado no computador    
    ir_recebe.enableIRIn(); // inicia a recepção  
    pinMode ( botao , INPUT_PULLUP);    
  }    
  void loop() {    

    if (ir_recebe.decode(&codigo_recebido)) {//verifica se um codigo foi recebido       

		if ( digitalRead (botao) == 1 ){     // se a entrada botão for igual a 1
    
		}
   
		if (codigo_recebido.value == 0x80722458){//  cima
			Serial.print("a");   
		}    
		//desliga led verde    
		if (codigo_recebido.value == 0x8072A45B){//    ->   
			Serial.print("b"); 
		}    
		//liga led amarelo    
		if (codigo_recebido.value == 0x80722459){// baixo    
			Serial.print("c");  
		}    
		//desliga led amarelo    
		if (codigo_recebido.value == 0x8072A45A){//     <-
			Serial.print("d");       
		}      
		if (codigo_recebido.value == 0x8072245C){//     ok
			Serial.print("e");       
		}   
	ir_recebe.resume(); // recebe o próximo código       
	}    
  }