using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialGuidGenerator.Infra
{
    public class SequentialGuidGeneratorOptions
    {

        public SequentialGuidType? DefaultSequentialGuidType { get; set; }

           public SequentialGuidType GetDefaultSequentialGuidType()
        {
            return DefaultSequentialGuidType ??
                   SequentialGuidType.SequentialAtEnd;
        }
    }
}
