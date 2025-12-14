using UnityEngine;
using UnityEditor.Toolbars;

namespace ActionCode.TimeScaleToolbar.Editor
{
    /// <summary>
    /// Instantiates a Time Scale slider in the Main Toolbar, allowing to adjust the game's time scale during Play mode.
    /// </summary>
    public static class MainToolbarTimeScaleSlider
    {
        public const float min = 0f;
        public const float max = 4f;

        [MainToolbarElement("Action Code/Time Scale", defaultDockPosition = MainToolbarDockPosition.Left)]
        public static MainToolbarElement InstantiateToolbar()
        {
            var timeScale = Time.timeScale;
            var content = new MainToolbarContent("Time Scale", "Set the Game Time Scale");
            return new MainToolbarSlider(
                content,
                timeScale,
                min,
                max,
                HandleValueChanged
            );
        }

        private static void HandleValueChanged(float value)
        {
            if (Application.isPlaying) Time.timeScale = value;
        }
    }
}