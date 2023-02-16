namespace Application.DTOs
{
    public record StrokeCountvsLengthTimeDTO
    {
        /// <summary>
        /// Stroke Count
        /// </summary>
        public int StrokeCount { get; set; }

        /// <summary>
        /// Length Time
        /// </summary>
        public double LengthTime { get; set; }
    }
}
