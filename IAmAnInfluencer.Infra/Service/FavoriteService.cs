using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class FavoriteService: IFavoriteService
    {
        private readonly IFavoriteRepository favoriteRepository;

        public FavoriteService(IFavoriteRepository _favoriteRepository)
        {
            favoriteRepository = _favoriteRepository;
        }

        public bool addFavorite(Favorite favorite)
        {
            return favoriteRepository.addFavorite(favorite);
        }

        public bool deleteFavorite(int ID)
        {
            return favoriteRepository.deleteFavorite(ID);
        }

        public List<Favorite> getAllFavorite()
        {
            return favoriteRepository.getAllFavorite();
        }

        public bool updateFavorite(Favorite favorite)
        {
            return favoriteRepository.updateFavorite(favorite);
        }

        public List<Product> favoriteList()
        {
            return favoriteRepository.favoriteList();
        }
    }
}
