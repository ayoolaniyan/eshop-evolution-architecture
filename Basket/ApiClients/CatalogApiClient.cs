namespace Basket.ApiClients
{
    public class CatalogApiClient(HttpClient httpClient)
    {
        public async Task<ProductDto> GetProductById(int id)
        {
            var response = await httpClient.GetFromJsonAsync<ProductDto>($"/products/{id}");
            return response!;
        }
    }
}
