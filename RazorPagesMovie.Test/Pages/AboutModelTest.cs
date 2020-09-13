using RazorPagesMovie.Pages;
using Xunit;

namespace RazorPagesMovie.Test.Pages
{
    public class AboutModelTest
    {
        [Fact]
        void OnGet()
        {
            var model = new AboutModel();
            model.OnGet();
            Assert.Equal("Your application description page.", model.Message);
        }
    }
}
