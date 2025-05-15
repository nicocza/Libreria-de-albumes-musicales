using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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

                while (data.Reader.Read())
                {
                    Album album = new Album();
                    album.Id = (int)data.Reader["Id"];
                    album.Title = (string)data.Reader["Album"];
                    album.Artist = (string)data.Reader["Artist"];
                    album.Songs = (int)data.Reader["Songs"];
                    if (!(data.Reader["ImageURL"] is DBNull))
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

        public void Add(Album newAlbum)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Insert into DISCOS (Album, Artist, Songs, IdGenre, IdEdition, ImageURL) VALUES ('"+newAlbum.Title+"', '"+newAlbum.Artist+"', '"+newAlbum.Songs+"', @IdGenre, @IdEdition, @ImageURL)");
                data.SetParameters("@IdGenre", newAlbum.Genre.Id);
                data.SetParameters("@IdEdition", newAlbum.Edition.Id);
                data.SetParameters("@ImageURL", newAlbum.ImageURL);

                data.executeAction();
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

        public void Modify(Album newA)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Update DISCOS Set Album = @album, Artist = @artist, IdGenre = @idGenre, IdEdition = @idEdition, Songs = @songs, ImageURL = @imageURL Where Id = @id"); 
                data.SetParameters("@album", newA.Title);
                data.SetParameters("@artist", newA.Artist);
                data.SetParameters("@idGenre", newA.Genre.Id);
                data.SetParameters("@idEdition", newA.Edition.Id);
                data.SetParameters("@songs", newA.Songs);
                data.SetParameters("@imageURL", newA.ImageURL);
                data.SetParameters("@id", newA.Id);

                data.executeAction();
            }
            catch (Exception ex)
            {
                throw new Exception("Error modifying.", ex);
            }
            finally
            {
                data.closeConnection();
            }
        }

        public void Delete(int id)
        {
            try
            {
                DataAccess data = new DataAccess();
                data.setQuery("Delete from DISCOS Where id = @id");
                data.SetParameters("@id", id);
                data.executeRead();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
