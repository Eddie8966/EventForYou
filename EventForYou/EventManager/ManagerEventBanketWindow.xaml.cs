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
using System.Windows.Shapes;

namespace EventForYou.Event_Manager
{
    /// <summary>
    /// Логика взаимодействия для ManagerEventBanketWindow.xaml
    /// </summary>
    public partial class ManagerEventBanketWindow : Window
    {
        public ManagerEventBanketWindow()
        {
            InitializeComponent();
        }
        //Данный метод отвечает за переход в обратное окно категорий мероприятий
        private void ManagerCategory(object sender, RoutedEventArgs e)
        {
            ManagerCategoryWindow window = new ManagerCategoryWindow();
            window.Show();
            this.Close();
        }
        //Данный метод отвечает за открытие окна заказов
        private void OrderManager(object sender, RoutedEventArgs e)
        {
            ManagerOrderWindow window = new ManagerOrderWindow();
            window.Show();
            this.Close();
        }
        //Данный метод отвечает за открытие окна свадьбы, где менеджер может провести редактирования
        private void OrderW(object sender, RoutedEventArgs e)
        {
            ManagerOrderWeddingWindow window = new ManagerOrderWeddingWindow();
            window.Show();
            this.Close();
        }
    }
}
