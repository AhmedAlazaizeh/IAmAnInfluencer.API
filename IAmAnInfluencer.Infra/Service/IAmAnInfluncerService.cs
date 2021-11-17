using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using IAmAnInfluencer.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class IAmAnInfluncerService: IIAmAnInfluncerService
    {
        private readonly IIAmAnInfluncerRepository iAmAnInfluncerRepository;

        public IAmAnInfluncerService(IIAmAnInfluncerRepository _iAmAnInfluncerRepository)
        {
            iAmAnInfluncerRepository = _iAmAnInfluncerRepository;
        }

        public bool addIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer)
        {
            return iAmAnInfluncerRepository.addIAmAnInfluncer(iamAnInfluncer);
        }

        public bool deleteIAmAnInfluncer(int ID)
        {
            return iAmAnInfluncerRepository.deleteIAmAnInfluncer(ID);
        }

        public List<IAmAnInfluncer> getAllIAmAnInfluncer()
        {
            return iAmAnInfluncerRepository.getAllIAmAnInfluncer();
        }

        public bool updateIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer)
        {
            return iAmAnInfluncerRepository.updateIAmAnInfluncer(iamAnInfluncer);
        }
    }
}
