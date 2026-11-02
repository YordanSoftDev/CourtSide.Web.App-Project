namespace CourtSide.Common
{
    public static class ValidationConstants
    {
        public static class Coach
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 20;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 20;
        }

        public static class Country
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 100;
        }

        public static class Match
        {
            public const int MatchStatusMaxLength = 20;
            public const int MatchRoundMaxLength = 20;
            public const int CourtSurfaceMaxLength = 20;

            public const int CourtNameMinLength = 2;
            public const int CourtNameMaxLength = 100;

            public const int CourtEnvironmentMaxLength = 20;
            public const int ScoreResultMaxLength = 100;           
        }

        public static class Player
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 20;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 20;

            public const int GenderMaxLength = 20;

            public const int WeightMinLength = 2;
            public const int WeightMaxLength = 25;

            public const int HeightMinLength = 2;
            public const int HeightMaxLength = 25;

            public const int BirthplaceMinLength = 6;
            public const int BirthplaceMaxLength = 100;
        }

        public static class Tournament
        {
            public const int TournamentNameMinLength = 2;
            public const int TournamentNameMaxLength = 100;

            public const int LocationMinLength = 6;
            public const int LocationMaxLength = 100;

            public const int TournamentTypeMinLength = 2;
            public const int TournamentTypeMaxLength = 50;

            public const int CourtSurfaceMaxLength = 20;
            public const int CourtEnvironmentMaxLength = 20;
        }

        public static class Venue
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 100;
        }
    }
}