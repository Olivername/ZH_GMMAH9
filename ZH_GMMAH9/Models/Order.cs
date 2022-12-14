using System;
using System.Collections.Generic;

namespace ZH_GMMAH9.Models;

public partial class Order
{
    public int OrderSk { get; set; }

    public int? StudentFk { get; set; }

    public int? TextbookFk { get; set; }

    public virtual Student? StudentFkNavigation { get; set; }

    public virtual Textbook? TextbookFkNavigation { get; set; }
}
