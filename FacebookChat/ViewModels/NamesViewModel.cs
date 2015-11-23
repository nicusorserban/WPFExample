using FacebookChat.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;

namespace FacebookChat.ViewModels
{
    public class NamesViewModel : ViewModelBase
    {
        public ObservableCollection<FacebookIdentity> Names { get; private set; }

        public NamesViewModel()
        {
            Names = new ObservableCollection<FacebookIdentity>();


            Names.Add(new FacebookIdentity { Id = Guid.NewGuid(), Name = "User 1", Location = "Europe" });
            Names.Add(new FacebookIdentity { Id = Guid.NewGuid(), Name = "User 2", Location = "Asia" });
            Names.Add(new FacebookIdentity { Id = Guid.NewGuid(), Name = "User 3", Location = "Moon" });

        }
    }
}
