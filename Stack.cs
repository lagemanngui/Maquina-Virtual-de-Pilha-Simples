namespace Maquina_Virtual_de_Pilha___PCompi___T1
{
	
	/// <summary>
	/// Classe de Pilha para controlar o acesso e organização
	/// </summary>
	
	using System;
	using System.Collections.Generic;
	

	public class Stack
	{
		private List<int> _stack = new List<int>{};
		
		public Stack()
		{
			
		}
		
		/*
		 * Adiciona um elemento no topo da pulha
		*/
		public bool push(int valor)
		{
			if(valor >= 0)
			{
				_stack.Add(valor);
				return true;
			}
			
			return false;
				
			
			
		}
		
		/*
		 *Remove o ultimo elemento da pilha e retorna ele
		 */
		public int remove()
		{
			if(_stack.Count > 0)
			{
				int topo = _stack[_stack.Count-1];
				_stack.RemoveAt(_stack.Count-1);
				
				return topo;
			}else
			{
				return -1;
			}
			
		}
		/*
 		* Mostra os valores na pilha
		 * */
		public void mostraValores()
		{
			Console.Write("::");
			if(_stack.Count > 0)
			{
				
				foreach(int valor in _stack)
				{
					
					Console.Write("[" + valor + "]");
				}
				
				Console.Write("*");
				
			}
			else
			{
				Console.WriteLine("PILHA VAZIA");
			}
			
			
			
		}
		
		/**
		 * Mostra o topo da pilha
		 * */
		public string mostraTopo()
		{
			if(_stack.Count > 0)
			{
				int topo = _stack[_stack.Count-1];
				return "::[VALOR NO TOPO DA PILHA]\n::[" + topo + "]";
			}
			
			return "PILHA VAZIA";
			
		}
	}
}
