using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.ApiClients
{
    public class OrderingApiClient(HttpClient httpClient)
    {
        public async Task<bool> CreateOrder(OrderDto orderDto)
        {
            var response = await httpClient.PostAsJsonAsync<OrderDto>("/orders", orderDto);
            return response.IsSuccessStatusCode;
        }
    }
}
