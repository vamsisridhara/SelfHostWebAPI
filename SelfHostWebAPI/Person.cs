using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostWebAPI
{
    [Validator(typeof(PersonValidator))]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            //RuleFor(x => x.Id).NotNull().WithMessage("The First Name cannot be blank.")
            //                        .Length(0, 100).WithMessage("The First Name cannot be more than 100 characters.");

            //RuleFor(x => x.LastName).NotEmpty().WithMessage("The Last Name cannot be blank.");

            //RuleFor(x => x.BirthDate).LessThan(DateTime.Today).WithMessage("You cannot enter a birth date in the future.");

            //RuleFor(x => x.Username).Length(8, 999).WithMessage("The user name must be at least 8 characters long.");

            RuleFor(x => x.Id).NotEmpty().WithMessage("Person Id cant be NULL");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Person Name cant be NULL")
                .Length(0, 10).WithMessage("Person NAme cant be more than 10 chars");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().WithMessage("Email address is mandatory");
            RuleFor(x => x.Age).InclusiveBetween(18, 60);
        }
    }
}
