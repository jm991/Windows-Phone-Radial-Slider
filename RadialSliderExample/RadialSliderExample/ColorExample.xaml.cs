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

namespace RadialSliderExample
{
	public partial class ColorExample : PhoneApplicationPage
	{
		public ColorExample()
		{
			InitializeComponent();
		}

		private byte r;
		private byte g;
		private byte b;

		private void ColorSlider_SliderValueChanged(object sender, SubsonicDesign.SliderValueChangedEventArgs e)
		{
			UpdateColor();
		}

		private void UpdateColor()
		{
			try
			{
				r = Convert.ToByte(redSlider.CurrentValue);
				g = Convert.ToByte(greenSlider.CurrentValue);
				b = Convert.ToByte(blueSlider.CurrentValue);

				LayoutRoot.Background = new SolidColorBrush(Color.FromArgb(255, r, g, b));
			}

			catch
			{
			}
		}
	}
}