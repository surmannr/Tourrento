﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.BLL.Mediator
{
    public interface ICommand<TResult> : IRequest<TResult>
    {
    }
}
