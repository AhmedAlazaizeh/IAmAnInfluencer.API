using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IIAmAnInfluncerRepository
    {
        public bool addIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer);
        public List<IAmAnInfluncer> getAllIAmAnInfluncer();
        public bool deleteIAmAnInfluncer(int ID);
        public bool updateIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer);
    }
}
