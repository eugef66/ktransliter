using System;
using System.Collections.Generic;
using System.Text;
using TagLib;
using logfig;
namespace KTransliter.mp3
{
    public class MP3 : FileTypeBase
    {


        public MP3() : base() { }

        public override string FileSearchPatern
        {
            get { return "*.mp3"; }
        }

        public override void ProcessFile(string fileName, object logControl)
        {


            File _mp3 = TagLib.File.Create(fileName);


            //Album
            if (IsProcessTag("Album") && _mp3.Tag.Album != null) _mp3.Tag.Album = Transliterate(_mp3.Tag.Album);

            // AlbumArtist
            if (IsProcessTag("AlbumArtists"))
            {
                for (int i = 0; i < _mp3.Tag.AlbumArtists.Length; i++)
                {
                    _mp3.Tag.AlbumArtists[i] = Transliterate(_mp3.Tag.AlbumArtists[i]);
                }
            }

            //Artists
            if (IsProcessTag("Artists"))
            {
                for (int i = 0; i < _mp3.Tag.Artists.Length; i++)
                {
                    _mp3.Tag.Artists[i] = Transliterate(_mp3.Tag.Artists[i]);
                }
            }
            //Comment
            if (IsProcessTag("Comment") && _mp3.Tag.Comment != null) _mp3.Tag.Comment = Transliterate(_mp3.Tag.Comment);

            // Composers
            if (IsProcessTag("Composers"))
            {
                for (int i = 0; i < _mp3.Tag.Composers.Length; i++)
                {
                    _mp3.Tag.Composers[i] = Transliterate(_mp3.Tag.Composers[i]);
                }
            }
            // Conductor
            if (IsProcessTag("Conductor") && _mp3.Tag.Conductor != null) _mp3.Tag.Conductor = Transliterate(_mp3.Tag.Conductor);

            // Copyright

            if (IsProcessTag("Copyright") && _mp3.Tag.Copyright != null) _mp3.Tag.Copyright = Transliterate(_mp3.Tag.Copyright);

            //Genders
            if (IsProcessTag("Genres"))
            {
                for (int i = 0; i < _mp3.Tag.Genres.Length; i++)
                {
                    _mp3.Tag.Genres[i] = Transliterate(_mp3.Tag.Genres[i]);
                }
            }
            //Grouping 
            if (IsProcessTag("Grouping") && _mp3.Tag.Grouping != null) _mp3.Tag.Grouping = Transliterate(_mp3.Tag.Grouping);

            // Preformers
            if (IsProcessTag("Performers"))
            {
                for (int i = 0; i < _mp3.Tag.Performers.Length; i++)
                {
                    _mp3.Tag.Performers[i] = Transliterate(_mp3.Tag.Performers[i]);
                }
            }

            // Title 
            if (IsProcessTag("Title") && _mp3.Tag.Title != null) _mp3.Tag.Title = Transliterate(_mp3.Tag.Title);

            _mp3.Save();

            WriteLog(logControl, " - SUCCESS \n");

        }

        private bool IsProcessTag(string TagName)
        {
            bool _processTag = false;
            Boolean.TryParse(Program.MP3Settings.GetConfigKey(TagName, false).Value, out _processTag);
            return _processTag;
        }


    }
}
