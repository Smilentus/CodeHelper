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
using System.Windows.Shapes;

namespace CodeHelper
{
    /// <summary>
    /// Логика взаимодействия для NotesWindow.xaml
    /// </summary>
    public partial class NotesWindow : Window
    {
        public NotesWindow()
        {
            InitializeComponent();
            MainHelper.LoadData();
            ReDrawUI();
        }

        private void ReDrawUI()
        {
            MainPanel.Children.Clear();
            
            for (int i = 0; i < MainHelper.data.Count; i++)
            {
                Button btn = new Button();
                btn.Style = Resources["noteBtn"] as Style;
                btn.Name = "NOTE" + i;
                btn.Content = new TextBlock()
                {
                    Text = MainHelper.data[i].noteName,
                    TextWrapping = TextWrapping.Wrap,
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                };
                btn.Click += noteBtn_Click;

                MainPanel.Children.Add(btn);
            }
        }

        private void noteBtn_Click(object sender, RoutedEventArgs e)
        {
            Button cnv = (Button)sender;
            int index = int.Parse(cnv.Name.Replace("NOTE", ""));
            MainHelper.OpenNote(index);
            MainWindow window = new MainWindow();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            MainHelper.CreateAndOpenNote();
            MainWindow window = new MainWindow();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }

        private void searchBarBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searchBarBox.Text.Length > 0)
            {
                for (int i = 0; i < MainPanel.Children.Count; i++)
                {
                    if (MainHelper.data[i].noteName.ToLower().Contains(searchBarBox.Text.ToLower())
                        || MainHelper.data[i].noteDescr.ToLower().Contains(searchBarBox.Text.ToLower()))
                    {
                        MainPanel.Children[i].Visibility = Visibility.Visible;
                    }
                    else
                    {
                        MainPanel.Children[i].Visibility = Visibility.Collapsed;
                    }
                }
            }
            else
            {
                for (int i = 0; i < MainPanel.Children.Count; i++)
                {
                    MainPanel.Children[i].Visibility = Visibility.Visible;
                }
            }
        }
    }
}
