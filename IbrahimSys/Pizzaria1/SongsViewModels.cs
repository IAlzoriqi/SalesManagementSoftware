using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria1
{
    class SongsViewModels
    {

        data source = new data();

        private ObservableCollection<Song> songslist = new ObservableCollection<Song>();

        public ObservableCollection<Song> SongList
        {
            get { return songslist; }

        }
            public  SongsViewModels()
             {
            foreach( var songs in source.getSongs())
            {
                songslist.Add(songs);
            }

             }

        
    }
}
