using System;
using System.Windows;
using WpfApp2.Core;

namespace WpfApp2.ViewModels
{
    public class MainViewModel
    {

        public string Name { get; set; }

        public DelegateCommand BtnCommand { get; set; }

        public MainViewModel()
        {
            BtnCommand = new DelegateCommand(BtnComd, (object obj) => true);
            Name = "Hello";
        }

        private void BtnComd(object obj)
        {
            MessageBox.Show("Hello");
        }
    }
}
