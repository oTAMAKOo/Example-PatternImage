
using UnityEngine;
using UnityEditor;
using UniRx;
using Extensions;

// Modules.
using Modules.PatternTexture;

namespace Modules
{
    public class EditorMenu
    {
        protected const string MenuRoot = "Extension/";

        // ※ priorityは11以上差分があると区切り線が入る.
        protected const int SeparatorValue = 11;

        //===============================================================
        //  Tools.
        //===============================================================

        #region Windows

        protected const string ToolsMenu = MenuRoot + "Tools/";

        [MenuItem(itemName: ToolsMenu + "Open PatternTexturePacker", priority = 10)]
        public static void OpenPatternTexturePacker()
        {
            PatternTexturePacker.Open();
        }

        #endregion
    }
}
