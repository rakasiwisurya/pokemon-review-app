﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsByAPokemon(int pokemonId);
        bool ReviewExists(int reviewId);
    }
}
