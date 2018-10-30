using System;
using System.Collections.Generic;

namespace CRUDFornecedor.Models.PedidoItem
{
	interface IPedidoItemModels : IDisposable
	{
		void CreatePedidoItem(PedidoItemModels pedidoItemModels);
		void DeletePedidoItem(PedidoItemModels pedidoItemModels);
		void EditPedidoItem(PedidoItemModels pedidoItemModels);
	}
}