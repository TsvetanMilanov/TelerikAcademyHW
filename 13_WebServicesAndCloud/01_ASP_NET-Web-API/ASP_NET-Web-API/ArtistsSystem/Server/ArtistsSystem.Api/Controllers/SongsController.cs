namespace ArtistsSystem.Api.Controllers
{
    using System.Web.Http;

    using ArtistsSystem.Models;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Models.Songs;
    using Services.Data.Contracts;

    public class SongsController : ApiController
    {
        private ISongsService songs;

        public SongsController(ISongsService songs)
        {
            this.songs = songs;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.songs.All().ProjectTo<SongResponseModel>());
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok(this.songs.GetById(id).ProjectTo<SongResponseModel>());
        }

        public IHttpActionResult Post(SongRequestModel requestSong)
        {
            var song = Mapper.Map<Song>(requestSong);

            song = this.songs.Add(song);

            return this.Created("/", Mapper.Map<SongResponseModel>(song));
        }

        public IHttpActionResult Put(int id, SongRequestModel requestSong)
        {
            var song = Mapper.Map<Song>(requestSong);
            
            song = this.songs.Update(id, song);

            return this.Ok(Mapper.Map<SongResponseModel>(song));
        }

        public IHttpActionResult Delete(int id)
        {
            this.songs.Delete(id);

            return this.Ok();
        }
    }
}