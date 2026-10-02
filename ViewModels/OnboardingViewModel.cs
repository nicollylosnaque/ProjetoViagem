using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaOnBoardingPage.ViewModels
{
    public partial class OnboardingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<OnboardingItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;



        public OnboardingViewModel()
        {
            Itens = new List<OnboardingItem>
            {
                new OnboardingItem
                {
                    ImagemUrl = "explore.png",
                    Titulo = "Explore \r\nExotic Destinations ",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide."

                },

                new OnboardingItem
                {
                    ImagemUrl = "discovery.png",
                    Titulo = "Discover \r\nLocal Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers."

                },

                new OnboardingItem
                {
                      ImagemUrl = "train.png",
                    Titulo = "Plan \r\nYour Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests."

                },

                new OnboardingItem
                {
                    ImagemUrl = "vacation.png",
                    Titulo = "Capture and Share Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features."
                },
            };
        }

        [RelayCommand]

        private void Proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }

    }
}
