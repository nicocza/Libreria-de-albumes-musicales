using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Control
{
    public class AlbumBusiness
    {
        public List<Album> AlbumList()
        {
            List<Album> list = new List<Album>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Select Album, Artist, Songs, ImageURL, G.Description As GENRE ,E.Description As EDITION, D.IdGenre, D.IdEdition, D.Id From DISCOS D, ESTILOS G, TIPOSEDICION E Where G.Id = D.IdGenre And E.Id = D.IdEdition");
                data.executeRead();

                while(data.Reader.Read())
                {
                    Album album = new Album();
                    album.Id = (int)data.Reader["Id"];
                    album.Title = (string)data.Reader["Album"];
                    album.Artist = (string)data.Reader["Artist"];
                    album.Songs = (int)data.Reader["Songs"];
                    if(!(data.Reader["ImageURL"] is DBNull))
                        album.ImageURL = (string)data.Reader["ImageURL"];
                    album.Genre = new Genre();
                    album.Genre.Id = (int)data.Reader["IdGenre"];
                    album.Genre.Description = (string)data.Reader["GENRE"];
                    album.Edition = new Edition();
                    album.Edition.Id = (int)data.Reader["IdEdition"];
                    album.Edition.Description = (string)data.Reader["EDITION"];

                    list.Add(album);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }
    }
}
