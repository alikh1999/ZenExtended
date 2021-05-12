#if OPEN_JUICE && UNITASK
using System;
using UnityEngine.UI;
using YoYoStudio.OpenJuice;

namespace ZenExtended
{
    [Serializable]
    internal class AnimatedPanelComponents
    {
#if ODIN_INSPECTOR
        [BoxGroup("Animated Panel")]
#endif
        public Button CloseButton;

#if ODIN_INSPECTOR
        [BoxGroup("Animated Panel")]
#endif
        public BaseTransition PrimaryTransition;

#if ODIN_INSPECTOR
        [BoxGroup("Animated Panel")]
#endif
        public BaseTransition[] SecondaryTransitions;
    }
}
#endif