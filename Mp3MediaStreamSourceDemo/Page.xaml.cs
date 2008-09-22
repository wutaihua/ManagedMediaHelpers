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
using Media;

namespace Mp3MediaStreamSourceDemo
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }

        private void OpenMedia(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            Mp3MediaStreamSource mp3Source = new Mp3MediaStreamSource(ofd.SelectedFile.OpenRead());
            me.SetSource(mp3Source);
        }
    }
}