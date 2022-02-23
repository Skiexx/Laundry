using System;
using System.Collections.Generic;
using System.Text;

namespace Postirushki.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string TotalWashes => "Количество стирок\n во всех филиалах";
        public string TotalCostCash => "Общая стоимость\n за нал расчет";
        public string TotalCostBankTransfer => "Общая стоимость\n за безнал расчет";
    }
}