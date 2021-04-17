using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MovieApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Text;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public User GetCurrentUser()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return null;
            }
            return dbContext
                .Users
                .First(u => u.UserId == userId);
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            // Movie[] movieList = new Movie();
            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/discover/movie?api_key=c2dc9f4c917b757a08a6c9fff8784481&language=en-US&sort_by=popularity.desc&include_adult=false&sort_by=vote_count.desc"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                }
            }
            User currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            ViewBag.MyMovie = dbContext.Watches
                .Include(u => u.UserWhoWatches)
                .ToList();

            return View(movieList.results);

        }

        [HttpGet("{pageNum}")]
        public async Task<IActionResult> IndexPages(int pageNum)
        {
            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/discover/movie?api_key=c2dc9f4c917b757a08a6c9fff8784481&language=en-US&sort_by=popularity.desc&include_adult=false&sort_by=vote_count.desc&page={pageNum}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                }
            }
            User currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            ViewBag.currentPage = pageNum;

            return View("Index", movieList.results);

        }


        [HttpGet("upcoming")]
        public async Task<IActionResult> Upcoming()
        {
            var currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/upcoming?language=en-US&api_key=c2dc9f4c917b757a08a6c9fff8784481"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                }
            }
            ViewBag.upcoming = true;

            return View("Index", movieList.results);
        }

        [HttpGet("upcoming/{pageNum}")]
        public async Task<IActionResult> UpcomingPages(int pageNum)
        {
            var currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/movie/upcoming?language=en-US&api_key=c2dc9f4c917b757a08a6c9fff8784481&page={pageNum}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                }
            }
            ViewBag.upcoming = true;
            ViewBag.upcomingPage = pageNum;

            return View("Index", movieList.results);
        }

        [HttpPost("search/{searchTitle}")]
        public async Task<IActionResult> SearchMovie(string searchTitle)
        {
            var currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/search/movie?api_key=c2dc9f4c917b757a08a6c9fff8784481&query={searchTitle}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                    var searchResult = movieList.results;
                    ViewBag.result = searchResult.All(movie => movie.title == searchTitle);

                    ViewBag.title = searchTitle;
                    // Console.WriteLine(apiResponse);   
                    ViewBag.searchPage = true;

                }
            }
            return View("SearchResult", movieList.results);
        }

        [HttpGet("random")]
        public IActionResult RandomPage()
        {
            var currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            return View();
        }

        // hard to filter out bad movies
        // [HttpGet("random-one")]
        // public async Task<IActionResult> OneRandomMovie()
        // {
        //     Random rand = new Random();
        //     int randomNum = rand.Next(20, 9999);

        //     using (var httpClient = new HttpClient())
        //     {
        //         using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/movie/{randomNum}?api_key=c2dc9f4c917b757a08a6c9fff8784481&language=en-US"))
        //         {
        //             string apiResponse = await response.Content.ReadAsStringAsync();
        //             Console.WriteLine(apiResponse);   
        //             ViewBag.ThisMovie = JsonConvert.DeserializeObject(apiResponse);
        //             ViewBag.id = randomNum;
        //             ViewBag.title = ViewBag.ThisMovie.title;
        //             ViewBag.vote_average = ViewBag.ThisMovie.vote_average;
        //             ViewBag.poster_path = ViewBag.ThisMovie.poster_path;
        //             ViewBag.overview = ViewBag.ThisMovie.overview;
        //             if(ViewBag.ThisMovie.genres != null)
        //             {
        //             ViewBag.genre = ViewBag.ThisMovie.genres;
        //             }

        //         }
        //         if(ViewBag.ThisMovie.title == null || ViewBag.ThisMovie.vote_average < 6)
        //         {
        //             return RedirectToAction("OneRandomMovie");
        //         }
        //     }
        //     return View("RandomPage");
        // }


        [HttpPost("random/{genreOne}/{genreTwo}/{rating}/{date}")]
        public async Task<IActionResult> RandomPick(int genreOne, int genreTwo, int rating, string date)
        {
            var currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/discover/movie?api_key=c2dc9f4c917b757a08a6c9fff8784481&language=en-US&with_genres={genreOne},{genreTwo}&vote_average.gte={rating}{date}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                    // Console.WriteLine(apiResponse);
                    ViewBag.genreOne = genreOne;
                    ViewBag.genreTwo = genreTwo;
                    ViewBag.rating = rating;
                    ViewBag.date = date;
                    Console.WriteLine(apiResponse); 
                }
            }

            return View("RandomResults", movieList.results.Take(5));
        }

        [HttpGet("random/reload/{genreOne}/{genreTwo}/{rating}/{date}")]
        public async Task<IActionResult> RandomPickReload(int genreOne, int genreTwo, int rating, string date)
        {
            var currentUser = GetCurrentUser();
            ViewBag.CurrentUser = currentUser;

            Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/discover/movie?api_key=c2dc9f4c917b757a08a6c9fff8784481&language=en-US&with_genres={genreOne},{genreTwo}&vote_average.gte={rating}{date}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<Movie>(apiResponse);
                    ViewBag.genreOne = genreOne;
                    ViewBag.genreTwo = genreTwo;
                    ViewBag.rating = rating;
                    ViewBag.date = date;
                    // Console.WriteLine(apiResponse); 
                }
            }

            if (HttpContext.Session.GetInt32("counter") == null) //checking if session exists
            {
                HttpContext.Session.SetInt32("counter", 0);
                ViewBag.Counter = HttpContext.Session.GetInt32("counter");
                return View("RandomResults", movieList.results.Skip(5).Take(5));
            }
            else if(HttpContext.Session.GetInt32("counter") >= 3 || movieList.results[0].title == null)
            {
                HttpContext.Session.Clear();
                return View("NoMoreResult");
            }
            else  
            {
                var currentCounter = (int)HttpContext.Session.GetInt32("counter")+1;
                HttpContext.Session.SetInt32("counter", currentCounter);
                ViewBag.Counter = currentCounter;
                Console.WriteLine(currentCounter);
                
                return View("RandomResults", movieList.results.Skip((currentCounter*5)+5).Take(5));
            }

            // needs to declare reloadMovies outside of the for loop
            // for (int i = 0; i < movieList.results.Count; i=i+5)
            // {
            //     var reloadMovies = movieList.results.Skip(i).Take(5);
            //     Console.WriteLine(reloadMovies);
            //     return View("RandomResults", reloadMovies);
            // }

            // return View("RandomResults");
        }


        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            var currentUser = GetCurrentUser();
            if (currentUser == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.CurrentUser = currentUser;

            ViewBag.MoviesToWatch = dbContext.Watches
                .Include(w => w.UserWhoWatches);
            // .Include(w => w.MovieTitle)
            // .OrderBy(d => d.Date);

            ViewBag.MovieLikes = dbContext.Likes
                .Include(l => l.UserWhoLikes);
            // .ThenInclude(l => l.FirstName);


            return View();
        }

        [HttpGet("watch/{movieId}/{movieTitle}")]
        public IActionResult AddToWatch(int movieId, string movieTitle)
        {
            var currentUser = GetCurrentUser();
            if (currentUser == null)
            {
                return RedirectToAction("LoginPage");
            }
            ViewBag.CurrentUser = currentUser;

            var likeToAdd = new Watch
            {
                UserId = GetCurrentUser().UserId,
                MovieId = movieId,
                MovieTitle = movieTitle
            };

            dbContext.Add(likeToAdd);
            dbContext.SaveChanges();

            return RedirectToAction("DetailPage");

        }

        [HttpGet("watch/{movieId}/{movieTitle}/delete")]
        public IActionResult DeleteWatch(int movieId, string movieTitle)
        {
            var currentUser = GetCurrentUser();

            var watchToDelete = dbContext.Watches.First(w => w.MovieId == movieId && w.UserId == currentUser.UserId);

            dbContext.Remove(watchToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("like/{movieId}/{movieTitle}")]
        public IActionResult AddToLike(int movieId, string movieTitle)
        {
            var currentUser = GetCurrentUser();
            if (currentUser == null)
            {
                return RedirectToAction("LoginPage");
            }
            ViewBag.CurrentUser = currentUser;

            var addingToLikes = new Like
            {
                UserId = GetCurrentUser().UserId,
                MovieId = movieId,
                MovieTitle = movieTitle
            };

            dbContext.Add(addingToLikes);
            dbContext.SaveChanges();

            return RedirectToAction("DetailPage");

        }

        [HttpGet("like/{movieId}/{movieTitle}/delete")]
        public IActionResult DeleteLike(int movieId, string movieTitle)
        {
            var currentUser = GetCurrentUser();

            var likeToDelete = dbContext.Likes.First(w => w.MovieId == movieId && w.UserId == currentUser.UserId);

            dbContext.Remove(likeToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("email/{movieId}")]
        public IActionResult SendEmail(string toEmail, string body, int movieId, string msg, string sender)
        {
            email(toEmail, body, movieId, msg, sender);
            return RedirectToAction("DetailPage");
        }
        public void email(string toEmail, string body, int movieId, string msg, string sender)
        {
            MailAddress to = new MailAddress(toEmail);
            MailAddress from = new MailAddress("cinephilrecommends@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Subject = $"Check out this movie from {sender}!";
            // ViewBag.subject = message.Subject;
            message.Body = $"hey, thought you might like this movie! \n \n http://cine-phil.azurewebsites.net/movie/{movieId}! \n \n {body}";
            // ViewBag.bodyMsg = $"Hey, check out this movie! http://localhost:5000/movie/{movieId}!";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
            Credentials = new NetworkCredential("cinephilrecommends", "Cinephil0!@"),
            EnableSsl = true
            };
            // code in brackets above needed if authentication required 
            try
            { 
            client.Send(message);
            }
            catch (SmtpException ex)
            {
            Console.WriteLine(ex.ToString());
            }
            
        }


        [HttpGet("/movie/{movieId}")]
        public async Task<IActionResult> DetailPage(int movieId)
        {
            var currentUser = GetCurrentUser();
            // if (currentUser == null)
            // {
            //     // System.Windows.Forms not supported
            //     // string message = "please log in to see the movie detail";
            //     // MessageBox.Show(message);
            //     return RedirectToAction("Index");
            // }
            ViewBag.CurrentUser = currentUser;

            // Movie[] movieList = new Movie();
            // Movie movieList = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/movie/{movieId}?api_key=c2dc9f4c917b757a08a6c9fff8784481&language=en-US"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    // Console.WriteLine(apiResponse);   
                    ViewBag.ThisMovie = JsonConvert.DeserializeObject(apiResponse);
                    // Console.WriteLine(ViewBag.ThisMovie);    
                    ViewBag.id = movieId;
                    ViewBag.title = ViewBag.ThisMovie.title;
                    ViewBag.tagline = ViewBag.ThisMovie.tagline;
                    ViewBag.overview = ViewBag.ThisMovie.overview;
                    ViewBag.runtimeHour = ViewBag.ThisMovie.runtime / 60;
                    ViewBag.runtimeMinute = (int)ViewBag.ThisMovie.runtime % 60;

                    // TimeSpan span = TimeSpan.FromMinutes(ViewBag.ThisMovie.runtime);
                    // string runtimeInHour = span.ToString(@"hh\:mm");
                    // ViewBag.RuntimeInHour = runtimeInHour;

                    ViewBag.vote_average = ViewBag.ThisMovie.vote_average;
                    ViewBag.release_date = ViewBag.ThisMovie.release_date;
                    ViewBag.poster_path = ViewBag.ThisMovie.poster_path;
                    ViewBag.backdrop_path = ViewBag.ThisMovie.backdrop_path;
                    if (ViewBag.ThisMovie.genres != null)
                    {
                        ViewBag.genre = ViewBag.ThisMovie.genres;
                    }

                }
            }

            return View();
        }


        [HttpGet("register")]
        public IActionResult RegisterPage()
        {
            return View();
        }
        [HttpPost("register-process")]
        public IActionResult Register(User userToRegister)
        {
            if (dbContext.Users.Any(u => u.Email == userToRegister.Email))
            {
                ModelState.AddModelError("Email", "Please use a different email.");
            }

            if (ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                userToRegister.Password = Hasher.HashPassword(userToRegister, userToRegister.Password);
                dbContext.Add(userToRegister);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", userToRegister.UserId);

                return RedirectToAction("Index");
            }

            return View("RegisterPage");
        }
        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("login-process")]
        public IActionResult Login(LoginUser userToLogin)
        {
            if (ModelState.IsValid)
            {
                // look in the DB              if we don't find the user at all, the default is null
                var foundUser = dbContext.Users.FirstOrDefault(u => u.Email == userToLogin.LoginEmail);

                if (foundUser == null)
                {
                    ModelState.AddModelError("LoginEmail", "Please check your email and password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userToLogin, foundUser.Password, userToLogin.LoginPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Please check your email and password");
                    return View("Index");
                }

                // set ID in session
                HttpContext.Session.SetInt32("UserId", foundUser.UserId);
                return RedirectToAction("Index");
            }
            return View("LoginPage");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
