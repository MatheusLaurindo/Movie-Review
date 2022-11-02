﻿using MovieReview.Core.Domain.Base;
using MovieReview.Core.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReview.Core.Domain.Entities
{
    public class Title : Entity
    {
        public TypeMovie TypeMovie { get; private set; }
        public Genre Genre { get; private set; }
        public string TitleMovie { get; private set; }
        public int IdDirector { get; private set; }
        public virtual Director Director { get; private set; }
        public int IdScreenwriter { get; private set; }
        public Screenwriter Screenwriter { get; private set; }
        public int Duration { get; private set; }
        public string Synopsis { get; private set; }
        public virtual List<Review> Reviews { get; private set; }
        public virtual List<Actor> Actors { get; private set; }

        public void SetTitleMovie(string titleMovie)
        {
            TitleMovie = titleMovie;
        }

        public void SetTypeMovie(TypeMovie typeMovie)
        {
            TypeMovie = typeMovie;
        }

        public void SetGenre(Genre genre)
        {
            Genre = genre;
        }
        public void SetDuration(int duration)
        {
            Duration = duration;
        }

        public void SetSynopsis(string synopsis)
        {
            Synopsis = synopsis;
        }

        public void SetDirector(Director director)
        {
            Director = director;
        }

        public void SetScreenwriter(Screenwriter screenwriter)
        {
            Screenwriter = screenwriter;
        }

        public void SetActors(List<Actor> actors)
        {
            Actors = actors;
        }
    }
}
