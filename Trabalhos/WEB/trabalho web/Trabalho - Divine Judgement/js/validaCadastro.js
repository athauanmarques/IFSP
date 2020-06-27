function validaForm(){
	var TextMsg =  Cadastro.fmensagem.value;
		if(Cadastro.fnome.value == ""){
		
		alert("Você precisa informar seu nome!");
		Cadastro.fnome.focus();
		return(false);
		
		}
		else if(Cadastro.femail.value ==""){
			alert("Por gentileza informe o seu e-mail para contato.");
			Cadastro.femail.focus();
			return(false);
		}
			else if(Cadastro.TextMsg == ""){
			alert("Por gentileza informe a sua mensagem.");
			Cadastro.fmensagem.focus();
			return(false);
		}else{
			alert("O seu envio foi concluído com sucesso.");
			return true;
		}
	}