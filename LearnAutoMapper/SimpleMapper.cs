using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoMapper
{
    class SimpleMapper
    {
        public static void RunSimpleMapperUser() {


            Console.WriteLine("start.. RunSimpleMapperUser");
            Mapper.Reset();
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserDto, UserModel>()
                .ForMember(dest => dest.DateOfBirth, opt =>opt.MapFrom(src => src.Dob)) // map field to different field name 
                .ForMember(dest => dest.Age, opt => opt.Ignore()); // ignore if any mapping error 

                cfg.CreateMap<IncomeDto, IncomeModel>();
            });

            

            var userDto = new UserDto()
            {
                UserID = "001",
                FirstName = "Terran",
                SureName = "Pradopo",
                AccessCode = "Terran",
                Age = "3.5",
                Dob = new DateTime(2016, 2, 9)
            };

            var incomeDto = new IncomeDto()
            {
                UserID = "002",
                MonthlyIncome = 10000,
                TaxAnnually = 10
            };

            userDto.IncomeInfo = incomeDto;

            var userModel = Mapper.Map<UserModel>(userDto);
            //var icomeModel = Mapper.Map<IncomeModel>(incomeDto);
            Console.WriteLine("user Dto");
            Console.WriteLine($"--- userID::{userDto.UserID} , FistName::{userDto.FirstName}, SureName::{userDto.SureName}, AccessCode::{userDto.AccessCode}, age::{userDto.Age}, date of birth::{userDto.Dob:dd-MM-yyyy}");
            Console.WriteLine($"--- MonthlyIncome::{userDto.IncomeInfo.MonthlyIncome} , TaxAnnually::{userDto.IncomeInfo.TaxAnnually}");
            Console.WriteLine("user Model");
            Console.WriteLine($"--- userID::{userModel.UserID} , FistName::{userModel.FirstName}, SureName::{userModel.SureName}, AccessCode::{userModel.AccessCode}, age::{userModel.Age}, date of birth::{ userModel.DateOfBirth:dd-MM-yyyy}");
            Console.WriteLine($"--- MonthlyIncome::{userModel.IncomeInfo.MonthlyIncome} , TaxAnnually::{userModel.IncomeInfo.TaxAnnually}");
            Console.WriteLine("Finished RunSimpleMapperUser");

           
        }

        public static void RunSampleFlaterring() {
            Console.WriteLine("start.. RunSampleFlaterring");
            var customer = new Customer
            {
                Name = "George Costanza"
            };
            var order = new Order
            {
                Customer = customer
            };
            var bosco = new Product
            {
                Name = "Bosco",
                Price = 4.99m
            };
            order.AddOrderLineItem(bosco, 15);

            // Configure AutoMapper
            Mapper.Reset();
            Mapper.Initialize(cfg =>
                cfg.CreateMap<Order, OrderDto>()
            );

            // Perform mapping

            OrderDto dto = Mapper.Map<Order, OrderDto>(order);

            Console.WriteLine("original data");
            Console.WriteLine($"-- order.Customer.Name::{order.Customer.Name}, Total::{order.GetTotal()}");
            Console.WriteLine("Order DTO");
            Console.WriteLine($"-- CustomerName::{dto.CustomerName}, Total::{dto.Total}");
            //dto.CustomerName.ShouldEqual("George Costanza");
            //dto.Total.ShouldEqual(74.85m);
            Console.WriteLine("Finished RunSampleFlaterring");
        }
    }
}
