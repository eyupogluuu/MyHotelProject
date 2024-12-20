using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.BusinessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MyHotelContext>();

builder.Services.AddScoped<IStuffService, StuffManager>();
builder.Services.AddScoped<IStuffDal, EFStuffDal>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal, EFTestimonialDal>();

builder.Services.AddScoped<ImyServiceService, myServiceManager>();
builder.Services.AddScoped<ImyServiceDal, EFmyServiceDal>();

builder.Services.AddScoped<ISubscribeService, SubscribeManager>();
builder.Services.AddScoped<ISubscribeDal, EFSubscribeDal>();

builder.Services.AddScoped<IRoomService, RoomManager>();
builder.Services.AddScoped<IRoomDal, EFRoomDal>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EFAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EFBookingDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EFContactDal>();

builder.Services.AddScoped<IGuestService, GuestManager>();
builder.Services.AddScoped<IGuestDal, EFGuestDal>();

builder.Services.AddScoped<ISendMessageService, SendMessageManager>();
builder.Services.AddScoped<ISendMessageDal, EFSendMessageDal>();

builder.Services.AddScoped<IWorkLocationService, WorkLocationManager>();
builder.Services.AddScoped<IWorkLocationDal, EFWorkLocationDal>();

builder.Services.AddScoped<IAppUserService, AppUserManager>();
builder.Services.AddScoped<IAppUserDal, EFAppUserDal>();



builder.Services.AddCors(opt =>
    {
        opt.AddPolicy("MyHotelApi", opt =>
        {
            opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });

    });

builder.Services.AddControllers().AddNewtonsoftJson(options =>
           options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyHotelApi");
app.UseAuthorization();

app.MapControllers();

app.Run();
