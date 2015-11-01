namespace ArtistsSystem.Api.Controllers
{
    using System.Web.Http;

    using ArtistsSystem.Models;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Models.Albums;
    using Services.Data.Contracts;

    public class AlbumsController : ApiController
    {
        private IAlbumsService albums;

        public AlbumsController(IAlbumsService albums)
        {
            this.albums = albums;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.albums.All().ProjectTo<AlbumResponseModel>());
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok(this.albums.GetById(id).ProjectTo<AlbumResponseModel>());
        }

        public IHttpActionResult Post(AlbumRequestModel requestAlbum)
        {
            var album = Mapper.Map<Album>(requestAlbum);

            album = this.albums.Add(album);

            return this.Created("/", Mapper.Map<AlbumResponseModel>(album));
        }

        public IHttpActionResult Put(int id, AlbumRequestModel requestAlbum)
        {
            var album = Mapper.Map<Album>(requestAlbum);

            album = this.albums.Update(id, album);

            return this.Ok(Mapper.Map<AlbumResponseModel>(album));
        }

        public IHttpActionResult Delete(int id)
        {
            this.albums.Delete(id);

            return this.Ok();
        }
    }
}