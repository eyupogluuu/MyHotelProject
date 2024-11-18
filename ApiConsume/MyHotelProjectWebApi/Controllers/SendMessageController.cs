﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        
            private readonly ISendMessageService _sendMessageService;
            public SendMessageController(ISendMessageService sendMessageService)
            {
                _sendMessageService = sendMessageService;
            }

            [HttpGet]
            public IActionResult SendMessageList()
            {
                var values = _sendMessageService.TGetAll();
                return Ok(values);
            }
            [HttpPost]
            public IActionResult AddSendMessage(SendMessage sendMessage)
            {
                _sendMessageService.TInsert(sendMessage);
                return Ok();
            }
            [HttpDelete("{id}")]
            public IActionResult DeleteSendMessage(int id)
            {
                var values = _sendMessageService.TGetByID(id);
                _sendMessageService.TDelete(values);
                return Ok();
            }
            [HttpPut]
            public IActionResult UpdateSendMessage(SendMessage sendMessage)
            {
                _sendMessageService.TUpdate(sendMessage);
                return Ok();
            }
            [HttpGet("{id}")]
            public IActionResult GetSendMessage(int id)
            {
                var values = _sendMessageService.TGetByID(id);
                return Ok(values);
            }
            //[HttpGet("GetSendMessageCount")]
            //public IActionResult GetSendMessageCount()
            //{
            //    return Ok(_sendMessageService.TGetSendMessageCount());
            //}

        }
    }
