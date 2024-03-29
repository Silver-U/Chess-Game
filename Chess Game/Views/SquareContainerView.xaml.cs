﻿using Chess_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess_Game.Views
{
    /// <summary>
    /// Interaction logic for SquareContainerView.xaml
    /// </summary>
    public partial class SquareContainerView : UserControl
    {




        public SquareContainer container
        {
            get { return (SquareContainer)GetValue(containerProperty); }
            set { SetValue(containerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for container.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty containerProperty =
            DependencyProperty.Register("container", typeof(SquareContainer), typeof(SquareContainerView), new PropertyMetadata(null));




        public SquareContainerView()
        {
            InitializeComponent();
        }
    }
}
