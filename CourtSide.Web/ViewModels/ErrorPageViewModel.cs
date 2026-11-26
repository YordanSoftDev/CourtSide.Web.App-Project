namespace CourtSide.Web.ViewModels
{
    public sealed class ErrorPageViewModel
    {
        public required string PageTitle { get; init; }
        public required string Breadcrumb { get; init; }
        public required string Code { get; init; }
        public required string Kicker { get; init; }
        public required string Title { get; init; }
        public required string DescriptionHtml { get; init; }
        public required string Hint { get; init; }
        public required string FooterLeft { get; init; }
        public string FooterRight { get; init; } = "Contact your administrator.";
    
        public string PrimaryButtonText { get; init; } = "Back to home";
        public bool PrimaryIsHomeLink { get; init; } = true;
    
        public string SecondaryButtonText { get; init; } = "Go back";
        public bool SecondaryIsBackButton { get; init; } = true;
    }
}