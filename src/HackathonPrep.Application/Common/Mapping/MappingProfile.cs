using AutoMapper;
using HackathonPrep.Application.Handlers.Applicant.Command;
using HackathonPrep.Application.Handlers.Applicant.Queries;
using HackathonPrep.Application.Handlers.Education.Command;
using HackathonPrep.Application.Handlers.Education.Queries;
using HackathonPrep.Application.Handlers.Interest.Command;
using HackathonPrep.Application.Handlers.Interest.Queries;
using HackathonPrep.Application.Handlers.Student.Command;
using HackathonPrep.Application.Handlers.Student.Queries;
using HackathonPrep.Domain.Entities;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Application.Common.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Applicant, CreateApplicantCommand>().ReverseMap();
        CreateMap<Applicant, UpdateApplicantCommand>().ReverseMap();
        CreateMap<Applicant, GetAllApplicantsQuery>().ReverseMap();
        CreateMap<Applicant, GetApplicantByIdQuery>().ReverseMap();

        CreateMap<Education, CreateEducationCommand>().ReverseMap();
        CreateMap<Education, GetEducationByIdquery>().ReverseMap();

        CreateMap<Interest, CreateInterestCommand>().ReverseMap();
        CreateMap<Interest, GetInterestByIdQuery>().ReverseMap();

        CreateMap<AppUser, CreateStudentCommand>().ReverseMap();
        CreateMap<AppUser, LoginUserCommand>().ReverseMap();
        CreateMap<AppUser, UpdateStudentCommand>().ReverseMap();
        CreateMap<AppUser, GetStudentByIdQuery>().ReverseMap();
    }
    //public MappingProfile() => ApplyMappingFromAssembly(Assembly.GetExecutingAssembly());


    //private void ApplyMappingFromAssembly(Assembly assembly)
    //{
    //    var mapFromType = typeof(IMapFrom<>);
    //    var mappingMethodName = nameof(IMapFrom<object>.Mapping);
    //    bool HasInterface(Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == mapFromType;
    //    var types = assembly.GetExportedTypes().Where(t => t.GetInterfaces().Any(HasInterface)).ToList();
    //    var argumentTypes = new Type[] { typeof(Profile) };

    //    foreach (var type in types)
    //    {
    //        var instance = Activator.CreateInstance(type);

    //        var methodInfo = type.GetMethod(mappingMethodName);

    //        if (methodInfo != null)
    //        {
    //            methodInfo.Invoke(instance, new object[] { this });
    //        }
    //        else
    //        {
    //            var interfaces = type.GetInterfaces().Where(HasInterface).ToList();
    //            if (interfaces.Count > 0)
    //            {
    //                foreach (var @interface in interfaces)
    //                {
    //                    var interfaceMethodInfo = @interface.GetMethod(mappingMethodName, argumentTypes);
    //                    interfaceMethodInfo?.Invoke(instance, new object[] { this });
    //                }
    //            }
    //        }
    //    }
    //}
}
