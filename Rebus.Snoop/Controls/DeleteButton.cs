﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Rebus.Snoop.Controls
{
    public class DeleteButton : Button
    {
        readonly Image image;

        public DeleteButton()
        {
            image = new Image { Source = new BitmapImage(new Uri("pack://application:,,,/Rebus.Snoop;component/Images/cross.png")) };
            image.Height = image.Width = 16;
            Content = image;

            Background = null;
            BorderThickness = new Thickness(0);
            Margin = new Thickness(0);
            Padding = new Thickness(0);
        }

        public ImageSource Source
        {
            get { return image.Source; }
            set { image.Source = value; }
        }
    }
}