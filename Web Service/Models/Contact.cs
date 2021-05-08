
namespace Web_Service.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string PublicPhone { get; set; }

        public System.Collections.Generic.List<HotelInfo> HotelInfo { get; set; } = new System.Collections.Generic.List<HotelInfo>();

    }
}