function validaPergunta(){
	
	double resultado = 0;
	var resultadoQual;
	
	if(Quiz.pergunta1.value == ""){
		
		alert("Hey, você não respondeu a pergunta 1.");
		return(false);
		
		}
		else if(Quiz.pergunta1.value == 3){
			resultado = resultado + 1;
			resultadoQual += "\nPergunta 1 voce acertou";
		}
		else
		{
			resultadoQual += "\nPergunta 1 voce acertou";
		}

	
}