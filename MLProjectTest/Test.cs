using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;

namespace MLProjectTest
{
    public class Test
    {
        public static class BuildInfo
        {
            public const string Name = "MLProjectTest";
            public const string Description = "ML Test";
            public const string Author = "Python";
            public const string Company = null;
            public const string Version = "1.0.0";
            public const string DownloadLink = null;
        }

        public class TestMod : MelonMod
        {
            public override void OnApplicationStart() // Runs after Game Initialization.
            {
                MelonLogger.Log("OnApplicationStart");
            }

            public override void OnLevelIsLoading() // Runs when a Scene is Loading or when a Loading Screen is Shown. Currently only runs if the Mod is used in BONEWORKS.
            {
                MelonLogger.Log("OnLevelIsLoading");
            }

            public override void OnLevelWasLoaded(int level) // Runs when a Scene has Loaded.
            {
                MelonLogger.Log("OnLevelWasLoaded: " + level.ToString());
            }

            public override void OnLevelWasInitialized(int level) // Runs when a Scene has Initialized.
            {
                MelonLogger.Log("OnLevelWasInitialized: " + level.ToString());
            }

            public override void OnUpdate() // Runs once per frame.
            {
                MelonLogger.Log("OnUpdate");
            }

            public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
            {
                MelonLogger.Log("OnFixedUpdate");
            }

            public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
            {
                MelonLogger.Log("OnLateUpdate");
            }

            public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
            {
                MelonLogger.Log("OnGUI");
            }

            public override void OnApplicationQuit() // Runs when the Game is told to Close.
            {
                MelonLogger.Log("OnApplicationQuit");
            }

            public override void OnModSettingsApplied() // Runs when Mod Preferences get saved to UserData/modprefs.ini.
            {
                MelonLogger.Log("OnModSettingsApplied");
            }

            public override void VRChat_OnUiManagerInit() // Runs upon VRChat's UiManager Initialization. Only runs if the Mod is used in VRChat.
            {
                MelonLogger.Log("VRChat_OnUiManagerInit");
            }
        }
    }
}