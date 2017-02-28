﻿using System;

namespace LastSeen.Core.Infrastructure.Deserialization
{
	public class LastSeenItem
	{
		public string Id { get; set; }
		
		// Miniature
		public string Image { get; set; }
		public string Name { get; set; }
		public string Tag { get; set; }

		//Details
		public string Title { get; set; }
		public string Description { get; set; }
		public int Season { get; set; }
		public int Episode { get; set; }

		// Default constructor for use with deserialization
		public LastSeenItem()
		{
		}

		public LastSeenItem(bool initEmpty)
		{
			if (initEmpty)
				InitEmpty();
		}

		public void InitEmpty()
		{
			Id = Guid.NewGuid().ToString();
			Image = "";
			Name = "<unknown>";
			Tag = "<unknown>";
			Title = "<unknown>";
			Description = "<no description>";
			Season = 0;
			Episode = 0;
		}
	}
}
