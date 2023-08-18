using System;


namespace Tarea01
{
    class Program
    {
        static void Main(string[] args)
        {
            Album Album1 = new Album();
            Album1.nombreAlbum = "Love Yourself: Tear";
            Album1.nombreArtista = "BTS";
            Album1.anioPublicacion = 2018;
            Album1.numCanciones = 11;

            Album Album2 = new Album();
            Album2.nombreAlbum = "accent fried";
            Album2.nombreArtista = "Mokyo";
            Album2.anioPublicacion = 2020;
            Album2.numCanciones = 10;

            Album Album3 = new Album();
            Album3.nombreAlbum = "Indigo";
            Album3.nombreArtista = "RM";
            Album3.anioPublicacion = 2022;
            Album3.numCanciones = 10;

            Album Album4 = new Album();
            Album4.nombreAlbum = "Summer Plumage";
            Album4.nombreArtista = "SE SO NEON";
            Album4.anioPublicacion = 2017;
            Album4.numCanciones = 6;

            Album Album5 = new Album();
            Album5.nombreAlbum = "The Gods We Can Touch";
            Album5.nombreArtista = "AURORA";
            Album5.anioPublicacion = 2022;
            Album5.numCanciones = 15;


            Cancion Cancion1 = new Cancion();
            Cancion1.tituloCancion = "Blow";
            Cancion1.artistaCancion = "Jackson Wang";
            Cancion1.duracionCancion = "2:20 min";
            Cancion1.generoCancion = "Pop-rock";

            Cancion Cancion2 = new Cancion();
            Cancion2.tituloCancion = "Who Dat Boy";
            Cancion2.artistaCancion = "Tyler, The Creator";
            Cancion2.duracionCancion = "3:25 min";
            Cancion2.generoCancion = "Hip Hop";

            Cancion Cancion3 = new Cancion();
            Cancion3.tituloCancion = "Praise God";
            Cancion3.artistaCancion = "Kanye West";
            Cancion3.duracionCancion = "3:46 min";
            Cancion3.generoCancion = "Trap";

            Cancion Cancion4 = new Cancion();
            Cancion4.tituloCancion = "Les";
            Cancion4.artistaCancion = "Childish Gambino";
            Cancion4.duracionCancion = "5:17 min";
            Cancion4.generoCancion = "Hip-Hop Rap";

            Cancion Cancion5 = new Cancion();
            Cancion5.tituloCancion = " A donde vas?";
            Cancion5.artistaCancion = "Alvinsch";
            Cancion5.duracionCancion = "5:17";
            Cancion5.generoCancion = "Psychedelic";


            Artista Artista1 = new Artista();
            Artista1.nombre = "DPR Ian";
            Artista1.nacionalidad = "Australiano";
            Artista1.edad = 32;
            Artista1.agencia = "Dream Perfect Regime";

            Artista Artista2 = new Artista();
            Artista2.nombre = "eAeon";
            Artista2.nacionalidad = "Coreano";
            Artista2.edad = 47;
            Artista2.agencia = "MOTMUSIC";

            Artista Artista3 = new Artista();
            Artista3.nombre = "Arca";
            Artista3.nacionalidad = "Venezolana";
            Artista3.edad = 33;
            Artista3.agencia = "UNO NYC";

            Artista Artista4 = new Artista();
            Artista4.nombre = "Stromae";
            Artista4.nacionalidad = "Belga";
            Artista4.edad = 38;
            Artista4.agencia = "Universal Music Group";

            Artista Artista5 = new Artista();
            Artista5.nombre = "BIBI";
            Artista5.nacionalidad = "Coreana";
            Artista5.edad = 24;
            Artista5.agencia = "8rising";
        }
    }
}
