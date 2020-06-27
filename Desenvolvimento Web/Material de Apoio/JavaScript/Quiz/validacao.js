  
  var erroResposta;
  
  function validaPergunta(){
		if(Quiz.validaPergunta().value == ""){
		
		alert("Responda as questões!");
		return(false);
		
		}
		
		else if(Quiz.pergunta2.value ==""){
			alert("Informe a pergunta");
			return(false);
		}
		else if(Quiz.pergunta3.value ==""){
			alert("Informe a pergunta");
			return(false);
		}
		
		else if(Quiz.pergunta4.value ==""){
			alert("Informe a pergunta");
			return(false);
		}
		else if(Quiz.pergunta5.value ==""){
			alert("Informe a pergunta");
			return(false);
		}
		
		else if(pergunta1.m1[0].check == false && pergunta1.a2[1].check == false && pergunta1.e3[2].check == false)
		{
			alert("INão informou o seu sexo");
			return(false);
		}
			
	
		
	}