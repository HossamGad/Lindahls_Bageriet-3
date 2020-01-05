using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    // Repository innehåller de mest grundläggande anropen mot databasen
    // ta bort, lägga till, hämta en specifik, hämta alla
    // tänk "grundstomme"
    public class CommentaryRepository : ICommentary
    {
        // interfacet till klassen Commentary kopplas hit, dvs 
        // klassen implementerar interface ICommentary

        // databas-objekt 
        private readonly AppDbContext database;

        // constructor
        public CommentaryRepository(AppDbContext appDbContext)
        {
            database = appDbContext;
        }

        // hämta alla kommentarer
        public IEnumerable<Commentary> GetCommentaryAll()
        {
            return database.DbCommentary;
        }

        // hämta alla kommentarer för angiven produkt
        public IEnumerable<Commentary> GetCommentaryByProduct(int inProjektId)
        {
            return database.DbCommentary.
                            Where(c => c.ProductId == inProjektId);
            //Where(c => c.ProductId == inProjektId).ToList();
        }

        // lägg till ny kommentar
        public void AddCommentary(Commentary inCommentary)
        {
            database.DbCommentary.Add(inCommentary);
            database.SaveChanges();

        }
    }
}
