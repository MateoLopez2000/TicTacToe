using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ttt4
{
    class Media_Player
    {
        public void musica_ganar()
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\bites-ta-da-winner.wav";
            player.Play();

        }

        public void musica_empate()
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\music_empate.wav";
            player.Play();

        }

        public void musica_insertar()
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\poner_moneda.wav";
            player.Play();

        }

        public void musica_fondo()
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @".\Solve The Puzzle.wav";
            player.PlayLooping();

        }
    }
}
