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
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading;

namespace CodeHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int minFontSize = 8;
        private int maxFontSize = 72;
        private int curFontSize = 0;
        private int fontSizeChange = 4;

        public MainWindow()
        {
            InitializeComponent();
            SetOptions();
            ReDrawUI();
        }

        private void ReDrawUI()
        {
            noteNameInput.Text = MainHelper.data[MainHelper.openedIndex].noteName;
            descrBox.Text = MainHelper.data[MainHelper.openedIndex].noteDescr;
            //FlowDocument doc = new FlowDocument();
            //Paragraph par = new Paragraph();
            //par.Inlines.Add(MainHelper.data[MainHelper.openedIndex].noteBody);
            //doc.Blocks.Add(par);
            //codeBox.Document = doc;
            codeBox = MainHelper.LoadNoteBody(codeBox);
        }

        private void SetOptions()
        {
            var dict = MainHelper.GetOptionsFromActiveNode();
            if (dict.ContainsKey("fontSize"))
                SetRTBFontSize(int.Parse(dict["fontSize"]));
        }

        private void SetRTBFontSize(int value)
        {
            curFontSize = value;
            codeBox.FontSize = value;
            codeBox.Document.FontSize = value;
            foreach (var block in codeBox.Document.Blocks)
                block.FontSize = value;
        }

        private void ReSetRTB()
        {
            codeBox.SelectAll();
            codeBox.Selection.ClearAllProperties();

            SetRTBFontSize(16);
        }

        private void descrBtn_Click(object sender, RoutedEventArgs e)
        {
            if (descrBox.Visibility == Visibility.Hidden)
            {
                descrBtn.Content = "Закрыть";
                descrBtn.Background = new SolidColorBrush(Color.FromArgb(255, 176, 130, 8));
                descrBox.Visibility = Visibility.Visible;
            }
            else
            {
                descrBtn.Content = "Описание";
                descrBtn.Background = new SolidColorBrush(Color.FromArgb(255, 29, 29, 29));
                descrBox.Visibility = Visibility.Hidden;
            }
        }

        private void Debug()
        {
            var blocks = codeBox.Document.Blocks.ToList();
            string blocksFontSize = "";
            foreach (var block in blocks)
                blocksFontSize += block.FontSize + ", ";
            string info = "RTB: " + codeBox.Name +
                "\nDocuments: " + codeBox.Document.ToString() +
                "\nBlocks: " + blocks.Count +
                "\nFontSize RTB: " + codeBox.FontSize +
                "\nFontSize Doc: " + codeBox.Document.FontSize +
                "\nFontSize Blocks: " + blocksFontSize;
            MessageBox.Show(info);
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (codeBox.FontSize > minFontSize)
            {
                SetRTBFontSize(curFontSize - fontSizeChange);
            }

            MainHelper.AddOptionsToActiveNote("fontSize", codeBox.FontSize.ToString());
            Debug();
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (codeBox.FontSize < maxFontSize)
            {
                SetRTBFontSize(curFontSize + fontSizeChange);
            }

            MainHelper.AddOptionsToActiveNote("fontSize", codeBox.FontSize.ToString());
            Debug();
        }

        private string GetTextFromRichBox(RichTextBox rtb)
        {
            return new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text;
        }

        private void copyBtn_Click(object sender, RoutedEventArgs e)
        {
            var copyData = new DataObject();
            var output = GetTextFromRichBox(codeBox);
            copyData.SetData(DataFormats.UnicodeText, output, true);
            var thread = new Thread(() => Clipboard.SetDataObject(copyData, true));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainHelper.data[MainHelper.openedIndex].noteName = noteNameInput.Text;
            MainHelper.data[MainHelper.openedIndex].noteDescr = descrBox.Text;
            MainHelper.SaveData();
            MainHelper.SaveNoteBody(codeBox);
            NotesWindow window = new NotesWindow();
            this.Hide();
            window.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту заметку? [Без возможности восстановления]", "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MainHelper.data.RemoveAt(MainHelper.openedIndex);
                MainHelper.RemoveNoteBody();
                MainHelper.SaveData();
                NotesWindow window = new NotesWindow();
                window.Show();
                this.Close();
            }
        }

        private void resetRtbBtn_Click(object sender, RoutedEventArgs e)
        {
            ReSetRTB();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainHelper.data[MainHelper.openedIndex].noteName = noteNameInput.Text;
            MainHelper.data[MainHelper.openedIndex].noteDescr = descrBox.Text;
            MainHelper.SaveData();
            MainHelper.SaveNoteBody(codeBox);
        }
    }
}
