using Klasea;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsKlasea
{
    public class clsAbestia
    {
        #region "ATRIBUTOS"
        Abestia claseAbestia = new Abestia();
        public int _kodAbestia, _egileaKodea, _albumaKodea, _urtea;
        public string _abestiaIzena, _abestiMota, _deskribapena;
        public TimeZone _iraupena;

        public int _generoa1, _generoa2, _generoa3;
        public int _collab1, _collab2, _collab3, _collab4, _collab5;

        #endregion



        #region "CONSTRUCTORES"
        public clsAbestia()
        {

        }

        public clsAbestia(int abestiaren_kodea, String abestiaren_izena, int artistaren_kodea, int albumaren_kodea)
        {
            _kodAbestia = abestiaren_kodea;
            _abestiaIzena = abestiaren_izena;
            _egileaKodea = artistaren_kodea;
            _albumaKodea = albumaren_kodea;
        }
        #endregion




        #region "PROCEDIMIENTOS/FUNCIONES"

        public DataSet getAbestiak(string parametro)
        {
            DataSet dsAbestiak = claseAbestia.getAbestiak(parametro);
            return dsAbestiak;
        }


        //getAlbumak_last
        public DataSet getAbestiak_luzea(string parametro)
        {
            DataSet dsAbestiak = claseAbestia.getAbestiak_luzea(parametro);
            return dsAbestiak;
        }


        public DataSet getAbestiKopurua_filtratuta(string parametro)
        {
            DataSet dsAbestiak = claseAbestia.getAbestiKopurua_filtratuta(parametro);
            return dsAbestiak;
        }


        //getAbestiak_Concretas
        public DataSet getAbestiak_Concretas(string parametro)
        {
            DataSet dsAbestiak = claseAbestia.getAbestiak_Concretas(parametro);
            return dsAbestiak;
        }

        #endregion



    }
}
