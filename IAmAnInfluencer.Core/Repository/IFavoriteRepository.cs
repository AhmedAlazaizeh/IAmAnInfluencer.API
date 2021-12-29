using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IFavoriteRepository
    {
        public bool addFavorite(Favorite favorite);
        public List<Favorite> getAllFavorite();
        public bool deleteFavorite(deleteFavDTO favorite);
        public bool updateFavorite(Favorite favorite);
        public List<Product> favoriteList(int ID);
        public object favCount(int ID);
    }
}
