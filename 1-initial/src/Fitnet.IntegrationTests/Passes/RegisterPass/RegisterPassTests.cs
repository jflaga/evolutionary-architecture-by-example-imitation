using Fitnet.Passes;
using Fitnet.Passes.RegisterPass;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnet.IntegrationTests.Passes.RegisterPass;

public class RegisterPassTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient applicationHttpClient;

    public RegisterPassTests(WebApplicationFactory<Program> applicationInMemoryFactory)
    {
        applicationHttpClient = applicationInMemoryFactory.CreateClient();
    }

    [Fact]
    public async Task Given_valid_pass_registration_request_Then_should_return_created_status_code()
    {
        var request = new RegisterPassRequest(Guid.NewGuid(), DateTimeOffset.Now, DateTimeOffset.Now.AddDays(30));
        var response = await applicationHttpClient.PostAsJsonAsync(PassesApiPaths.Passes, request);
        
        response.Should().HaveStatusCode(System.Net.HttpStatusCode.Created);
        var passId = await response.Content.ReadFromJsonAsync<Guid>();
        passId.Should().NotBe(Guid.Empty);
    }
}
