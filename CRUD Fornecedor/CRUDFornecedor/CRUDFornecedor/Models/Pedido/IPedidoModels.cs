using System;
using System.Collections.Generic;

namespace CRUDFornecedor.Models.Pedido
{
	interface IPedidoModels : IDisposable
	{
		IEnumerable<PedidoModels> BuscaPedido(int numero_pedido);
		void CreatePedido(PedidoModels pedidoModels);
		void DeletePedido(int numero_pedido);
		void EditPedido(PedidoModels pedidoModels);
	}
}