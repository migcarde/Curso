using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Curso.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(
                new Session()
                {
                    Title = "I want Spaguetti",
                    Abstract = "The life and times of spaguetti lover",
                    Speaker = context.Speakers.Add(
                                    new Speaker()
                                    {
                                        Name = "Jon Galloway",
                                        EmailAddress = "jon@nowhere.com"
                                    })
                });
            context.SaveChanges();
        }
    }
}