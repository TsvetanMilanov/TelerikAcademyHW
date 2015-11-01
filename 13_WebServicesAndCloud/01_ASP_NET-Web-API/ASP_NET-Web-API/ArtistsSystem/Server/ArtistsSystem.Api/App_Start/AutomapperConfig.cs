namespace ArtistsSystem.Api.App_Start
{
    using System.Linq;

    using ArtistsSystem.Models;
    using AutoMapper;
    using Models.Albums;
    using Models.Artists;
    using Models.Songs;

    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.CreateMap<Song, SongResponseModel>()
                .ForMember(s => s.Genre, opts => opts.MapFrom(s => s.Genre.ToString()))
                .ForMember(s => s.Artist, opts => opts.MapFrom(s => s.Artist.Name))
                .ForMember(s => s.Album, opts => opts.MapFrom(s => s.Album.Title));

            Mapper.CreateMap<SongRequestModel, Song>();

            Mapper.CreateMap<Artist, ArtistResponseModel>()
                .ForMember(a => a.Albums, opts => opts.MapFrom(a => a.Albums.Select(album => album.Title)))
                .ForMember(a => a.Songs, opts => opts.MapFrom(a => a.Songs.Select(s => s.Title)))
                .ForMember(a => a.Country, opts => opts.MapFrom(a => a.Country.Name));

            Mapper.CreateMap<ArtistRequestModel, Artist>();

            Mapper.CreateMap<Album, AlbumResponseModel>()
                .ForMember(a => a.Producer, opts => opts.MapFrom(a => a.Producer.Name))
                .ForMember(a => a.Songs, opts => opts.MapFrom(a => a.Songs.Select(s => s.Title)))
                .ForMember(a => a.Artists, opts => opts.MapFrom(a => a.Artists.Select(artist => artist.Name)));

            Mapper.CreateMap<AlbumRequestModel, Album>();
        }
    }
}