using VargasM_Taller2.Models;

namespace VargasM_Taller2.Repositories
{
    public class EquipoRepository
    {
        private static List<Equipo> equipos = new List<Equipo>
        {
            new Equipo {
                Id = 1,
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
                Id = 2,
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
                Id = 3,
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
                Id = 4,
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
                Id = 5,
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
                Id = 6,
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
                Id = 7,
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
                Id = 8,
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
                Id = 9,
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
                Id = 10,
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
                Id = 11,
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
                Id = 12,
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
                Id = 13,
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
                Id = 14,
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
                Id = 15,
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
                Id = 16,
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

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            var equiposn = equipos.OrderByDescending(item => item.Puntos);

            return equiposn;
        }

        public Equipo DevuelveEquipoporId(int Id)
        {
            var equipo = equipos.First(item => item.Id == Id);

            return equipo;
        }

        public Boolean ActualizarEquipo(int Id, Equipo equipon)
        {
            var equipo = equipos.First(item => item.Id == Id);

            equipo.PartidosJugados = equipon.PartidosJugados;
            equipo.PartidosGanados = equipon.PartidosGanados;
            equipo.PartidosEmpatados = equipon.PartidosEmpatados;
            equipo.PartidosPerdidos = equipon.PartidosPerdidos;

            return true;
        }
    }
}
