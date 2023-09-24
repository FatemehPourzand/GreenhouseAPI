
namespace GreenhouseAPI.Dto.TbBatteries
{
    public class TbUserReadOnlyDto : BaseDto
    {
        public int IdUser { get; set; }
        public string Uname { get; set; }
        public string Upass { get; set; }
        public int IdRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public bool IsEnable { get; set; }
        public DateTime RegisterAt { get; set; }

    }

}
