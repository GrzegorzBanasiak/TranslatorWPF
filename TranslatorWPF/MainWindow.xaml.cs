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

namespace TranslatorWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCheckText_Click(object sender, RoutedEventArgs e)
        {
            String textToDetected = txtbCheckText.Text;

            LanguageDetector lang = new LanguageDetector(textToDetected);
            lang.Detect(); 

            txtbCheckedLanguage.Text = lang.GetFullNameLanguage();
        }

        private void BtnTranslate_Click(object sender, RoutedEventArgs e)
        {
            Translator translator = new Translator();

            //Pobierz wartość właściwości Tag wybranego języka z listy rozwijlnej, Tag zawiera skrót języka (np: en -> English)
            string choosenLanguage = ((ComboBoxItem)this.cboxLanguageList.SelectedItem).Tag.ToString();
            string textToTranslate = txtbTextToTranslate.Text;

            txtbTextTranslated.Text = translator.Translate(textToTranslate, choosenLanguage);
        }
    }
}
