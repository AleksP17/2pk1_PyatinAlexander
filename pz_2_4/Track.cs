using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_4
{
    class Track
    {
        string _author;
        string _title;
        string _valbum;
        int _year;
        int _bitrate;
        string _type;



        public Track()
        {
            _author = "unknoun";
            _title = "unknoun";
            _valbum = "unknoun";
            _year = 0;
            _bitrate = 0;
            _type = "unknoun";
        }
        public Track(string author)
        {
            _author = author;
            _title = "unknoun";
            _valbum = "unknoun";
            _year = 0;
            _bitrate = 0;
            _type = "unknoun";
        }
        public Track(string author, string title, string valbum) : this(author)
        {
            _title = title;
            _valbum = valbum;
            _year = 0;
            _bitrate = 0;
            _type = "unknoun";
        }
        public Track(string author, string title, string valbum, int year, int bitrate) : this(author, title, valbum)
        {
            _year = year;
            _bitrate = bitrate;
            _type = "unknoun";
        }
        public Track(string author, string title, string valbum, int year, int bitrate, string type) : this(author, title, valbum, year, bitrate)
        {
            _type = type;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Исполнитель: {_author} \n  Название: { _title}\n Альбом: {_valbum}\n Год выхода: {_year} \n  Битрейт: {_bitrate} \n Тип кодека: {_type}");

        }
    }
}
