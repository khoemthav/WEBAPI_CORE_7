using AutoMapper;
using LearnAPI.Modal;
using LearnAPI.Repos.Models;

namespace LearnAPI.Helper
{
    public class AutoMapperHandler:Profile
    {
        public AutoMapperHandler() {
            CreateMap<TblCustomer, Customermodal>().ForMember(static item => item.Statusname, static opt => opt.MapFrom(
                static item => (item.IsActive != null && item.IsActive.Value) ? "Active" : "In active")).ReverseMap() ;
            CreateMap<TblUser, UserModel>().ForMember(static item => item.Statusname, static opt => opt.MapFrom(
                static item => (item.Isactive != null && item.Isactive.Value) ? "Active" : "In active")).ReverseMap();
        }
    }
}
