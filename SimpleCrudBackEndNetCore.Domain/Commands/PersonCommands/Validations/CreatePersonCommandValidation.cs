using FluentValidation;

namespace SimpleCrudBackEndNetCore.Domain.Commands.PersonCommands.Validations
{
    public class CreatePersonCommandValidation : AbstractValidator<CreatePersonCommand> 
    {
        public CreatePersonCommandValidation() 
        {
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

            RuleFor(c => c.Nationality)
                .NotEmpty().WithMessage("Nacionalidade tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.ZoneInformationPostalCode)
                .NotEmpty().WithMessage("Cep tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("Cidade tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.PublicPlace)
                .NotEmpty().WithMessage("Logradouro tem que ser preenchido!")
                .Length(0, 100).WithMessage("Tamanho do campo nome excedido!");

            RuleFor(c => c.BrazilianUfId)
                .NotEqual(Guid.Empty);
        }
    }
}
