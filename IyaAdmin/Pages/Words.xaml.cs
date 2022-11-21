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

using IyaAdmin.UserControls;

namespace IyaAdmin.Pages
{
    /// <summary>
    /// Interaction logic for Words.xaml
    /// </summary>
    public partial class Words : Page
    {
        public Words()
        {
            InitializeComponent();
        }

        private void AddKanjiReadingCapsule(object sender, RoutedEventArgs args)
        {
            KanjiReadingCapsule capsule = new();
            capsule.HorizontalAlignment = HorizontalAlignment.Left;
            capsule.Margin = new Thickness(0, 6, 0, 0);
            kanjiReadingContainer.Children.Add(capsule);
        }

        private void DeleteKanjiReadingCapsule(object sender, RoutedEventArgs args)
        {
            if (kanjiReadingContainer.Children.Count == 0) { return; }
            kanjiReadingContainer.Children.RemoveAt(kanjiReadingContainer.Children.Count - 1);
        }

        private void AddWordMeaning(object sender, RoutedEventArgs args)
        {
            WordMeaningCapsule capsule = new();
            capsule.HorizontalAlignment = HorizontalAlignment.Left;
            capsule.Margin = new Thickness(0, 6, 0, 0);

            wordMeaningContainer.Children.Add(capsule);
        }

        private void DeleteWordMeaning(object sender, RoutedEventArgs args)
        {
            if (wordMeaningContainer.Children.Count == 0) { return; }
            wordMeaningContainer.Children.RemoveAt(wordMeaningContainer.Children.Count - 1);
        }
    }
}
