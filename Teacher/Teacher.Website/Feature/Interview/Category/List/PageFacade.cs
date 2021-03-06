﻿using System.Threading.Tasks;
using MediatR;

namespace Teacher.Website.Feature.Interview.Category.List
{
    public class PageFacade : IPageFacade
    {
        private readonly IMediator _mediator;

        public PageFacade(IMediator mediator)
            => _mediator = mediator;

        public async Task<ViewModel> OnGetAsync(Query query)
            => await _mediator.Send(query);
    }
}