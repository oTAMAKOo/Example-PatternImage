
using System.Collections.Generic;
using UnityEngine;
using Modules.PatternTexture;

namespace Example
{
    public sealed class PatternAnimation : PatternImageAnimation
    {
        //----- params -----

        private readonly IReadOnlyList<string> PatternNameTable = new string[]
        {
            "portrait_kohaku_01",
            "portrait_kohaku_02",
            "portrait_kohaku_03",
            "portrait_kohaku_04",
            "portrait_kohaku_05",
            "portrait_kohaku_06",
        };

        //----- field -----

        //----- property -----

        //----- method -----

        public override IReadOnlyList<string> GetPatternNames()
        {
            return PatternNameTable;
        }
    }
}