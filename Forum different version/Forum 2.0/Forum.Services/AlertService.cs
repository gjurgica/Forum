using AutoMapper;
using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Forum.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services
{
    public class AlertService : IAlertService
    {
        private readonly IRepository<Alert> _alertRepository;
        private readonly IMapper _mapper;

        public AlertService(IRepository<Alert> alertRepository, IMapper mapper)
        {
            _alertRepository = alertRepository;
            _mapper = mapper;
        }

        public void CreateAlert(AlertViewModel alert)
        {
            _alertRepository.Insert(_mapper.Map<Alert>(alert));
        }

        public void DeleteAlert(string id)
        {
            Alert alert = _alertRepository.GetById(id);
            if (alert == null)
                throw new Exception("Alert does not exist");

            _alertRepository.Delete(id);
        }

        public AlertViewModel GetAlertById(string id)
        {
            Alert alert = _alertRepository.GetById(id);
            if (alert == null)
                throw new Exception("Alert does not exist");

            return _mapper.Map<AlertViewModel>(alert);
        }

        public IEnumerable<AlertViewModel> GetAllAlerts()
        {
            return _mapper.Map<IEnumerable<AlertViewModel>>(_alertRepository.GetAll());
        }
    }
}
