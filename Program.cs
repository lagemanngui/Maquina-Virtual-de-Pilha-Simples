using System;
using System.IO;

namespace Maquina_Virtual_de_Pilha___PCompi___T1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Máquina Virtual de Pilha - PCompi - T1 \nGuilherme Dias Lagemann");
			Console.WriteLine("\n\n");
			
			
			Stack pilha = new Stack();									//Inicia uma nova pilha
			Calculador calc = new Calculador();							//Inicia o controlador de operações
			StreamReader arqR = new StreamReader(@"teste.txt");			//Abre o arquivo
			
			/**
			 *Operações que serão executadas:
			 * 
			 * [0]	Continua a execução
			 * [1]	Adiciona um valor no topo da pilha
			 * [2]	Soma os dois primeiros valores da pilha
			 * [3]	Multiplica os dois primeiros valores da pilha
			 * [4]	Divide os dois primeiros valores da pilha
			 * [5]	Subtrai os dois primeiros valores da pilha
			 * 
			 **/
			do
			{
				
				string[] newLine = arqR.ReadLine().Split(null);			//Lê a linha do arquivo e desconsidera os espaços
				
				/**
				 * Executa a operação reconhecida na linha
				 */
				if(newLine[0] == "PUSH")
				{				
					if(!pilha.push(Int32.Parse(newLine[1])))			//Se a operação for PUSH, adiciona o elemento seguinte no topo da pilha
					{
						Console.WriteLine("::[ERRO] Valor inválido na operação PUSH " + newLine[1]);
						break;
					}
				}
				else if(newLine[0] == "SUM")
				{
					int val1 = pilha.remove();
					int val2 = pilha.remove();
					pilha.push(calc.sum(val1, val2));
					
				}
				else if(newLine[0] == "MULT")
				{
					int val1 = pilha.remove();
					int val2 = pilha.remove();
					pilha.push(calc.mult(val1, val2));
				}
				else if(newLine[0] == "DIV")
				{
					int val1 = pilha.remove();
					int val2 = pilha.remove();
					pilha.push(calc.div(val1, val2));
				}
				else if(newLine[0] == "SUB")
				{
					int val1 = pilha.remove();
					int val2 = pilha.remove();
					pilha.push(calc.sub(val1, val2));
				}
					
			}while(!arqR.EndOfStream);
		
			
			Console.WriteLine("\n\n");
			Console.WriteLine("::[PILHA] ");
			pilha.mostraValores();
			
			Console.WriteLine("\n\n");
			Console.WriteLine(pilha.mostraTopo());
			Console.ReadKey(true);
		}

	}
}