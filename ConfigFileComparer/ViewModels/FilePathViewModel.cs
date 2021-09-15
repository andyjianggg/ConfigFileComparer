using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ConfigFileComparer.Models;
using Microsoft.Win32;
using ConfigFileComparer.Commands;
using System.Xml;

namespace ConfigFileComparer.ViewModels
{
    class FilePathViewModel
    {

        public FilePathViewModel()
        {
            SelectFileOneCommand = new FilePathOneCommand(this);
            SelectFileTwoCommand = new FilePathTwoCommand(this);
            CompareFilesCommand = new CompareFilesCommand(this);
        }

        public bool FileCanCompare 
        { 
            get
            {
                return true;
            }
        }

        public bool FileCanSelect
        {
            get
            {
                return true;
            }
        }

        private FilePath _filePathOne = new FilePath("");
        public FilePath FilePathOne { 
            get
            {
                return _filePathOne;
            }
            set
            {
                _filePathOne = value;
            }
        }

        private FilePath _filePathTwo = new FilePath("");
        public FilePath FilePathTwo { 
            get
            {
                return _filePathTwo;
            }
            set
            {
                _filePathTwo = value;
            }
                
        }

        public void CompareFiles()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FilePathOne.FileName);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
            }
        }

        public void SelectFileOne()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePathOne.FileName = openFileDialog.FileName;
            }
        }

        public void SelectFileTwo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePathTwo.FileName = openFileDialog.FileName;
            }
        }

        public ICommand SelectFileOneCommand
        {
            get;
            private set;
        }

        public ICommand SelectFileTwoCommand
        {
            get;
            private set;
        }

        public ICommand CompareFilesCommand
        {
            get;
            private set;
        }
    }
}
