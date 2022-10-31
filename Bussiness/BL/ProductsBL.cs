using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Business.BL
{
    class ProductsBL
    {
        private readonly IDutchRepository _dutchRepository;

        public ProductsBL(IDutchRepository dutchRepository)
        {
            _dutchRepository = dutchRepository;
        }
    }
}
