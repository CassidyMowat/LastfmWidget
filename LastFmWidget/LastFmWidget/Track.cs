using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastFmWidget {

    class Track {

        private Boolean nowplaying;

        private String name;
        private String artist;
        private String url;
        private String image;

        public bool Nowplaying {
            get {
                return nowplaying;
            }

            set {
                nowplaying = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public string Artist {
            get {
                return artist;
            }

            set {
                artist = value;
            }
        }

        public string Url {
            get {
                return url;
            }

            set {
                url = value;
            }
        }

        public string Image {
            get {
                return image;
            }

            set {
                image = value;
            }
        }


    }
}
