using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Promocao.Enum
{
    public enum EnumPromocao
    {
        [Description("SemPromocao")]
        SemPromocao = 0,
        [Description("Promocao.PromocaoDoisPorUm")]
        DoisPorUm = 1,
        [Description("Promocao.PromocaoTresPorDez")]
        TresPorDez = 2,
        [Description("Promocao.PromocaoDezPorcento")]
        PromocaoDezPorcento = 3
    }

}
