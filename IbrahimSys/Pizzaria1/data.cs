using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Pizzaria1
{
    class data
    {
        private ObservableCollection<Song> song = new ObservableCollection<Song>();

      void  CreateSongdata()
        {
            song.Add(new Song()
            {
                Tital = "Like a Roling Song",Outher = "bub diln"
            });
        }

        public ObservableCollection <Song> getSongs()
        {
            song.Clear();
            CreateSongdata();
            return song;
        }
    }
}
