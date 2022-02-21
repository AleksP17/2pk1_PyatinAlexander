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
        double _year;
        int _bitrate;
        string _type;
        static double _NumberOfTracks = 0;
        double Year
        {
            get { return _year; }
            set
            {
                if (value >= 1990 && value <= 2022)
                {
                    _year = value;
                }
                else
                    Console.WriteLine("Error");
                  
            }
        }
        enum Type
        { 
            MP3,
            AAC,
            FLAC
        }
        string Author
        {
            get { return _author; }
            set
            {
                if (value != "")
                    _author = value;
                else
                    _author = "unknoun";
            }
        }
        string Title
        {
            get { return _title; }
            set
            {
                if (value != "")
                    _title = value;
                else
                    _title = "unknoun";
            }
        }
        string Valbum
        {
            get { return _valbum; }
            set
            {
                if (value != "")
                    _valbum = value;
                else
                    _valbum = "unknoun";
            }

        }
        public Track()
        {
            _author = "";
            _title = "";
            _valbum = "";
            _year = 0;
            _bitrate = 0;
            _type = "";
        }
        public Track(string author)
        {
            _author = author;
            _title = "";
            _valbum = "";
            _year = 0;
            _bitrate = 0;
            _type = "";
        }
        public Track(string author, string title, string valbum) : this(author)
        {
            _title = title;
            _valbum = valbum;
            _year = 0;
            _bitrate = 0;
            _type = "";
        }
        public Track(string author, string title, string valbum, int year, int bitrate) : this(author, title, valbum)
        {
            _year = year;
            _bitrate = bitrate;
            _type = "";
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
