using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDFornecedor.Models.Pedido
{
    public class PedidoModels : IPedidoModels
	{
		public PedidoModels(int numero_pedido, int cnpj, DateTime data, double valor_total)
		{
			Numero_pedido = numero_pedido;
			Cnpj = cnpj;
			Data = data;
			Valor_total = valor_total;
		}

		[Key]
		public int Numero_pedido { get; set; }
		public int Cnpj { get; set; }

		[Required]
		public DateTime Data { get; set; }
		public double Valor_total { get; set; }

		public IEnumerable<PedidoModels> BuscaPedido(int numero_pedido)
		{
			throw new NotImplementedException();
		}

		public void CreatePedido(PedidoModels pedidoModels)
		{
			throw new NotImplementedException();
		}

		public void DeletePedido(int numero_pedido)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void EditPedido(PedidoModels pedidoModels)
		{
			throw new NotImplementedException();
		}
	}
}
