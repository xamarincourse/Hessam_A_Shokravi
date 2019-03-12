using HW7.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
  public static class BoardingPassService
  {
    public static async Task<BoardingPass> GetAsync(string id)
    {
      var client = new HttpClient
      {
        BaseAddress = new Uri("http://localhost:59638/"),
        Timeout = TimeSpan.FromSeconds(30)
      };

      using (var response = await client.GetAsync("api/BoardingPass/" + id).ConfigureAwait(false))
      {
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        var data = JsonConvert.DeserializeObject<BoardingPass>(body);
        return data;
      }
    }
  }
}
