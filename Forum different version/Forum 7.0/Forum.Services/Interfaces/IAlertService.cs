using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Interfaces
{
    public interface IAlertService
    {
        IEnumerable<AlertViewModel> GetAllAlerts();
        AlertViewModel GetAlertById(string id);
        void CreateAlert(AlertViewModel alert);
        void DeleteAlert(string id);
    }
}
