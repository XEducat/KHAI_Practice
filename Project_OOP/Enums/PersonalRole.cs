using System.ComponentModel.DataAnnotations;

namespace Project_OOP.Enums
{
    public enum PersonalRole
    {
        [Display(Name = "")]
        None,
        [Display(Name = "Капітан")]
        Captain,
        [Display(Name = "Пілот")]
        Pilot,
        [Display(Name = "Перший пілот")]
        FirstPilot,
        [Display(Name = "Другий пілот")]
        SecondPilot
    }
}
