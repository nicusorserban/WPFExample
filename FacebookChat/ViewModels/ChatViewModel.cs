using FacebookChat.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FacebookChat.ViewModels
{
    public class ChatViewModel : ViewModelBase
    {
        private ICommand _addTextCommand;
        public ICommand AddTextCommand
        {
            get { return _addTextCommand ?? new RelayCommand<string>(AddText); }
        }

        public FacebookIdentity CurrentIdentity { get; set; }

        public ObservableCollection<ChatMessage> Messages { get; private set; }

        private void AddText(string parameter)
        {
            var chatMessage = new ChatMessage
            {
                TimeStamp = DateTime.Now,
                From = CurrentIdentity,
                Text = parameter
            };
            Messages.Add(chatMessage);
        }

        public ChatViewModel()
        {
            Messages = new ObservableCollection<ChatMessage>();
        }
    }
}
