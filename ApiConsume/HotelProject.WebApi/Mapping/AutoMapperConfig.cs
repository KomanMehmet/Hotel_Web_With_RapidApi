﻿using AutoMapper;
using HotelProject.DtoLayer.Dtos.AboutDtos;
using HotelProject.DtoLayer.Dtos.BookingDtos;
using HotelProject.DtoLayer.Dtos.ContactDtos;
using HotelProject.DtoLayer.Dtos.GuestDtos;
using HotelProject.DtoLayer.Dtos.RoomDtos;
using HotelProject.DtoLayer.Dtos.SendMessageDtos;
using HotelProject.DtoLayer.Dtos.ServiceDtos;
using HotelProject.DtoLayer.Dtos.StaffDtos;
using HotelProject.DtoLayer.Dtos.SubscribeDtos;
using HotelProject.DtoLayer.Dtos.TestimonialDtos;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<GetByIdRoomDto, Room>().ReverseMap();

            CreateMap<CreateStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<GetByIdStaffDto, Staff>().ReverseMap();

            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<GetByIdTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<GetByIdServiceDto, Service>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<GetByIdSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto, About>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();
            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<GetByIdBookingDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<GetByIdGuestDto, Guest>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<GetByIdContactDto, Contact>().ReverseMap();

            CreateMap<CreateSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<UpdateSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<ResultSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<GetByIdContactDto, SendMessage>().ReverseMap();
        }
    }
}
