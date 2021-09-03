using Microsoft.AspNetCore.Mvc;
using Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Client.Controllers
{
    [Area("Client")]
    public class BooksController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Chapter()
        {
            return View();
        }
        public IActionResult Contents()
        {
            return View();
        }

        public IActionResult BooksDetail()
        {
            return View();
        }
        public IActionResult ChapterDetail()
        {
            return View();
        }
        public IActionResult ContentDetail()
        {
            return View();
        }
        public IActionResult BookView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveBook([FromBody] bookRequest obj)
        {
            var response = IM_InvokePostMethod(obj, "Client/Book/AddEditBook");
            return Json(response);
        }

        [HttpPost]
        public IActionResult SaveChapter([FromBody] chapterRequest obj)
        {
            var response = IM_InvokePostMethod(obj, "Client/Book/AddEditChapter");
            return Json(response);
        }


        [HttpPost]
        public IActionResult SaveContent([FromBody] ContentRequest obj)
        {
            var response = IM_InvokePostMethod(obj, "Client/Book/AddEditContent");
            return Json(response);
        }

        [HttpPost]
        public IActionResult getBookList()
        {
            var response = IM_InvokePostMethod("", "Client/Book/BookList");
            return Json(response);
        }
        [HttpPost]
        public IActionResult getChapterList(int id)
        {
            var response = IM_InvokePostMethod(id, "Client/Book/ChapterList");
            return Json(response);
        }

        [HttpPost]
        public IActionResult getChapterListByBook(int id)
        {
            var response = IM_InvokePostMethod(id, "Client/Book/ChapterListByBook");
            return Json(response);
        }


        [HttpPost]
        public IActionResult getContentList(string id)
        {
            var response = IM_InvokePostMethod(id, "Client/Book/ContentList");
            return Json(response);
        }
        [HttpPost]
        public IActionResult getContentListByChapterID(string id)
        {
            var response = IM_InvokePostMethod(id, "Client/Book/ContentListByChapterID");
            return Json(response);
        }



        [HttpPost]
        public IActionResult getSingleBook(int IDs)
        {
            var response = IM_InvokePostMethod(IDs, "Client/Book/BookList");
            return Json(response);
        }
        [HttpPost]
        public IActionResult getSingleChapter(int IDs)
        {
            var response = IM_InvokePostMethod(IDs, "Client/Book/ChapterList");
            return Json(response);
        }
        [HttpPost]
        public IActionResult getSingleContent(int IDs)
        {
            var response = IM_InvokePostMethod(IDs, "Client/Book/ContentList");
            return Json(response);
        }

        [HttpPost]
        public IActionResult getBookViewdata(int IDs)
        {
            var response = IM_InvokePostMethod(IDs, "Client/Book/LoadBook");
            return Json(response);
        }
    }
}
