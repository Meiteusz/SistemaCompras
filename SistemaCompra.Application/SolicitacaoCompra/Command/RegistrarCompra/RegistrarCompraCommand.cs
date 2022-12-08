using MediatR;
using System.Collections.Generic;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
    public class RegistrarCompraCommand : IRequest<bool>
    {
        public string UsuarioSolicitante { get; set; }
        public string NomeFornecedor { get; set; }
        public string Data { get; set; }
        public string CondicaoPagamento { get; set; }
        public List<int> Itens { get; set; }
    }
}
