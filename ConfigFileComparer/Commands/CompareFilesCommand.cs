using ConfigFileComparer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConfigFileComparer.Commands
{
    internal class CompareFilesCommand : ICommand
    {
        private FilePathViewModel _filePathViewModel;

        public CompareFilesCommand(FilePathViewModel viewModel)
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
            return _filePathViewModel.FileCanCompare;
        }

        public void Execute(object parameter)
        {
            _filePathViewModel.CompareFiles();
        }
    }
}