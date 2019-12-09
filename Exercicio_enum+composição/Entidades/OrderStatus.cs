using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_enum_composição.Entidades
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3,
    }
}
