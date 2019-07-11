using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alura.Filmes.App.Negocio
{
	[Table("actor")] /// notação table -> usada para o entity fazer o mapeamento do banco usando o metodo ator sem que ele tenha que ter o mesmo nome da tabela 
	public class Ator
	{
		[Column("actor_id")] // notação column - associando o nome das colunas da tabela com as variaveis criadas no metodo
		public int Id { get; set; }
		[Column("first_name", TypeName = "varchar(45)")]
		public string PrimeiroNome { get; set; }
		[Column("last_name", TypeName = "varchar(45)")]
		public string UltimoNome { get; set; }

		public override string ToString()
		{
			return $"Ator({Id}): {PrimeiroNome} {UltimoNome}";
		}
	}
}
