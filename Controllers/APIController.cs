// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// namespace MovieApp.Controllers
// {
//     [Route("api/movies")]
//     [ApiController]
//     public class APIController : ControllerBase
//     {
//         [HttpGet]
//         public async Task<ActionResult<string>> Get()
//         {
//             string url="https://api.themoviedb.org/3/discover/movie?api_key=c2dc9f4c917b757a08a6c9fff8784481&sort_by=popularity.desc"; // sample url
//             using (HttpClient client = new HttpClient())
//             {
//                 return  await client.GetStringAsync(url);
//             }
//         }
//     }
// }