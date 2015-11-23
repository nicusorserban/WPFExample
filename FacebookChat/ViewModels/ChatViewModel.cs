using FacebookChat.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FacebookChat.ViewModels
{
    public class ChatViewModel : ViewModelBase
    {
        private ICommand _addTextCommand;
        public ICommand AddTextCommand
        {
            get { return _addTextCommand ?? new RelayCommand(AddText); }
        }

        public string CurrentText { get; set; }
        public FacebookIdentity CurrentIdentity { get; set; }

        public ObservableCollection<ChatMessage> Messages { get; private set; }

        private void AddText()
        {
            var chatMessage = new ChatMessage
            {
                TimeStamp = DateTime.Now,
                From = CurrentIdentity,
                Text = CurrentText
            };
            Messages.Add(chatMessage);
        }

        public ChatViewModel()
        {
            Messages = new ObservableCollection<ChatMessage>();
        }
    }
}
