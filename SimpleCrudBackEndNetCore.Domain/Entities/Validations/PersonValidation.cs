using FluentValidation;

namespace SimpleCrudBackEndNetCore.Domain.Entities.Validations
{
    public class PersonValidation : AbstractValidator<Person>
    {
        public PersonValidation()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Sobrenome tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo sobrenome excedido!");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo email excedido!");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("Telefone tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo email excedido!");

            RuleFor(c => c.Address.Nationality)
                .NotEmpty().WithMessage("Nacionalidade tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.Address.ZoneInformationPostalCode)
                .NotEmpty().WithMessage("Cep tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.Address.City)
                .NotEmpty().WithMessage("Cidade tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.Address.PublicPlace)
                .NotEmpty().WithMessage("Logradouro tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.Address.BrazilianUfId)
                .NotEqual(Guid.Empty);
        }
    }
}
