using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SG.Forms.Config
{
    public static class CommonResources
    {
        public static string LogoImagePath
        {
            get
            {
                string imagePath = "";
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        imagePath = "logo.png";
                        break;
                    case Device.iOS:
                        imagePath = "logo.png";
                        break;
                    default:
                        break;
                }
                return imagePath;
            }
        }

        public static string BackgroundImagePath
        {
            get
            {
                string imagePath = "";
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        imagePath = "background.jpg";
                        break;
                    case Device.iOS:
                        imagePath = "background.jpg";
                        break;
                    default:
                        break;
                }
                return imagePath;
            }
        }
    }
}
