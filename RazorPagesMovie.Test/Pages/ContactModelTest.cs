using RazorPagesMovie.Pages;
using Xunit;

namespace RazorPagesMovie.Test.Pages
{
    public class ContactModelTest
    {
        [Fact]
        void OnGet()
        {
            var model = new ContactModel();
            model.OnGet();
            Assert.Equal("Your contact page.", model.Message);
        }
    }
}
