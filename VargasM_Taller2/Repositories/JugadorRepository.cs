using VargasM_Taller2.Models;

namespace VargasM_Taller2.Repositories
{
    public class JugadorRepository
    {
        private static List<Equipo> equipos = new List<Equipo>
        {
            new Equipo {
                Nombre = "Liga de Quito",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/liga_quito.svg",
                PartidosJugados = 6,
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
                Ciudad = "Quito",
                Estadio = "Rodrigo Paz Delgado",
                DT = "Pablo Sánchez"
            },
            new Equipo {
                Nombre = "Barcelona",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/barcelona.svg",
                PartidosJugados = 6,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 1,
                Ciudad = "Guayaquil",
                Estadio = "Estadio Banco Pichincha",
                DT = "Segundo Castillo"
            },
            new Equipo {
                Nombre = "Vinotinto FC",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/vinotinto_fc.svg",
                PartidosJugados = 8,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Ciudad = "Quito",
                Estadio = "Estadio Olímpico Atahualpa",
                DT = "Juan Grabowski"
            },
            new Equipo {
                Nombre = "U. Católica",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/universidad_catolica.svg",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Ciudad = "Quito",
                Estadio = "Estadio Olímpico Atahualpa",
                DT = "Jorge Célico"
            },
            new Equipo {
                Nombre = "Independiente del Valle",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/independiente_del_valle.svg",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
                Ciudad = "Sangolquí",
                Estadio = "Estadio Banco Guayaquil",
                DT = "Javier Gandolfi"
            },
            new Equipo {
                Nombre = "Libertad FC",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/libertad.svg",
                PartidosJugados = 6,
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
                Ciudad = "Loja",
                Estadio = "Estadio Reina del Cisne",
                DT = "Juan Carlos León"
            },
            new Equipo {
                Nombre = "Deportivo Cuenca",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/deportivo_cuenca.svg",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 4,
                Ciudad = "Cuenca",
                Estadio = "Banco del Austro Alejandro Serrano Aguil",
                DT = "Norberto Araujo"
            },
            new Equipo {
                Nombre = "Orense",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/orense.svg",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3,
                Ciudad = "Machala",
                Estadio = "9 de mayo",
                DT = "Santiago Escobar"
            },
            new Equipo {
                Nombre = "Mushuc Runa",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/mushuc_runa.svg",
                PartidosJugados = 7,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                Ciudad = "Ambato",
                Estadio = "Cooperativa de Ahorro y Crédito Mushuc Runa",
                DT = "Ever Almeida"
            },
            new Equipo {
                Nombre = "Aucas",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/aucas.svg",
                PartidosJugados = 7,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
                Ciudad = "Quito",
                Estadio = "Estadio Cooprogreso Gonzalo Pozo Ripalda",
                DT = "Gabriel Pereyra"
            },
            new Equipo {
                Nombre = "Macará",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/macara.svg",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
                Ciudad = "Ambato",
                Estadio = "Estadio Universidad Indoamérica Bellavista",
                DT = "Alexandré Pallarés"
            },
            new Equipo {
                Nombre = "Manta",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/manta.svg",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3,
                Ciudad = "Manta",
                Estadio = "Estadio Jocay",
                DT = "Efrén Mera"
            },
            new Equipo {
                Nombre = "Emelec",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/emelec.svg",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 4,
                PartidosPerdidos = 3,
                Ciudad = "Guayaquil",
                Estadio = "Estadio George Capwell Banco del Austro",
                DT = "Leonel Álvarez"
            },
            new Equipo {
                Nombre = "Técnico Universitario",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/tecnico_universitario.svg",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
                Ciudad = "Ambato",
                Estadio = "Estadio Universidad Indoamérica Bellavista",
                DT = "Paul Vélez"
            },
            new Equipo {
                Nombre = "Delfin",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/delfin.svg",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
                Ciudad = "Manta",
                Estadio = "Estadio Jocay",
                DT = "Javier Carvajal"
            },
            new Equipo {
                Nombre = "El Nacional",
                LogoUrl = "https://www.ole.com.ar/img/escudos/ecuador/el_nacional.svg",
                PartidosJugados = 7,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 4,
                Ciudad = "Quito",
                Estadio = "Estadio Olímpico Atahualpa",
                DT = "N/A"
            },
        };

        public IEnumerable<Equipo> DevuelveListaJugadores()
        {
            var equiposn = equipos.OrderByDescending(item => item.Puntos);

            return equiposn;
        }
    }
}
