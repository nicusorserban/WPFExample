using FacebookChat.Models;
using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;

namespace FacebookChat.ViewModels
{
    public class NamesViewModel : ViewModelBase
    {
        public ObservableCollection<FacebookIdentity> Names { get; private set; }

        public NamesViewModel()
        {
            Names = new ObservableCollection<FacebookIdentity>
            {
                new FacebookIdentity { Id = Guid.NewGuid(), Name = "User 1", Location = "Europe" },
                new FacebookIdentity { Id = Guid.NewGuid(), Name = "User 2", Location = "Asia" },
                new FacebookIdentity { Id = Guid.NewGuid(), Name = "User 3", Location = "Moon" },
            };
        }
    }
}
