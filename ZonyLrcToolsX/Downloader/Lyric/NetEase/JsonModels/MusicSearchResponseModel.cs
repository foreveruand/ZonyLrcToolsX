using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZonyLrcToolsX.Downloader.Lyric.NetEase.JsonModels
{
    internal class MusicSearchResponseModel
    {
        [JsonProperty("result")]
        public InnerListItemModel Items { get; set; }
        
        [JsonProperty("code")]
        public int StatusCode { get; set; }
    }
    
    internal class InnerListItemModel
    {
        [JsonProperty("songs")]
        public IList<SongModel> SongItems { get; set; }
        
        [JsonProperty("songCount")]
        public int SongCount { get; set; }
    }

    internal class SongModel
    {
        /// <summary>
        /// 歌曲的名称。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 歌曲的 Sid (Song Id)。
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 歌曲的演唱者。
        /// </summary>
        [JsonProperty("artists")]
        public IList<SongArtistModel> Artists { get; set; }

        /// <summary>
        /// 歌曲的专辑信息。
        /// </summary>
        [JsonProperty("album")]
        public SongAlbumModel Album { get; set; }
    }

    internal class SongArtistModel
    {
        /// <summary>
        /// 歌手/艺术家的名称。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    internal class SongAlbumModel
    {
        /// <summary>
        /// 专辑的名称。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// 专辑图像的 Url 地址。
        /// </summary>
        [JsonProperty("picUrl")]
        public string PictureUrl { get; set; }
    }
}