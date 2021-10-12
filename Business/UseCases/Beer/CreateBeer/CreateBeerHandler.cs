using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.UseCases.Beer.CreateBeer
{
    public class CreateBeerHandler : ICommandHanlder<CreateBeerCommand>
    {
        private readonly IApplicationContext context;

        public CreateBeerHandler(IApplicationContext context)
        {
            this.context = context;
        }

        public Task Handle(CreateBeerCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
