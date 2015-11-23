using FacebookChat.Models;
using GalaSoft.MvvmLight;
using System;

namespace FacebookChat.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public NamesViewModel Names { get; private set; }

        public ChatViewModel Chat { get; private set; }

        public FacebookIdentity CurrentIdentity { get; private set; }

        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            CurrentIdentity = new FacebookIdentity
            {
                Id = Guid.NewGuid(),
                Name = "Myself",
                Location = "Moon"
            };

            Names = new NamesViewModel();
            Chat = new ChatViewModel()
            {
                CurrentIdentity = CurrentIdentity
            };
        }
    }
}