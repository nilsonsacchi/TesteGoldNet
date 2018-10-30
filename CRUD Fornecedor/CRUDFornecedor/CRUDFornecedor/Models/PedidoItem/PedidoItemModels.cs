using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFornecedor.Models.PedidoItem
{
    public class PedidoItemModels : IPedidoItemModels
	{
		public PedidoItemModels(int numero_pedido, int numero_item, double quantidade, double valor)
		{
			Numero_pedido = numero_pedido;
			Numero_item = numero_item;
			Quantidade = quantidade;
			Valor = valor;
		}

		[Key]
		public int Numero_pedido { get; set; }

		[Required]
		public int Numero_item { get; set; }
		public double Quantidade { get; set; }
		public double Valor { get; set; }

		public void CreatePedidoItem(PedidoItemModels pedidoItemModels)
		{
			throw new NotImplementedException();
		}

		public void DeletePedidoItem(PedidoItemModels pedidoItemModels)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void EditPedidoItem(PedidoItemModels pedidoItemModels)
		{
			throw new NotImplementedException();
		}
	}
}
