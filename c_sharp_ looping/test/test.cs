namespace test;

public class test
{
    [Fact]
    public void testbadge()
    {
        var b=new Book();
        b.AddBookPrice(100);
        b.AddBookPrice(100);
        b.AddBookPrice(100);
        b.AddBookPrice(100);
        b.AddBookPrice(100);

    }
}