using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_4
{
    sealed class AudioBook : Track
    {
        public int _duration;
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value >= 30 && value <= 90)
                    _duration = value;

            }
        }
        public AudioBook(string author, string title, string valbum, int year, int bitrate, string type) : base(author, title, valbum, year, bitrate, type)
        {
            Duration = _duration;
        }
        public  void GetInfo()
        {
            Console.WriteLine($"Исполнитель: {Author} \n  Название: { Title}\n Альбом: {Valbum}\n Год выхода: {Year} \n  Битрейт: {_bitrate} \n Тип кодека: {_type} \n Продолжительность {Duration} минут");

        }
        public AudioBook(string author)
        {
            Author = author;
            Title = "";
            Valbum = "";
            Year = 0;
            _bitrate = 0;
            _type = "";
        }
        public AudioBook(string author, string title, string valbum) : base(author)
        {
            Title = title;
            Valbum = valbum;
            Year = 0;
            _bitrate = 0;
            _type = "";
        }
        public AudioBook(string author, string title, string valbum, double year, int bitrate, string type) : base(author, title, valbum)
        {
            Year = year;
            _bitrate = bitrate;
            _type = type;
        }
        
    }
    
}
