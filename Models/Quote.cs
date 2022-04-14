using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication.Models
{
    [DataContract]
    public class Quote
    {
        public static Quote quoteOfTheDay = new Quote(17, "You miss 100% of the shots you don't take. -Wayne Gretzky", "Michael Scott", DateTime.Now);
        public static List<Quote> allQuotes = new List<Quote> {
            new Quote(17, "You miss 100% of the shots you don't take. -Wayne Gretzky", "Michael Scott", DateTime.Now),
            new Quote(16, "Ich kenne keinen sicheren Weg zum Erfolg, aber einen sicheren Weg zum Misserfolg: es jedem recht machen zu wollen.", "Platon", DateTime.Now),
            new Quote(15, "Die Hartnäckigen gewinnen die Schlachten.", "Napoleon Bonaparte", DateTime.Now),
            new Quote(14, "Es gibt keinen bequemen Weg, der von der Erde zu den Sternen führt.", "Seneca", DateTime.Now),
            new Quote(13, "Ich habe gelernt, dass Mut nicht die Abwesenheit von Furcht ist, sondern der Triumph darüber. Der mutige Mann ist keiner, der keine Angst hat, sondern der, der die Furcht besiegt.", "Nelson Mandela", DateTime.Now),
            new Quote(12, "Wenn du etwas ganz fest willst, dann wird das Universum darauf hinwirken, dass du es erreichen kannst.", "Paulo Coelho", DateTime.Now),
            new Quote(11, "Wenn die Wurst so dick wie das Brot ist, dann ist wurst wie dick das Brot ist", "Robert Straberger", DateTime.Now),
            new Quote(10, "Alles, was du dir vorstellen kannst, ist real.", "Pablo Picasso", DateTime.Now),
            new Quote(9, "Das Bestreben, Träume zu verwirklichen, verträgt sich nur sehr schwer mit Inkonsequenz.", "Oliver Mally", DateTime.Now),
            new Quote(8, "Hindernisse können mich nicht aufhalten; Entschlossenheit bringt jedes Hindernis zu Fall.", "Leonardo da Vinci", DateTime.Now),
            new Quote(7, "Unsere größte Schwäche liegt im Aufgeben. Der sichere Weg zum Erfolg ist immer, es doch noch einmal zu versuchen.", "Thomas Alva Edison", DateTime.Now),
            new Quote(6, "Nichts auf der Welt ist so mächtig wie eine Idee, deren Zeit gekommen ist.", "Victor Hugo", DateTime.Now),
            new Quote(5, "Wege entstehen dadurch, dass man sie geht.", "Franz Kafka", DateTime.Now),
            new Quote(4, "Ich habe niemals an Erfolg geglaubt. Ich habe dafür gearbeitet.", "Estée Lauder", DateTime.Now),
            new Quote(3, "Alle Träume können wahr werden, wenn wir den Mut haben, ihnen zu folgen.", "Walt Disney", DateTime.Now),
            new Quote(2, "Es ist nicht von Bedeutung, wie langsam du gehst, solange du nicht stehenbleibst.", "Konfuzius", DateTime.Now),
            new Quote(1, "Phantasie ist wichtiger als Wissen, denn Wissen ist begrenzt.","Albert Einstein", DateTime.Now),
            new Quote(0, "Der Zweifel am Siege entschuldigt nicht das Aufgeben des Kampfes.", "Marie Freifrau von Ebner-Eschenbach", DateTime.Now)
        };
        [DataMember(Name = "quoteText")]
        public string QuoteText { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "author")]
        public string Author { get; set; }
        [DataMember(Name = "postedDate")]
        public DateTime PostedDate { get; set; }

        public Quote(){}

        public Quote(int id, string quoteText, string author, DateTime postedDate)
        {
            Id = id;
            QuoteText = quoteText;
            Author = author;
            PostedDate = postedDate;
        }

    }
}