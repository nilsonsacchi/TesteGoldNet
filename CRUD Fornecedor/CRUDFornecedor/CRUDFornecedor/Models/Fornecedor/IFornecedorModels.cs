using System;
using System.Collections.Generic;

namespace CRUDFornecedor.Models.Fornecedor
{
	interface IFornecedorModels : IDisposable
	{
		IEnumerable<FornecedorModels> BuscaFornecedor();
		FornecedorModels BuscaFornecedorCnpj(int cnpj);
		void CreateFornecedor(FornecedorModels fornecedorModels);
		void DeleteFornecedor(int cnpj);
		void EditFornecedor(FornecedorModels fornecedorModels);
	}

}