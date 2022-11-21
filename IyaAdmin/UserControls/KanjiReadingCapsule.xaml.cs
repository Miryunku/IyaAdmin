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

namespace IyaAdmin.UserControls
{
    /// <summary>
    /// Interaction logic for KanjiReadingCapsule.xaml
    /// </summary>
    public partial class KanjiReadingCapsule : UserControl
    {
        public KanjiReadingCapsule()
        {
            InitializeComponent();
        }

        public string KanjiContent
        {
            get { return kanjiBox.Text; }
            set { kanjiBox.Text = value; }
        }

        public string ReadingContent
        {
            get { return readingBox.Text; }
            set { readingBox.Text = value; }
        }
    }
}
