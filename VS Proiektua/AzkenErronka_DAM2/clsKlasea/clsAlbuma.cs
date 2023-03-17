using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Klasea;

namespace clsKlasea
{
    public class clsAlbuma
    {
        #region "ATRIBUTOS"
        Albuma claseAlbuma = new Albuma();
        public int _kodAlb, _artistaKodea, _abestiKopurua, _urtea;
        public string _albumaIzena;
        #endregion

        #region "CONSTRUCTORES"

        public clsAlbuma()
        {
            _artistaKodea = artistaKodea;
        }


        public clsAlbuma(int artistaren_kodea)
        {
            _artistaKodea = artistaren_kodea;
        }

        #endregion


        #region "PROPIEDADES"
        public int kodAlb
        {
            get
            {
                return _kodAlb;
            }
            set
            {
                _kodAlb = value;
            }
        }
        public string albumaIzena
        {
            get
            {
                return _albumaIzena;
            }
            set
            {
                _albumaIzena = value;
            }
        }
        public int artistaKodea
        {
            get
            {
                return _artistaKodea;
            }
            set
            {
                _artistaKodea = value;
            }
        }
        public int abestiKopurua
        {
            get
            {
                return _abestiKopurua;
            }
            set
            {
                _abestiKopurua = value;
            }
        }
        public int urtea
        {
            get
            {
                return _urtea;
            }
            set
            {
                _urtea = value;
            }
        }

        #endregion



        #region "PROCEDIMIENTOS/FUNCIONES"

        public DataSet getAlbumak(string parametro)
        {
            DataSet dsAlbumak = claseAlbuma.getAlbumak(parametro);
            return dsAlbumak;
        }


        //getAlbumak_last
        public DataSet getAlbumak_last(string parametro)
        {
            DataSet dsAlbumak = claseAlbuma.getAlbumak_last(parametro);
            return dsAlbumak;
        }


        #endregion





    }
}
