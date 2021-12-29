using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
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

        public bool deleteFavorite(deleteFavDTO favorite)
        {
            return favoriteRepository.deleteFavorite(favorite);
        }

        public List<Favorite> getAllFavorite()
        {
            return favoriteRepository.getAllFavorite();
        }

        public bool updateFavorite(Favorite favorite)
        {
            return favoriteRepository.updateFavorite(favorite);
        }

        public List<Product> favoriteList(int ID)
        {
            return favoriteRepository.favoriteList(ID);
        }

        public object favCount(int ID)
        {
            return favoriteRepository.favCount(ID);
        }
    }
}
