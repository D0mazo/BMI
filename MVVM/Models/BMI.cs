using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BMI
    {
        private float result;

        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result
        {
            get
            {
                return ((Weight / Height) / Height) * 10000;
            }
        }
        public string ResultText
        {
            get
            {
                string template = "BMI: #";
                if (Result <= 16)
                {
                    return template.Replace("#", " Visiškas Lieknumas");
                }
                else if (Result > 16 && Result <= 17)
                {
                    return template.Replace("#", "Lieknumas");
                }
                else if (Result > 17 && Result <= 18.5)
                {
                    return template.Replace("#", "Normalus Lieknumas");
                }
                else if (Result > 18.5 && Result <= 25)
                {
                    return template.Replace("#", "Normalus");
                }
                else if (Result > 25 && Result <= 30)
                {
                    return template.Replace("#", "Viršsvoris");
                }
                else if (Result > 30 && Result <= 35)
                {
                    return template.Replace("#", "Panda");
                }
                else if (Result > 35 && Result <= 40)
                {
                    return template.Replace("#", "Gorila");
                }
                else
                {
                    return template.Replace("#", "Banginis");
                }

            }
        }
    }
}
