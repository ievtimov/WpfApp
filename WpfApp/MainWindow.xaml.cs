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
using WpfApp.Sample_windows;
using WpfApp.Binding_examples;
using WpfApp.Commands;
using WpfApp.Styles;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Window> Windows
        {
            get
            {
                return new List<Window>()
                {
                    new ResourceSample(),
                    new ExceptionsSample(),
                    new TextBlockSample(),
                    new TextBlockInlineSample(),
                    new LabelControlSample(),
                    new TextBoxSample(),
                    new CheckBoxSample(),
                    new RadioButtonSample(),
                    new PasswordBoxSample(),
                    new ToolTipsSimpleSample(), 
                    new TextFormattingModeSample(), 
                    new CanvasSample(),
                    new WrapPanelSample(),
                    new StackPanelSample(),
                    new DockPanelSample(),
                    new GridSample()
                };
            }
        }

        public List<Window> Bindings
        {
            get
            {
                return new List<Window>()
                {
                    new HelloBoundWorldSample(),
                    new ChangeNotificationSample(),
                    new ConverterSample(),
                    new StringFormatSample()
                };
            }
        }

        public List<Window> Commands
        {
            get
            {
                return new List<Window>()
                {
                    new UsingCommandsSample(),
                    new CommandCanExecuteSample(),
                    new CommandsWithCommandTargetSample(),
                    new CustomCommandSample()
                };
            }
        }

        public List<Window> Styles
        {
            get
            {
                return new List<Window>()
                {
                    new StyleTriggerEnterExitActions() {
                        WindowStartupLocation = WindowStartupLocation.CenterScreen,
                        WindowState = WindowState.Maximized
                    }
                };
            }
        }

        private void cmbSamples_Loaded(object sender, RoutedEventArgs e)
        {
            SetItemSourceToComboBox((ComboBox)sender, Windows);
        }

        private void cmbSamples_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                ((Window)((ComboBox)sender).SelectedItem).ShowDialog();
                SetItemSourceToComboBox((ComboBox)sender, Windows);
            }
        }

        private void SetItemSourceToComboBox(ComboBox conboBox, List<Window> windows)
        {
            conboBox.ItemsSource = windows;
        }

        private void cmbOthers_Loaded(object sender, RoutedEventArgs e)
        {
            SetItemSourceToComboBox((ComboBox)sender, Bindings);
        }

        private void cmbOthers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                ((Window)((ComboBox)sender).SelectedItem).ShowDialog();
                SetItemSourceToComboBox((ComboBox)sender, Bindings);
            }
        }

        private void cmbCommands_Loaded(object sender, RoutedEventArgs e)
        {
            SetItemSourceToComboBox((ComboBox)sender, Commands);
        }

        private void cmbCommands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                ((Window)((ComboBox)sender).SelectedItem).ShowDialog();

                if (System.Windows.Application.Current != null)
                {
                    SetItemSourceToComboBox((ComboBox)sender, Commands);
                }
            }
        }

        private void cmbStyles_Loaded(object sender, RoutedEventArgs e)
        {
            SetItemSourceToComboBox((ComboBox)sender, this.Styles);
        }

        private void cmbStyles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                ((Window)((ComboBox)sender).SelectedItem).ShowDialog();
                SetItemSourceToComboBox((ComboBox)sender, this.Styles);
            }
        }
    }
}
