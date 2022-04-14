using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class QuoteController : ApiController
    {
        // GET: api/Quote
        /// <summary>
        /// Gibt alle Zitate zurück
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Quote> Get()
        {
            return Quote.allQuotes;
        }

        // GET: api/Quote/5
        /// <summary>
        /// Gibt ein bestimmtes Zitat anhand der Id zurück
        /// </summary>
        /// <param name="id">Id des Zitates</param>
        /// <returns></returns>
        public Quote Get(int id)
        {
            foreach (var quote in Quote.allQuotes)
            {
                if (quote.Id == id)
                {
                    return quote;
                }
            }
            return new Quote();
        }

        // POST: api/Quote
        /// <summary>
        /// Postet das mitgegebene Zitat auf der Webseite
        /// </summary>
        /// <param name="quote">Zitat als JSON</param>
        public void Post([FromBody] Quote quote)
        {
            int id = Quote.allQuotes.First().Id + 1;
            quote.Id = id;
            Quote.allQuotes.Insert(0, quote);
        }

        // PUT: api/Quote/5
        /// <summary>
        /// Überschreibt das Zitat auf der Webseite mit dem neuen Werten
        /// </summary>
        /// <param name="quote">Zitat als JSON</param>
        public void Put([FromBody]Quote quote)
        {
            var foundQuote = Quote.allQuotes.First(x => x.Id == quote.Id);
            int index = Quote.allQuotes.IndexOf(foundQuote);
            if (index != -1)
            {
                Quote.allQuotes[index] = quote;
            }
            else throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        // DELETE: api/Quote/5
        /// <summary>
        /// Löscht das Zitat auf der Webseite
        /// </summary>
        /// <param name="id">Id des Zitates</param>
        public void Delete(int id)
        {
            foreach (var quote in Quote.allQuotes.ToList())
            {
                if (quote.Id == id)
                {
                    Quote.allQuotes.Remove(quote);
                    return;
                }
            }
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}
