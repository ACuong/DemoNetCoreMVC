using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoDotNetMVC.Models;
using DemoDotNetMVC.Models.Process;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace DemoDotNetMVC.Controllers
{
    public class MoviesController : Controller
    {
        ExcelProcess _excelPro = new ExcelProcess();
        private readonly ApplicationDBContext _context;

        public MoviesController(ApplicationDBContext context)
        {
            _context = context;
        }
        
        public IConfiguration Configuration{get;}

        private int WriteDatatableToDatabase(DataTable dt)
        {
        try{
            var con = Configuration.GetConnectionString("ApplicationContext");
            //using bulkcopy to copy data from datatable to databse
            SqlBulkCopy bulkcopy = new SqlBulkCopy(con);
            bulkcopy.DestinationTableName = "Movies";
            bulkcopy.ColumnMappings.Add(0,"MoviesID");
            bulkcopy.ColumnMappings.Add(1,"MoviesName");
            bulkcopy.ColumnMappings.Add(3,"Price");
            bulkcopy.ColumnMappings.Add(4,"Genre");
            bulkcopy.ColumnMappings.Add(5,"Price");
            bulkcopy.WriteToServer(dt);
        }
            catch{
            return 0;	
        }
            return dt.Rows.Count;
          
        }

        // GET: Movies
       
    public async Task<IActionResult> Index(string movieGenre, string searchString)
        {// Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movies
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movies
                        select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.MoviesName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };

            return View(movieGenreVM);
        }


        // GET: Movies/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies
                .FirstOrDefaultAsync(m => m.MoviesID == id);
            if (movies == null)
            {
                return NotFound();
            }

            return View(movies);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoviesID,MoviesName,Price,Genre,Rating")] Movies movies, IFormFile file)
        {
            if (file != null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
            
                else
                {
                    //rename file when upload to server
                    //tao duong dan /Uploads/Excels de luu file upload len server
                    var fileName = "DanhSach";
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName + fileExtension);
                    var fileLocation = new FileInfo(filePath).ToString();

                    if (ModelState.IsValid)
                    {
                        //upload file to server
                        if (file.Length > 0)
                        {
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                //save file to server
                                await file.CopyToAsync(stream);
                                //read data from file and write to database
                                //_excelPro la doi tuong xu ly file excel ExcelProcess
                                var dt = _excelPro.ExcelToDataTable(fileLocation);
                                //ghi du lieu datatable vao database
                                WriteDatatableToDatabase(dt);
                                
                            }
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
            }
            
            return View(movies);
        }

         

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies.FindAsync(id);
            if (movies == null)
            {
                return NotFound();
            }
            return View(movies);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MoviesID,MoviesName,Price,Genre,Rating")] Movies movies)
        {
            if (id != movies.MoviesID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoviesExists(movies.MoviesID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movies);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies
                .FirstOrDefaultAsync(m => m.MoviesID == id);
            if (movies == null)
            {
                return NotFound();
            }

            return View(movies);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var movies = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoviesExists(string id)
        {
            return _context.Movies.Any(e => e.MoviesID == id);
        }
    }
}
