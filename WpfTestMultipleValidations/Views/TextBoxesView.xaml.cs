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
using WpfTestMultipleValidations.ViewModels;

namespace WpfTestMultipleValidations.Views
{
    /// <summary>
    /// Interaction logic for SampleView.xaml
    /// </summary>
    public partial class TextBoxesView : UserControl
    {
        private string _text;
        public string LoadText
        {
            get => _text;
            set
            {
                LoadTextBlock.Text = value;
                _text = value;
            }
        }

        public TextBoxesView()
        {
            InitializeComponent();
            DataContext = new TextBoxesViewModel();
        }

        public TextBoxesView(string loadText)
        {
            InitializeComponent();
            DataContext = new TextBoxesViewModel();
            LoadText = loadText;
        }
    }
}
