<!-- Autor: Guilherme C. Oliveira 
     Pront: 145206-1
	 Data : 27/03/2016 -->
<!DOCTYPE html>
<html>
	<head>
		<title>Viagem - Dicas</title>
		<meta charset="UTF-8" />
		<link rel="stylesheet" type="text/css" href="estiloDicas.css" />
		<link rel="icon" type="image/png" href="recursos/favicon.png" />
	</head>
	
	<?php
		//entrada
		$data_entrada=$_POST["data_entrada"];
		$data_saida=$_POST["data_saida"];
		$quant_refeicoes=$_POST["quant_refeicoes"];
		$escolha_local=$_POST["escolha_local"];
		$escolha_restaurante=$_POST["escolha_restaurante"];
		$escolha_passeio=$_POST["escolha_passeio"];
		
		//processamento
		$partes_entrada=explode("/",$data_entrada); //data formato: DD/MM/AAAA
		$partes_saida=explode("/",$data_saida); //data formato: DD/MM/AAAA
		
		/* Links de estudo:
			http://www.devmedia.com.br/manipulando-datas-com-php/32966
			http://php.net/manual/en/datetime.diff.php
		*/
		
		//converte pra data no formato americano: YYYY-MM-DD
		$data_entrada_conv=$partes_entrada[2]."-".$partes_entrada[1]."-".$partes_entrada[0];
		$data_saida_conv=$partes_saida[2]."-".$partes_saida[1]."-".$partes_saida[0];
		
		//calcula diferença de dias
		$data1 = new DateTime($data_entrada_conv);
		$data2 = new DateTime($data_saida_conv);
		$total_dias = $data1->diff($data2);
		$total_dias=$total_dias->d; //converte int
		
	
		$valor_total=($escolha_local*$total_dias)+($quant_refeicoes*$escolha_restaurante*$total_dias)+$escolha_passeio;
	?>
	
	<body>
		<!-- Cabeçalho -->
		<header>
			<a href="index.html"><h1 id="titulo">SALVADOR</h1></a>
			<img src="recursos/salvador.jpg" id="cabecalho" />
 		</header>
		
		<!-- Voltar -->
		<div id="voltar">
			<a href="index.html"><img src="recursos/home_icon.jpg" id="home" /> Home</a>
		</div>

		<!-- Dicas -->
		<h1 id="titulo1" class="titulos">Dicas</h1>
		
		<!-- Locais -->
		<table id="tabela_locais">
			<tr><td id="titulo" colspan="4">Onde Ficar</td></tr>
			<tr>
				<td id="titulo_nome" class="titulos">Nome</td>
				<td id="titulo_endereco" class="titulos">Endereço</td>
				<td id="titulo_descricao" class="titulos">Descrição</td>
				<td id="titulo_preco" class="titulos">Preço/Dia</td>
			</tr>
			
			<!-- Local 1 -->
			<tr id="local1">
				<td id="local_nome1" class="local_nomes">Bahia Prime Hostel</td>
				<td id="local_endereco1" class="local_locais">
					Alameda Antunes, 56 , Barra, Salvador, CEP 40140-020
				</td>
				<td id="local_descricao1" class="local_descricoes">
					O Bahia Prime Hostel está localizado a 300 metros da Praia Porto 
					da Barra. O acesso Wi-Fi é gratuito.</td>
				<td id="local_preco1" class="local_precos">R$ 49.00</td>
			</tr>
			
			<!-- Local 2 -->
			<tr id="local2">
				<td id="local_nome2" class="local_nomes">Pousada Colonial Chile</td>
				<td id="local_endereco2" class="local_locais">
					 Rua Chile, 7, Pelourinho, Salvador, CEP 40020-000
				</td>
				<td id="local_descricao2" class="local_descricoes">
					Todos os quartos deste hotel têm ar-condicionado, televisão, telefone e frigobar.
					O café-da-manhã de cortesia. O Wi-Fi é gratuito.
				</td>
				<td id="local_preco2" class="local_precos">R$ 149.00</td>
			</tr>
			
			<!-- Local 3 -->
			<tr id="local3">
				<td id="local_nome3" class="local_nomes">Pousada Solar dos Deuses</td>
				<td id="local_endereco3" class="local_locais">
					 Largo Cruzeiro de São Francisco, 12, Pelourinho, Salvador, CEP 40020-280
				</td>
				<td id="local_descricao3" class="local_descricoes">
					Edifício do século XVII localizado no centro histórico de Salvador. 
					O café-da-manhã é servido em seu quarto. O Wi-Fi é gratuito.
				</td>
				<td id="local_preco3" class="local_precos">R$ 299.00</td>
			</tr>
		</table>
		
		<!-- Comidas -->
		<table id="tabela_comida">
			<tr><td id="titulo" colspan="4">Onde Comer</td></tr>
			<tr>
				<td id="titulo_nome" class="titulos">Nome</td>
				<td id="titulo_endereco" class="titulos">Endereço</td>
				<td id="titulo_descricao" class="titulos">Descrição</td>
				<td id="titulo_preco" class="titulos">Preço/Pessoa</td>
			</tr>
			
			<!-- Comida 1 -->
			<tr id="comida1">
				<td id="comida_nome1" class="comida_nomes">Bar Piauí</td>
				<td id="comida_endereco1" class="comida_locais">
					Rua Piauí, 16, Pituba, Salvador
				</td>
				<td id="comida_descricao1" class="comida_descricoes">
					Vale pedir o caranguejo e o polvo à vinagrete. Beijos no salão são proibidos: com 
					bom humor, o dono diz que casais consomem pouco e ocupam a mesa por muito tempo.
				</td>
				<td id="comida_preco1" class="comida_precos">R$ 25.00</td>
			</tr>
			
			<!-- Comida 2 -->
			<tr id="comida2">
				<td id="comida_nome2" class="comida_nomes">496 Grill e Bar</td>
				<td id="comida_endereco2" class="comida_locais">
					Avenida Lafayete Coutinho (Avenida Contorno), 496, Salvador
				</td>
				<td id="comida_descricao2" class="comida_descricoes">
					O cardápio da casa é especializado em Carnes e Frutos do Mar, mas lista 
					também opções de Saladas, Massas e Risotos, além das Entradas e Petiscos.
				</td>
				<td id="comida_preco2" class="comida_precos"> R$ 76.00</td>
			</tr>
			
			<!-- Comida 3 -->
			<tr id="comida3">
				<td id="comida_nome3" class="comida_nomes">Restaurante Amado</td>
				<td id="comida_endereco3" class="comida_locais">
					Avenida Lafayete Coutinho (Avenida Contorno), 660, Salvador
				</td>
				<td id="comida_descricao3" class="comida_descricoes">
					O menu, focado em pescados, tem base clássica com pitadas regionais e 
					receitas franco-italianas com peixes e frutos do mar, mas o cardápio 
					também inclui cordeiro e carne bovina.
				</td>
				<td id="comida_preco3" class="comida_precos">R$ 100.00</td>
			</tr>
		</table>
				
		<!-- Passeio -->
		<table id="tabela_passeio">
			<tr><td id="titulo" colspan="4">Oque Fazer</td></tr>
			<tr>
				<td id="titulo_nome" class="titulos">Nome</td>
				<td id="titulo_endereco" class="titulos">Endereço</td>
				<td id="titulo_descricao" class="titulos">Descrição</td>
				<td id="titulo_preco" class="titulos">Preço/Pessoa</td>
			</tr>
			
			<!-- passeio 1 -->
			<tr id="passeio1">
				<td id="passeio_nome1" class="passeio_nomes">Apreciar a Igreja e Convento de São Francisco</td>
				<td id="passeio_endereco1" class="passeio_locais">
					Salvador - BA, CEP 40020-280
				</td>
				<td id="passeio_descricao1" class="passeio_descricoes">
					Centenas de quilos de ouro enchem de brilho os altares da igreja mais rica do país. 
					O templo de São Francisco, erguido em 1723, tem ainda balaustradas em 
					jacarandá negro, pinturas ilusionistas e uma bela imagem de São Pedro de Alcântara.
				</td>
				<td id="passeio_preco1" class="passeio_precos">R$ 0.00</td>
			</tr>
			
			<!-- passeio 2 -->
			<tr id="passeio2">
				<td id="passeio_nome2" class="passeio_nomes">Visitar o Elevador Lacerda</td>
				<td id="passeio_endereco2" class="passeio_locais">
					Praça da Sé, s/n - Centro Histórico, Salvador - BA, CEP 40015-170
				</td>
				<td id="passeio_descricao2" class="passeio_descricoes">
					A maneira mais original de circular entre a Cidade Alta e a Cidade Baixa é através do 
					Elevador Lacerda, um dos marcos da capital baiana inaugurado em 1872. Com 72 metros de altura, 
					liga a Praça Tomé de Souza (parte alta) à Praça Cairu, onde fica o Mercado Modelo.
				</td>
				<td id="passeio_preco2" class="passeio_precos">R$ 0.15</td>
			</tr>
			
			<!-- passeio 3 -->
			<tr id="passeio3">
				<td id="passeio_nome3" class="passeio_nomes">Visitar o Mercado Modelo</td>
				<td id="passeio_endereco3" class="passeio_locais">
					Praça Visc. de Cayru, s/n - Cidade Baixa, Salvador - BA, CEP 40015-170
				</td>
				<td id="passeio_descricao3" class="passeio_descricoes">
					tradicional centro de artesanato típico da Bahia. Considerado um dos 
					principais pontos turísticos da capital baiana, o Mercado Modelo reúne 
					o que há de mais expressivo nas tradições locais, desde os trabalhos de 
					arte realizados por artesãos, até a comida que é símbolo do estado.  
				</td>
				<td id="passeio_preco3" class="passeio_precos"> R$ 5.00</td>
			</tr>
		</table>	

		<!-- Simulador -->
		<h1 id="titulo2" class="titulos">Simulador</h1>
		
		<form id="simulador" action="simulacao.php" method="post">
			Informe a Data de Entrada:<input type="text" name="data_entrada" value="<?php echo $data_entrada; ?>" id="data_entrada" class="escolhas" placeholder="Ex: 15/12/16 " autofocus required /> <br/>
			Informe a Data de Saída &nbsp;&nbsp;&nbsp;:<input type="text" name="data_saida" value="<?php echo $data_saida; ?>" id="data_saida" class="escolhas" placeholder="Ex: 01/01/17" required />
			<br/>
			Escolha a quantidade de Refeições diárias:
			<input type="number" name="quant_refeicoes" id="quant_refeicoes" class="escolhas" value="<?php echo $quant_refeicoes; ?>" />
			<br/>
			Escolha o <span>Hotel</span> que deseja hospedar-se:
			<select name="escolha_local" id="escolha_local" class="escolhas" value="<?php echo $escolha_local; ?>">
				<option value="49.00">Bahia Prime Hostel</option>
				<option value="149.00">Pousada Colonial Chile</option>
				<option value="299.00">Pousada Solar dos Deuses</option>
			</select>
			<br/>
			Escolha o <span>Restaurante</span> que irá frequentar:
			<select name="escolha_restaurante"  id="escolha_restaurante" class="escolhas" value="<?php echo $escolha_restaurante; ?>">
				<option value="25.00">Bar Piauí</option>
				<option value="76.00">496 Grill e Bar</option>
				<option value="100.00">Restaurante Amado</option>
			</select>
			<br/>
			Escolha a <span>Atração</span> que lhe interessa:
			<select name="escolha_passeio"  id="escolha_passeio" class="escolhas" value="<?php echo $data_passeio; ?>">
				<option value="0.00">Apreciar a Igreja e Convento de São Francisco</option>
				<option value="0.15">Visitar o Elevador Lacerda</option>
				<option value="5.00">Visitar o Mercado Modelo</option>
			</select>
			<br/>
			<input type="submit" value="Simular" id="botao_simular"/>
			<br/>
			<p id="total"><?php echo "O valor a ser gasto será R$ ".$valor_total; ?></p>
		</form>
	</body>
</html>