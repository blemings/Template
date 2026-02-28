using Template.Classes;
using Template.Utilities;
using System.Drawing;
using System.Numerics;
using Template.Classes;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Template
{
    public class Settings
    {
        /*
         * These are the settings for the menu.
         * 
         * To change the colors, you need to modify the ExtGradient variables.
         * Here are some examples on how to use ExtGradient:
         * 
         * Solid Color:
         *  new ExtGradient { colors = ExtGradient.GetSolidGradient(Color.black) }
         *  
         * Simple Gradient:
         *  new ExtGradient { colors = ExtGradient.GetSimpleGradient(Color.black, Color.white) }
         * 
         * Rainbow Color:
         *   new ExtGradient { rainbow = true }
         *   
         * Epileptic Color (random color every frame):
         *   new ExtGradient { epileptic = true }
         *   
         * Self Color:
         *   new ExtGradient { copyRigColor = true }
         *   
         * To change the font, you may use the following code:
         *   Font.CreateDynamicFontFromOSFont("Comic Sans MS", 24)
         */

        public static ExtGradient backgroundColor = new ExtGradient { rainbow = true };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient { colors = ExtGradient.GetSolidGradient(ColorLib.Black) }, // Disabled
            new ExtGradient { rainbow = true } // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };
        public static Font currentFont = Font.CreateDynamicFontFromOSFont("Comic Sans MS", 24) as font;

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool homeButton = true;
        public static bool rightHanded;
        public static bool disableNotifications;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 0.95f, 1.1f); // Depth, width, height
        public static int buttonsPerPage = 6;

        public static float gradientSpeed = 0.3f; // Speed of colors
    }
}
