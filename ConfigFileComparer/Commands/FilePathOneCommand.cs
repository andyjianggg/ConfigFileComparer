using ConfigFileComparer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConfigFileComparer.Commands
{
    internal class FilePathOneCommand : ICommand
    {

        private FilePathViewModel _filePathViewModel;

        public FilePathOneCommand(FilePathViewModel viewModel)
        {
            _filePathViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _filePathViewModel.FileCanSelect;
        }

        public void Execute(object parameter)
        {
            _filePathViewModel.SelectFileOne();
        }
    }
}