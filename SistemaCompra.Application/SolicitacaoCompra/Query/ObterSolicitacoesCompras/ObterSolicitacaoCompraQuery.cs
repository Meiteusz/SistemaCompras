using MediatR;
using System;

namespace SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacoesCompras
{
    public class ObterSolicitacaoCompraQuery : IRequest<ObterSolicitacaoCompraViewModel>
    {
        public Guid Id { get; set; }
    }
}
