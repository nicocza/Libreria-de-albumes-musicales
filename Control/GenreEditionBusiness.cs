using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Control
{
    public class GenreEditionBusiness
    {
        public List<Genre> genres()
        {
            List<Genre> list = new List<Genre>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Select Id, Description From ESTILOS");
                data.executeRead();

                while(data.Reader.Read())
                {
                    Genre gen = new Genre();
                    gen.Id = (int)data.Reader["Id"];
                    gen.Description = (string)data.Reader["Description"];

                    list.Add(gen);
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

        public List<Edition> Editions()
        {
            List<Edition> list = new List<Edition>();
            DataAccess data = new DataAccess();

            try
            {
                data.setQuery("Select Id, Description From TIPOSEDICION");
                data.executeRead();

                while(data.Reader.Read())
                {
                    Edition edi = new Edition();
                    edi.Id = (int)data.Reader["Id"];
                    edi.Description = (string)data.Reader["Description"];

                    list.Add(edi);
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
