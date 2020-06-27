 $(document).ready (function ()  
{  
	// Cria a função sayHello  
	function sayHello()  
	{  
		alert ("Olá jQuery");  
	}  
	$("p").click(function(){
        $(this).hide();
    });
	
	$("p").dblclick(function(){
        $(this).show();
    });
});
