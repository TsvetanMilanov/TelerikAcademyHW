namespace ArtistsSystem.Api.Controllers
{
    using System.Web.Http;

    using ArtistsSystem.Models;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Models.Artists;
    using Services.Data.Contracts;

    public class ArtistsController : ApiController
    {
        private IArtistsService artists;

        public ArtistsController(IArtistsService artists)
        {
            this.artists = artists;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(this.artists.All().ProjectTo<ArtistResponseModel>());
        }

        public IHttpActionResult Get(int id)
        {
            return this.Ok(this.artists.GetById(id).ProjectTo<ArtistResponseModel>());
        }

        public IHttpActionResult Post(ArtistRequestModel requestArtist)
        {
            var artist = Mapper.Map<Artist>(requestArtist);

            artist = this.artists.Add(artist);

            return this.Created("/", Mapper.Map<ArtistResponseModel>(artist));
        }

        public IHttpActionResult Put(int id, ArtistRequestModel requestArtist)
        {
            var artist = Mapper.Map<Artist>(requestArtist);

            artist = this.artists.Update(id, artist);

            return this.Ok(Mapper.Map<ArtistResponseModel>(artist));
        }

        public IHttpActionResult Delete(int id)
        {
            this.artists.Delete(id);

            return this.Ok();
        }
    }
}