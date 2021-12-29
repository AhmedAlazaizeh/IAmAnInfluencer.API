using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteService favoriteService;
        public FavoriteController(IFavoriteService _favoriteService)
        {
            favoriteService = _favoriteService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addFavorite(Favorite favorite)
        {
            return favoriteService.addFavorite(favorite);
        }

        [HttpPost]
        [Route("Delete")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteFavorite(deleteFavDTO favorite)
        {
            return favoriteService.deleteFavorite(favorite);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(List<Favorite>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Favorite> getAllFavorite()
        {
            return favoriteService.getAllFavorite();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateFavorite(Favorite favorite)
        {
            return favoriteService.updateFavorite(favorite);
        }

        [HttpGet]
        [Route("FavList/{ID}")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> favoriteList(int ID)
        {
            return favoriteService.favoriteList(ID);
        }

        [HttpGet]
        [Route("FavCount/{ID}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object favCount(int ID)
        {
            return favoriteService.favCount(ID);
        }
    }
}
