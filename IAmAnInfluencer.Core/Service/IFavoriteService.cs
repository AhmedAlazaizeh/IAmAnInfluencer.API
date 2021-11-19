using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IFavoriteService
    {
        public bool addFavorite(Favorite favorite);
        public List<Favorite> getAllFavorite();
        public bool deleteFavorite(int ID);
        public bool updateFavorite(Favorite favorite);
        public List<Product> favoriteList();
    }
}
