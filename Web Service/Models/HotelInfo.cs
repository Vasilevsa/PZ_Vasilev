
namespace Web_Service.Models
{
    public class HotelInfo
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string AdmArea { get; set; }

        public string District { get; set; }

        public string Address { get; set; }

        public string LegalAddress { get; set; }

        public System.Collections.Generic.List<Contact> ContactPhone { get; set; } = new System.Collections.Generic.List<Contact>();

        public string Email { get; set; }

        public string WebSite { get; set; }
    }
}