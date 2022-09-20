using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SimpleCrudBackEndNetCore.Application.Contracts;
using SimpleCrudBackEndNetCore.Application.Implementations;
using SimpleCrudBackEndNetCore.Domain.CommandHandlers;
using SimpleCrudBackEndNetCore.Domain.Commands;
using SimpleCrudBackEndNetCore.Domain.Contracts.Repositories;
using SimpleCrudBackEndNetCore.Infra.Repositories;

namespace SimpleCrudBackEndNetCore.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Repositories read model
            services.AddScoped<IPersonDapperRespository, PersonDapperRespository>();

            //Repositories write model
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IPersonRepository, PersonRepository>(); 

            //ApplicationService
            services.AddScoped<IPersonApplicationService, PersonApplicationService>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<CreatePersonCommand, ValidationResult>, PersonCommandHandler>();
            services.AddScoped<IRequestHandler<UpdatePersonCommand, ValidationResult>, PersonCommandHandler>();
            services.AddScoped<IRequestHandler<DeletePersonCommand, ValidationResult>, PersonCommandHandler>();
        }
    }
}