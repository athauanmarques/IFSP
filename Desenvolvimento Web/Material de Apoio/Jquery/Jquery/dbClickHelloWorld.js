 $(document).ready (function ()  
{   alert ("jQuery está trabalhando!");
    $("#clicar1").click(function(){
        $(this).hide();
    });
    $("#clicar2").dblclick(function(){
        $(this).hide();
    });
	 $("#mostrar").click(function(){
        $("#clicar1").show();
		$("#clicar2").show();
		$(p).show();
    });
});
