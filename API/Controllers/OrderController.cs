using API.DomainEvents.MediatorDesignPattern;
using API.DomainEvents.MediatR;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create-order-delegate")]
        public IActionResult CreateOrderDelegate()
        {
            DomainEvents.Delegate.Order order = new();
            order.OrderCompleted += () =>
            {
                //
            };

            order.CompleteOrder();

            return Ok();
        }

        [HttpPost("create-order-eventhandlers")]
        public IActionResult CreateOrderEventHandlers()
        {
            DomainEvents.EventHandlers.Order order = new(); 
            order.OrderCompleted += (sender, ew) => 
            {
            };

            order.CompleteOrder();
            return Ok();
        }

        [HttpPost("create-order-mediatr-designpattern")]
        public IActionResult CreateOrderMediatorDesignPattern()
        {
            Order order = new();
            OrderMediator mediator = new();
            SmsService smsService = new();

            mediator.Register(smsService);

            mediator.OrderCompleted(order);

            return Ok();
        }


        [HttpPost("create-order-mediatr")]
        public IActionResult CreateOrderMediatR()
        {
            OrderCreatedEvent orderCreatedEvent = new()
            {
                OrderId = Guid.NewGuid(),
                OrderItems = new List<object> { "A" ,"B" }
            };

            _mediator.Publish(orderCreatedEvent);   

            return Ok();
        }
        
    }
}
