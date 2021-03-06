﻿using System;
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

namespace TeamProjectStart
{
    /// <summary>
    /// Логика взаимодействия для AddDeadline.xaml
    /// </summary>
    public partial class AddDeadline : Page
    {
        public AddDeadline()
        {
            InitializeComponent();
        }

        private void buttonGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private async void buttonAddDeadline_Click(object sender, RoutedEventArgs e)
        {
            var apiData = new ApiData();
            var name = textBoxName.Text;
            var finish = calendar.SelectedDate;

            var result = await apiData.AddDeadline(name, finish);

            if (result != null)
            {
                MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                MessageBox.Show("OK");
            }
        }
    }
}
