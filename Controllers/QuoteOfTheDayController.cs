using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class QuoteOfTheDayController : ApiController
    {
        // GET: api/QuoteOfTheDay
        /// <summary>
        /// Gibt das Zitat des Tages zurück
        /// </summary>
        /// <returns>Zitat des Tages</returns>
        public Quote Get()
        {
            return Quote.quoteOfTheDay;
        }

        // PUT: api/QuoteOfTheDay/5
        /// <summary>
        /// Setzt ein Zitat als Zitat des Tages fest
        /// </summary>
        /// <param name="id">Id des Zitates</param>
        public void Put(int id)
        {
            foreach (var quote in Quote.allQuotes)
            {
                if (quote.Id == id)
                {
                    Quote.quoteOfTheDay = quote;
                    return;
                }
            }
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}
