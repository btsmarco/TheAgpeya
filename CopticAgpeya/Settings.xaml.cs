﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Coptic_Agpeya
{
    public partial class PhonePage1 : PhoneApplicationPage
    {


        private Color lightThemeBackground = Color.FromArgb(255, 255, 255, 255);
        private Color darkThemeBackground = Color.FromArgb(255, 0, 0, 0);


        public PhonePage1()
        {
            InitializeComponent();

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SolidColorBrush backgroundBrush = Application.Current.Resources["PhoneBackgroundBrush"] as SolidColorBrush;

            if (backgroundBrush.Color == lightThemeBackground)
            {
                VisualStateManager.GoToState(this, "Light", false);
                ThemeManager.ToDarkTheme();
            }
            else
            {
                VisualStateManager.GoToState(this, "Dark", false);
                ThemeManager.ToLightTheme();
            }
        }

    }
}

