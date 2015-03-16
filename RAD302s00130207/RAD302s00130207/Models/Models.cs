using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAD302s00130207.Models
{

    public class MovieSeed:DropCreateDatabaseAlways<MovieDb>
    {
        protected override void Seed(MovieDb context)
        {
            var lmovies = new List<Movies>()
            {
                new Movies(){MovieTitle = "Transformers", MovieCountry = "USA"
                },
                new Movies(){MovieTitle = "Inception", MovieCountry = "Usa"
                },
                new Movies(){MovieTitle = "Taxi", MovieCountry = "France "
                },
                new Movies(){MovieTitle = "Good Neighbours", MovieCountry = "Canada "
                }





                //     new Movies(){MovieTitle = "2012", MovieCountry = "Ireland", MovieInfo = new List<MovieInfo>()
                //{
                //    new MovieInfo(){MovieCountry = "Ireland"}
                //}},
                //new Movies(){MovieTitle = "Transformers",
                //MovieInfo = new List<MovieInfo>()
                //{
                //    new MovieInfo(){MovieCountry = "Russia"}
                //}},
                //new Movies(){MovieTitle = "Transformers 2", MovieInfo = new List<MovieInfo>()
                //{
                //    new MovieInfo(){MovieCountry = "Ukraine"}
                //}},
                //new Movies(){MovieTitle = "Transformers 3", MovieInfo = new List<MovieInfo>()
                //{
                //    new MovieInfo(){MovieCountry = "Ireland"}
                
            };
            lmovies.ForEach(m => context.Movies.Add(m));
            context.SaveChanges();
            base.Seed(context);
        }
    }

    public class MovieDb : DbContext 
	{
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieInfo> Posts { get; set; }
        

        public MovieDb() : base("MovieConnString") { }
	}

    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieCountry { get; set; }


        //public List<MovieInfo> MovieInfo { get; set; }
    }

    public class MovieInfo
    {
        
        public int MovieInfoId { get; set; }
        public string MovieCountry { get; set; }
        public Movies Movies { get; set; }
    }
}