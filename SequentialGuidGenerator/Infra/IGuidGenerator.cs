using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialGuidGenerator.Infra
{
    public interface IGuidGenerator
    {
      
        Guid Create();
    }
}
