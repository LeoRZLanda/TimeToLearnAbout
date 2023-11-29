using Portafolio.Interfaces;
using Portafolio.Models;
namespace Portafolio.Servicios{
    public class RepositorioProyectos : IRepositorioProyectos{

    public List<Proyecto> ObtenerProyectos(){
        return new List<Proyecto>() { 
            new Proyecto{
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://amazon.com",
                ImagenURL = "/images/amazon.png"
            },

            new Proyecto{
                Titulo = "New York Times",
                Descripcion = "Página de notcias en React",
                Link = "https://nytimes.com",
                ImagenURL = "/images/nyt.png"
            },

            new Proyecto{
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidad",
                Link = "https://amazon.com",
                ImagenURL = "/images/reddit.png"
            },

            new Proyecto{
                Titulo = "Steam",
                Descripcion = "Tienda en línea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/images/steam.png"
            }
        };
    }   

    }

}