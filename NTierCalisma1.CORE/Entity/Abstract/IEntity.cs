using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.CORE.Entity.Abstract
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}
