using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
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
using UP2_ASS.Models;

namespace UP2_ASS
{
    /// <summary>
    /// Логика взаимодействия для WindowBookAddEdit.xaml
    /// </summary>
    public partial class WindowBookAddEdit : Window
    {
        DBMainContext dbMainContext = new DBMainContext();
        internal bool deletionFlag = false;
        public WindowBookAddEdit()
        {
            InitializeComponent();
        }

        private void buttDone_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void buttDelete_Click(object sender, RoutedEventArgs e)
        {
            deletionFlag = true;

            this.DialogResult = false;
        }

        private void buttQuit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
