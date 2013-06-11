using System;
using System.Collections.Generic;

namespace Tree
{
	public class Arvore
	{
		int id;
		Arvore[] filhos = new Arvore[2];

		public Arvore adicionarFilho (Arvore f, int position)
		{
			filhos[position] = f;
			return f;
		}


		public Arvore (int id)
		{
			this.id = id;
		}

		public static void Main (string[] args)
		{
			Arvore a = new Arvore(1);
			for (int i = 0; i < a.filhos.Length; i++) {
				int random = new Random().Next(30);
				a = new Arvore(random);
				a.id = i;
				a.adicionarFilho(a, i);
			}

			Console.WriteLine(a.id);
			Console.WriteLine(a.filhos.Length);
		}

		public int[] caminho_arvore (Arvore a, int n)
		{
			List<int> values = new List<int>();

			foreach (var filho in a.filhos) {
				var val = filho.id;
			}


			return values.ToArray();
		}
	}
}

