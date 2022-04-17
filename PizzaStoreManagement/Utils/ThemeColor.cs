using System.Collections.Generic;
using System.Drawing;

namespace PizzaStoreManagement.Utils
{
    public class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static class LightTheme
        {
            public const string ProtossPylon = "#00a8ff";
            public const string Periwinkle = "#9c88ff";
            public const string RiseNShine = "#fbc531";
            public const string DownloadProgress = "#4cd137";
            public const string Seabrook = "#487eb0";

            public const string VanadylBlue = "#0097e6";
            public const string MattPurple = "#8c7ae6";
            public const string NanohanachaGold = "#e1b12c";
            public const string SkirretGreen = "#44bd32";
            public const string Naval = "#40739e";

            public const string NasturcianFlower = "#e84118";
            public const string LynxWhile = "#f5f6fa";
            public const string BlueberrySoda = "#7f8fa6";
            public const string MazarineBlue = "#273c75";
            public const string BlueNights = "#353b48";

            public const string HarleyDavidsonOrange = "#c23616";
            public const string HintOfPensive = "#dcdde1";
            public const string ChainGangGrey = "#718093";
            public const string PicoVoid = "#192a56";
            public const string Electromagnetic = "#2f3640";

            public static List<string> Colors = new List<string>()
            {
                ProtossPylon,
                Periwinkle,
                RiseNShine,
                DownloadProgress,
                Seabrook,

                VanadylBlue,
                MattPurple,
                NanohanachaGold,
                SkirretGreen,
                Naval,

                NasturcianFlower,
                LynxWhile,
                BlueberrySoda,
                MazarineBlue,
                BlueNights,

                HarleyDavidsonOrange,
                HintOfPensive,
                ChainGangGrey,
                PicoVoid,
                Electromagnetic,
            };
        }

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
