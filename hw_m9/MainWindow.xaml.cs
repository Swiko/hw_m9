using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
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

namespace hw_m9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sentence = TextBoxTask.Text;
            FirstTaskResult.Items.Clear();
            FirstTask(sentence);
            SecondTask(sentence);
        }
        
        private void FirstTask(string StringFromView)
        {
            
            string[] splittedSenteceTask1 = StringFromView.Split(' ');

            foreach (string spl in splittedSenteceTask1)
            {
                FirstTaskResult.Items.Add(spl);
            }
        }

        private void SecondTask(string StringFromView)
        {
            string[] StringFromViewArray = StringFromView.Split(' ');
            Array.Reverse(StringFromViewArray,0, StringFromViewArray.Length);
            string StringToView = String.Join(" ", StringFromViewArray);
            SecondTaskResult.Content = StringToView;
        }
    }
}
