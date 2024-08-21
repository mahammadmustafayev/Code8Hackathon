using AutoMapper;

namespace HackathonPrep.Application.Common.Interfaces;

public interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType()).ReverseMap();
}
