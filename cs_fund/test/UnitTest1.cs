using cs_fund;

namespace test;

public class UnitTest1
{
   [Fact]
    public void Test1()
    {
        var st = new Stu("Supraja");
        st.AddScroe(34.4);
        st.AddScroe(44.4);
        st.AddScroe(56.4);
        st.AddScroe(66.4);
        st.AddScroe(38.4);
        var a = st.per();
        Assert.Equal(a,240);


    }
    [Fact]
    public void testrefrence()
    {
        var book1=GetStudentname("Supraja");
        var book2=GetStudentname("Supraja");
        Assert.True(Object.ReferenceEquals(book1,book2));

        
    }
       [Fact]
    public void testobject_reference()
    {
        var book1=GetStudentname("Supraja");
        var book2=book1;
        Assert.Same(book1,book2);
        Assert.False(Object.ReferenceEquals(book1,book2));
      
    }
        Stu GetStudentname(string s)
        { 
            return new Stu(s);

        }
    
}