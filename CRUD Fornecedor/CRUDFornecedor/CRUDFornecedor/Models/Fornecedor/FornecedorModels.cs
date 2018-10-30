using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFornecedor.Models.Fornecedor
{
    public class FornecedorModels : IFornecedorModels
	{
		public FornecedorModels(int cnpj, string razao_social, string nome_fantasia, string endereco, string bairro, string cidade, string estado, string cep)
		{
			Cnpj = cnpj;
			Razao_social = razao_social;
			Nome_fantasia = nome_fantasia;
			Endereco = endereco;
			Bairro = bairro;
			Cidade = cidade;
			Estado = estado;
			Cep = cep;
		}

		[Key]
		public int Cnpj { get; set; }

		[Required]
		[MaxLength(45)]
		public string Razao_social { get; set; }
		public string Nome_fantasia { get; set; }

		[Required]
		[MaxLength(100)]
		public string Endereco { get; set; }

		[Required]
		[MaxLength(30)]
		public string Bairro { get; set; }

		[Required]
		[MaxLength(50)]
		public string Cidade { get; set; }

		[Required]
		[MaxLength(2)]
	 	public string Estado { get; set; }

		[Required]
		[MaxLength(10)]
		public string Cep { get; set; }

		public IEnumerable<FornecedorModels> BuscaFornecedor()
		{
			throw new NotImplementedException();
		}

		public FornecedorModels BuscaFornecedorCnpj(int cnpj)
		{
			throw new NotImplementedException();
		}

		public void CreateFornecedor(FornecedorModels fornecedorModels)
		{
			throw new NotImplementedException();
		}

		public void DeleteFornecedor(int cnpj)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void EditFornecedor(FornecedorModels fornecedorModels)
		{
			throw new NotImplementedException();
		}
	}
}
