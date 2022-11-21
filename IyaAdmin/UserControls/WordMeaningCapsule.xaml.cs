using System;
using System.Collections;
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

using IyaAdmin.Models;

namespace IyaAdmin.UserControls
{
    /// <summary>
    /// Interaction logic for WordMeaningCapsule.xaml
    /// </summary>
    public partial class WordMeaningCapsule : UserControl
    {
        public WordMeaningCapsule()
        {
            InitializeComponent();

            MeaningModel = new Meaning();

            grammaticalCategories.ItemsSource = Enum.GetValues(typeof(GrammaticalCategories)).Cast<GrammaticalCategories>();
            tags.ItemsSource = Enum.GetValues(typeof(Tags)).Cast<Tags>();
        }

        public Meaning MeaningModel { get; set; }
    }
}
