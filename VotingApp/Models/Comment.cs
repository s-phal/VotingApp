﻿using System.ComponentModel.DataAnnotations;

namespace VotingApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        // public bool StatusUpdated

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

        public int SpamReports { get; set; } = 0;

        public string MemberId { get; set; }
        public Member? Member { get; set; }

        public int IdeaId { get; set; }
        public Idea? Idea { get; set; }
    }
}
