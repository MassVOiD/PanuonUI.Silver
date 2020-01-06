﻿using Panuon.UI.Silver;
using System.Windows.Controls;

namespace UIBrowser.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : WindowX
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var tb = sender as TextBox;
            if(tb.Text == "123")
            {
                TextBoxHelper.SetValidationErrorTips(tb, "值不能为123!");
            }
            else
            {
                TextBoxHelper.SetValidationErrorTips(tb, null);
            }
        }

        private void PasswordBox_PasswordChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            var psb = sender as PasswordBox;
            if (psb.Password== "123")
            {
                PasswordBoxHelper.SetValidationErrorTips(psb, "值不能为123!");
            }
            else
            {
                PasswordBoxHelper.SetValidationErrorTips(psb, null);
            }
        }
    }
}