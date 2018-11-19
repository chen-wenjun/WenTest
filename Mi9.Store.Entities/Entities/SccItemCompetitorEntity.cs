using System;

namespace Mi9.Store.Entities.Entities
{
    public class SccItemCompetitorEntity
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public bool QuoteProvided { get; set; }

        public DateTime? Date { get; set; }

        public decimal? Price { get; set; }

        public int SccItemId { get; set; }

        public int CompetitorId { get; set; }

        public virtual SccItemEntity SccItem { get; set; }
    }
   
}
