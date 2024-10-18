﻿using Microsoft.EntityFrameworkCore;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.Concrete
{
    public class MyHotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2PU1K7L\\SQLEXPRESS; initial catalog=MyHotelApiDB; " +
                "integrated security=true ");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<myService> MyServices { get; set; }
    }
}