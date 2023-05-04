namespace Prog_Eksamenssæt.Shared
{
	public class Schedule
	{
		public Event[] events { get; set; }

	}
	public class Event
	{
		public string summary { get; set; }
		public string location { get; set; }
		public string dtstart { get; set; }
		public string dtend { get; set; }
		public string description { get; set; }

		public DateTime Start { get; set; }
		public DateTime Slut { get; set; }

	}
}