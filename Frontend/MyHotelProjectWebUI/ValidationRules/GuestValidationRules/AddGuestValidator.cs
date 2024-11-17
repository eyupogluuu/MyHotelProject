using FluentValidation;
using MyHotelProjectWebUI.Models.Guest;

namespace MyHotelProjectWebUI.ValidationRules.GuestValidationRules
{
    public class AddGuestValidator : AbstractValidator<AddGuestViewModel>
    {
        public AddGuestValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.surname).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.city).NotEmpty().WithMessage("Bu Alan Boş Geççilemez");

            RuleFor(x => x.name).MinimumLength(3).WithMessage("Lütfen 3 Karakterden Az Veri Girişi Yapmayınız");
            RuleFor(x => x.surname).MinimumLength(3).WithMessage("Lütfen 3 Karakterden Az Veri Girişi Yapmayınız");
            RuleFor(x => x.city).MinimumLength(3).WithMessage("Lütfen 3 Karakterden Az Veri Girişi Yapmayınız");

            RuleFor(x => x.name).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Veri Girişi Yapmayınız");
            RuleFor(x => x.surname).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Veri Girişi Yapmayınız");
            RuleFor(x => x.city).MaximumLength(30).WithMessage("Lütfen 30 Karakterden Fazla Veri Girişi Yapmayınız");

        }
    }
}
