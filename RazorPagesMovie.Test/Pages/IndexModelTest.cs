using Microsoft.AspNetCore.Mvc;
using RazorPagesMovie.Pages;
using Xunit;

namespace RazorPagesMovie.Test.Pages
{
    public class IndexModelTest
    {
        [Fact]
        void OnGet()
        {
            var model = new IndexModel();
            var actual = model.OnGet() as RedirectToPageResult;
            Assert.NotNull(actual);
            Assert.Equal("/Movies/Index", actual.PageName);
        }
    }
}
