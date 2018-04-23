using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.RichEdit;

namespace RichEditToolbarCustomCommandWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class CustomRichEditUICommand : ICommand {
        private static readonly CustomRichEditUICommand customCommand = new CustomRichEditUICommand("CustomCommand");
        public static CustomRichEditUICommand CustomCommand { get { return customCommand; } }
        private readonly string commandName;

        public CustomRichEditUICommand() { }

        protected internal CustomRichEditUICommand(string commandName) {
            this.commandName = commandName;
        }

        #region ICommand Members

        public event System.EventHandler CanExecuteChanged { add { } remove { } }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            if (commandName != "CustomCommand")
                throw new System.ApplicationException("Unknown command");

            RichEditControl richEditControl = (RichEditControl)parameter;
            DXMessageBox.Show("Number of words in the document: " + richEditControl.WordsCount.ToString());
        }

        #endregion
    }
}
