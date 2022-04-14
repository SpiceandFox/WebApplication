using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AuthorController : ApiController
    {
        // GET: api/Author
        /// <summary>
        /// Gibt eine Liste aller vorhandenen Autoren zurück
        /// </summary>
        /// <returns>Liste aller Autoren</returns>
        public IEnumerable<string> Get()
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var quote in Quote.allQuotes)
            {
                result.Add(quote.Author);
            }
            return result;
        }
    }
}
