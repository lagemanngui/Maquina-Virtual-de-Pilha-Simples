# Maquina-Virtual-de-Pilha-Simples
Uma máquina virtual de pilha simples para cadeira de Compiladores. Universidade Federal de Pelotas - 2016.

			
			############################
			# Maquina Virtual de Pilha #
			# Projeto de Compiladores  #
			# Guilherme Dias Lagemann  #
			############################

------------------------------------------------------------------------------------------------------------------
1. Operações
------------------------------------------------------------------------------------------------------------------
	
	1.1	PUSH <valor>	# Aidciona um inteiro no topo da pilha
	1.2	SUM		# Soma os dois primeiros elementos no topo da pilha
	1.3	MULT		# Multiplica os dois primeiros elementos no topo da pilha
	1.4	DIV		# Divide o topo da pilha pelo consecutivo na pilha
	1.5	SUB		# Subtrai o topo da pilha pelo consecutivo na pilha
	1.6	<valor> 	# números naturais, ou seja, "[valor] >= 0 && [valor] não é ponto flutuante".

------------------------------------------------------------------------------------------------------------------
2. Execução
------------------------------------------------------------------------------------------------------------------

A execução deverá ser feita em ambiente Windows.

Para executar um arquivo, coloque-o na mesma pasta do programa e renomeie para "teste".
A extensão do arquivo dever ".txt" e conter uma instrução por linha e execute "Maquina Virtual de Pilha.exe".

Exemplo:

	PUSH 2
	PUSH 5
	SUM
------------------------------------------------------------------------------------------------------------------
3. Resultado
------------------------------------------------------------------------------------------------------------------

Ao final da execução é mostrado: 
1) o valor no topo da pilha; 
2) Todos os valores que ainda estão na pilha ao final da execução;

------------------------------------------------------------------------------------------------------------------
4. Tratamento de Problemas
------------------------------------------------------------------------------------------------------------------

4.1 Caso alguma operação seja realizada em uma pilha vazia, o valor retornado será -1.
4.2 Caso um número negativo seja informado a execução terminará.

------------------------------------------------------------------------------------------------------------------
5. Compilando
------------------------------------------------------------------------------------------------------------------

[WINDOWS]

- Recomendado: Abrir o projeto no SharpDevelop(http://www.icsharpcode.net/opensource/sd/)

ou

Para compilar o código fonte no Windows, no cmd dentro da pasta do código-fonte:

 csc Program.cs

[LINUX]

a) Instalar o pacote básico MONO-DEVELOP no site http://www.mono-project.com.

b) No terminal(dentro do diretório do código-fonte), executar:

 $ mcs Program.cs

c) Executar o arquivo gerado:

 $ mono Program.exe

------------------------------------------------------------------------------------------------------------------
Guilherme Dias Lagemann
gdlagemann@inf.ufpel.edu.br
