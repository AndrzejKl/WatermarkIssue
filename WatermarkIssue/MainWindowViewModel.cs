using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace WatermarkIssue
{
    public class MainWindowViewModel : ObservableObject
    {
        private string? myProperty = "Display watermark";
        private string? myProperty1 = "fixed watermark";

        [Display(Name = "Watermark")]
        public string? MyProperty { get => myProperty; set => SetProperty(ref myProperty, value); }

        public string? MyProperty1 { get => myProperty1; set => SetProperty(ref myProperty1, value); }
    }
}